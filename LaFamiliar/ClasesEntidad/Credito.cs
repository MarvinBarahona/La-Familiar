using La_Familiar.Clases;
using La_Familiar.ClasesServicio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Familiar.ClasesEntidad
{
    public class Credito
    {
        #region Datos del credito
        private int _id;
        private string _codigo;
        private int _idAsociado;
        private string _tipo;
        //private string _categoria;
        private decimal _monto;
        private byte _interes;
        private decimal _cuota;
        private byte _plazo;
        private string _forma_pago;
        private DateTime _fecha;
        private decimal _aportacion;
        private decimal _cuota_social;
        private bool _garantia_aportacion;
        private bool _activo;

        private Asociado _asociado;
        private CreditoDescuento _creditoDescuento;

        private List<GarantiaFiador> _fiadores;
        private List<GarantiaHipotecaria> _hipotecarias;
        private List<GarantiaPrendaria> _prendarias;

        private List<CreditoDetalle> _detallesPago;

        private List<int> _depositos;
        private List<string> _codDepositos;
        #endregion

        #region Getters y setters
        public int id { get { return _id; } set { _id = value; } }
        public string codigo { get { return _codigo; } set { _codigo = value; } }
        public int idAsociado { get { return _idAsociado; } set { _idAsociado = value; } }
        public string tipo { get { return _tipo; } set { _tipo = value; } }
        public decimal monto { get { return _monto; } set { _monto = value; } }
        public byte interes { get { return _interes; } set { _interes = value; } }
        public decimal cuota { get { return _cuota; } set { _cuota = value; } }
        public byte plazo { get { return _plazo; } set { _plazo = value; } }
        public string forma_pago { get { return _forma_pago; } set { _forma_pago = value; } }
        public DateTime fecha { get { return _fecha; } set { _fecha = value; } }
        public decimal aportacion { get { return _aportacion; } set { _aportacion = value; } }
        public decimal cuota_social { get { return _cuota_social; } set { _cuota_social = value; } }
        public bool garantia_aportacion { get { return _garantia_aportacion; } set { _garantia_aportacion = value; } }
        public bool activo { get { return _activo; } set { _activo = value; } }

        public Asociado asociado { get { return _asociado; } set { _asociado = value; } }
        public CreditoDescuento creditoDescuento { get { return _creditoDescuento; } set { _creditoDescuento = value; } }

        public List<GarantiaFiador> fiadores { get { return _fiadores; } set { _fiadores = value; } }
        public List<GarantiaHipotecaria> hipotecarias { get { return _hipotecarias; } set { _hipotecarias = value; } }
        public List<GarantiaPrendaria> prendarias { get { return _prendarias; } set { _prendarias = value; } }

        public List<CreditoDetalle> detallesPago { get { return _detallesPago; } set { _detallesPago = value; } } 

        public List<int> depositos { get { return _depositos; } set { _depositos = value; } }
        public List<string> codDepositos { get { return _codDepositos; } set { _codDepositos = value; } }

        #endregion

        public decimal saldoActual {
            get {
                int count = this.detallesPago.Count;
                decimal interesAcumulado;

                decimal saldo = count > 0 ? this.detallesPago[count - 1].saldoParcial : this.monto;

                //Tasa anual nominal dividida entre 12 para hacerla mensual real y luego entre 30 para hacerla diaria.
                decimal tasaR = Convert.ToDecimal((double)interes / (100 * 12 * 30));

                if (this.fechaUltimoPago.Day == DateTime.Today.Day)
                    interesAcumulado = saldo * tasaR * 30 * (DateTime.Today.monthsSince(this.fechaUltimoPago));
                else
                    interesAcumulado = saldo * tasaR * (DateTime.Today - this.fechaUltimoPago).Days;

                return saldo += interesAcumulado;
            }
        }

        public DateTime fechaUltimoPago
        {
            get
            {
                DateTime fechaUltimoPago = this.fecha;
                if (this.detallesPago != null && this.detallesPago.Count > 0)
                    fechaUltimoPago = this.detallesPago[this.detallesPago.Count - 1].fecha;

                return fechaUltimoPago;
            }
        }

        public int diasMora
        {
            get
            {
                int d = (DateTime.Today - this.fechaUltimoPago.AddMonths(1)).Days;
                if(d < 0) d = 0;
                return d;
            }
        }

        public char categoria
        {
            get
            {
                int d = this.diasMora;
                char c;

                if (d > 120) c = 'F';
                else if (d > 90) c = 'D';
                else if (d > 60) c = 'C';
                else if (d > 30) c = 'B';
                else c = 'A';

                return c;
            }            
        }

        public string garantia
        {
            get
            {
                string g;

                List<string> garantias = new List<string>();

                if(this.forma_pago == "Orden de descuento") garantias.Add("Orden de descuento");
                if (this.fiadores != null && this.fiadores.Count > 0) garantias.Add("Fiador solidario");
                if (this.hipotecarias != null && this.hipotecarias.Count > 0) garantias.Add("Garantía hipotecaria");
                if (this.prendarias != null && this.prendarias.Count > 0) garantias.Add("Garantía prendaria");
                if (this.depositos != null && this.depositos.Count > 0) garantias.Add("Ahorro a plazo");
                if (this.garantia_aportacion) garantias.Add("Aportaciones");

                int i = garantias.Count;

                if (i == 0) g = "Sin garantías";
                else
                {
                    g = "";

                    while (i > 0)
                    {
                        g += garantias[garantias.Count - i];
                        if (i - 1 == 1) g += " y ";
                        else if (i - 1 > 1) g += ", ";
                        i--;
                    }
                    
                }

                return g;
            }
        }

// ###########################################################################################
// ##########################      Datos iniciales del crédito      ##########################
// ###########################################################################################

        public Credito()
        {
            this.activo = true;
        }

// ###########################################################################################
// ##########################         Guardar el crédito            ##########################
// ###########################################################################################

        public void insert() 
        {
            string query;
            List<SqlParameter> parameters;

            try
            { 
                // ##############  Guardar en la tabla credito  #####################

                query = "INSERT INTO ASOCIADOS.CREDITO(codigo, id_asociado, tipo, monto, interes, cuota, " +
                        "plazo, forma_pago, fecha, aportacion, cuota_social, garantia_aportacion, activo) " +
                        "output inserted.id VALUES (@codigo, @id_asociado, @tipo, @monto, @interes, @cuota, " +
                        "@plazo, @forma_pago, @fecha, @aportacion, @cuota_social, @garantia_aportacion, @activo)";

                parameters = new List<SqlParameter>()
                {
                    #region Parametros Credito
                    new SqlParameter("codigo", codigo),
                    new SqlParameter("id_asociado", idAsociado),
                    new SqlParameter("tipo", tipo),
                    new SqlParameter("monto", monto),
                    new SqlParameter("interes", interes),
                    new SqlParameter("cuota", cuota),
                    new SqlParameter("plazo", plazo),
                    new SqlParameter("forma_pago", forma_pago),
                    new SqlParameter("fecha", fecha),
                    new SqlParameter("aportacion", aportacion),
                    new SqlParameter("cuota_social", cuota_social),
                    new SqlParameter("garantia_aportacion", garantia_aportacion),
                    new SqlParameter("activo", activo)
                    #endregion
                };
                this.id = Queries.executeScalar(query, parameters);


                // ##################  Guardar en la tabla creditodescuento  ##################

                query = "INSERT INTO ASOCIADOS.CREDITODESCUENTO(id_credito, cuota_ingreso, escrituracion, seguro, papeleria) "+
                        "VALUES (@id, @cuota_ingreso, @escrituracion, @seguro, @papeleria)";

                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("id", id),
                    new SqlParameter("cuota_ingreso", creditoDescuento.cuota_ingreso),
                    new SqlParameter("escrituracion", creditoDescuento.escrituracion),
                    new SqlParameter("seguro", creditoDescuento.seguro),
                    new SqlParameter("papeleria", creditoDescuento.papeleria)
                };
                Queries.execute(query, parameters);


                // ###############  Guardar en tabla fiador.  #########################

                query = "INSERT INTO ASOCIADOS.FIADOR(id_credito, dui, nombres, apellidos, direccion, telefono, nit) " + 
                    "output inserted.id VALUES (@id, @dui, @nombres, @apellidos, @dir, @tel, @nit)";
             
                if (fiadores != null) foreach (GarantiaFiador fiador in fiadores)
                {
                    parameters = new List<SqlParameter>()
                    {
                        new SqlParameter("id", id),
                        new SqlParameter("dui", fiador.dui),
                        new SqlParameter("nombres", fiador.nombres),
                        new SqlParameter("apellidos", fiador.apellidos),
                        new SqlParameter("dir", fiador.direccion),
                        new SqlParameter("tel", fiador.telefono),
                        new SqlParameter("nit", fiador.nit)
                    };
                    fiador.id = Queries.executeScalar(query, parameters);
                }


                //  ###########  Guardar en la tabla hipotecaria.  ################

                if (hipotecarias != null) foreach (GarantiaHipotecaria hipotecaria in hipotecarias)
                {
                    parameters = new List<SqlParameter>();
                    if (hipotecaria.fiador == null)
                    {
                        query = "INSERT INTO ASOCIADOS.HIPOTECARIA(id_credito, direccion, matricula, medidas) " +
                            "VALUES(@id, @dir, @matricula, @medidas)";
                    }
                    else
                    {
                        query = "INSERT INTO ASOCIADOS.HIPOTECARIA(id_credito, id_fiador, direccion, matricula, medidas) " +
                            " VALUES(@id, @idFiador, @dir, @matricula, @medidas)";
                        parameters.Add(new SqlParameter("idFiador", hipotecaria.fiador.id));
                    }

                    parameters.Add(new SqlParameter("id", id));
                    parameters.Add(new SqlParameter("dir", hipotecaria.direccion));
                    parameters.Add(new SqlParameter("matricula", hipotecaria.matricula));
                    parameters.Add(new SqlParameter("medidas", hipotecaria.medidas));

                    Queries.execute(query, parameters);
                }


                // ##########  Guardar en la tabla prendaria.  ###############

                if (prendarias != null) foreach (GarantiaPrendaria prendaria in prendarias)
                {
                    parameters = new List<SqlParameter>();
                    if (prendaria.fiador == null)
                    {
                        query = "INSERT INTO ASOCIADOS.PRENDARIA(id_credito, bien, descripcion) " +
                            " VALUES(@id, @bien, @desc)";
                    }
                    else
                    {
                        query = "INSERT INTO ASOCIADOS.PRENDARIA(id_credito, id_fiador, bien, descripcion) " +
                            "VALUES(@id, @idFiador, @bien, @desc)";
                        parameters.Add(new SqlParameter("idFiador", prendaria.fiador.id));
                    }

                    parameters.Add(new SqlParameter("id", id));
                    parameters.Add(new SqlParameter("bien", prendaria.bien));
                    parameters.Add(new SqlParameter("desc", prendaria.descripcion));

                    Queries.execute(query, parameters);
                }

                // ##########  Guardar en los depósitos a plazo.  ###############

                if (depositos != null) foreach (int idAhorro in depositos)
                {
                    parameters = new List<SqlParameter>();

                    query = "insert into asociados.garantiadeposito(id_credito, id_ahorro) values(@credito, @ahorro)";

                    parameters.Add(new SqlParameter("credito", id));
                    parameters.Add(new SqlParameter("ahorro", idAhorro));

                    Queries.execute(query, parameters);
                }
            }

            catch (SqlException ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


// ###########################################################################################
// ########################    Insertar un nuevo detalle de pago       #######################
// ###########################################################################################

        public void insertDetalle(decimal monto, decimal aportacion, decimal cuotaSocial, DateTime fecha)
        {
            // #### Variables ####

            int count = this.detallesPago.Count;
            decimal saldo = count > 0 ? this.detallesPago[count - 1].saldoParcial : this.monto;

            decimal montoAux, interesAcumulado;

            //Tasa anual nominal dividida entre 12 para hacerla mensual real y luego entre 30 para hacerla diaria.
            decimal tasaR = Convert.ToDecimal((double)interes / (100 * 12 * 30)); 


            // #### Insertar a la lista ####

            CreditoDetalle detalle = new CreditoDetalle(monto, aportacion, cuotaSocial, fecha);    


            // #### Obtener el interés acumulado desde el último pago. 

            if (this.fechaUltimoPago.Day == detalle.fecha.Day && detalle.fecha.monthsSince(this.fechaUltimoPago) == 1)
                interesAcumulado = saldo * tasaR * 30;
            else
                interesAcumulado = saldo * tasaR * (detalle.fecha - this.fechaUltimoPago).Days;


            // #### Asignar el interés y capital pagado al detalle del pago. 

            montoAux = detalle.monto_pagado - detalle.cuota_social - detalle.aportacion;
            detalle.interes = montoAux >= interesAcumulado ? interesAcumulado : montoAux;
            detalle.capital = montoAux - interesAcumulado;
            detalle.saldoParcial = saldo - detalle.capital;


            // #### Guardar el detalle en la base ####

            string query = "insert into asociados.creditodetalle(id_credito, monto_pagado, interes, capital, fecha, " +
                "aportacion, cuota_social, saldoParcial) values (@id, @monto, @interes, @capital, @fecha, @aportacion, " +
                "@cSocial, @saldoParcial)";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("id", this.id), 
                new SqlParameter("monto", detalle.monto_pagado), 
                new SqlParameter("interes", detalle.interes),
                new SqlParameter("capital", detalle.capital),
                new SqlParameter("fecha", detalle.fecha), 
                new SqlParameter("aportacion", detalle.aportacion),
                new SqlParameter("cSocial", detalle.cuota_social),
                new SqlParameter("saldoParcial", detalle.saldoParcial)
            };
            Queries.execute(query, parameters);


            // #### Agregando el nuevo detalle a la lista (se agrega al final ya que primero debe registrarse en la base para evitar errores)
            
            this.detallesPago.Add(detalle);        


            // #### Inserta una nueva aportación al asociado  ####

            if (detalle.aportacion != 0)
            {
                AportacionDetalle detalleAportacion = new AportacionDetalle(this.asociado, "Abono crédito", detalle.fecha, detalle.aportacion);
                detalleAportacion.insert();
            }


            // #### Finalizar crédito si el saldo parcial es 0 o menor. ####

            if (detalle.saldoParcial <= 0)
            {
                query = "update asociados.credito set activo = @activo where id = @id";
                parameters = new List<SqlParameter>()
                {
                    new SqlParameter("activo", false), 
                    new SqlParameter("id", this.id)
                };
                Queries.execute(query, parameters);
            }

            detalle.correlativo = this.detallesPago.Count;
            Reportes.reciboPago(this.asociado, this, detalle);
        }
    }
}
