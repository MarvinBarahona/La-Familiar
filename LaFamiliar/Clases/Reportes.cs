using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using La_Familiar.ClasesEntidad;
using System;
using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using La_Familiar.ClasesServicio;
using La_Familiar.DataSets;

namespace La_Familiar.Clases
{
    static class Reportes
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\La Familiar\\";
        
        static string nomAsociado = "", ubicacion="";

        static void crearCarpeta(Asociado asociado, string codigo = "") {
            nomAsociado = asociado.nombre +" "+ asociado.apellido;
            ubicacion = path + asociado + " - " + nomAsociado + "\\";
            if (!string.IsNullOrEmpty(codigo))
            {
                ubicacion += codigo + "\\";
            }
            
            if (!Directory.Exists(ubicacion))
                Directory.CreateDirectory(ubicacion);                        
        }


        /*#########################################################################*
         *                          DOCUMENTOS .DOCX                               *
         *#########################################################################*/
        public static void cartaAprobacion(Asociado asociado, Credito credito) {
            crearCarpeta(asociado, credito.codigo);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Carta de aprobacion.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Word.Field campo in wordDoc.Fields) {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD")) {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();
                    
                    campo.Select();
                    string texto = "";
                    #region Campos
                    switch (fieldName)
                    {
                        case("fecha"):
                            texto = DateTime.Today.fechaLarga();
                            break;
                        case ("asociado"):
                            texto = nomAsociado;
                            break;
                        case ("diaMes"):
                            texto = credito.fecha.fechaLarga();
                            break;
                        case ("monto"):
                            texto = credito.monto.ToString("C");
                            break;
                        case ("montoLetras"):
                            texto = Numalet.ToCardinal(credito.monto).ToUpper();
                            break;
                        case ("tasa"):
                            texto = credito.interes.ToString();
                            break;
                        case ("plazo"):
                            texto = credito.plazo.ToString();
                            break;
                        case ("cuota"):
                            texto = credito.cuota.ToString("C");
                            break;
                        case ("cuotaLetras"):
                            texto = Numalet.ToCardinal(credito.cuota).ToUpper();
                            break;
                        case ("formaPago"):
                            texto = credito.forma_pago;
                            break;
                        case ("garantia"):
                            texto = credito.garantia;
                            break;
                        default:
                            texto = "COMPLETAR CAMPO";
                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }

            wordDoc.SaveAs2(@ubicacion + "Carta aprobación", Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
        }

        public static void hojaLiquidacion(Asociado asociado, Credito credito) {
            crearCarpeta(asociado, credito.codigo);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Hoja de liquidacion.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Word.Field campo in wordDoc.Fields)
            {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    campo.Select();
                    string texto = "";
                    #region Campos
                    decimal ingreso=credito.creditoDescuento.cuota_ingreso, 
                            escr = credito.creditoDescuento.escrituracion,
                            seg = credito.creditoDescuento.seguro, 
                            pap = credito.creditoDescuento.papeleria,
                            desc = ingreso+escr+seg+pap;
                    switch (fieldName)
                    {
                        case ("fecha"):
                            texto = credito.fecha.fechaLarga();
                            break;
                        case ("asociado"):
                            texto = nomAsociado;
                            break;
                        case ("codigo"):
                            texto = credito.codigo;
                            break;
                        case ("monto"):
                            texto = credito.monto.ToString("C");
                            break;
                        case("aportacionInicial"):
                            texto = ingreso.ToString("C");
                            break;
                        case("escrituracion"):
                            texto = escr.ToString("C");
                            break;
                        case("seguro"):
                            texto = seg.ToString("C");
                            break;
                        case("papeleria"):
                            texto = pap.ToString("C");
                            break;
                        case("descuentos"):
                            texto = desc.ToString("C");
                            break;
                        case("liquido"):
                            texto = Math.Round(credito.monto - desc, 2).ToString("C");
                            break;
                        default:
                            texto = "COMPLETAR CAMPO";
                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }

            wordDoc.SaveAs2(@ubicacion + "Hoja de liquidación", Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
        }
        
        public static void mutuo(Asociado asociado, Credito credito) {
            crearCarpeta(asociado, credito.codigo);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Mutuo.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            string duiLet, nitLet;
            string[] dui = docLetras(asociado.dui.numero.ToString()),
                     nit = docLetras(asociado.infoPersonal.nit);

            duiLet = dui[0] + " - " + dui[1];
            nitLet = nit[0] + " - " + nit[1] + " - " + nit[2] + " - " + nit[3];

            foreach (Word.Field campo in wordDoc.Fields)
            {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    campo.Select();
                    string texto = "";
                    #region Campos
                    switch (fieldName)
                    {                        
                        case ("asociado"):
                            texto = nomAsociado;
                            break;
                        case ("edad"):
                            texto = Numalet.ToCardinal(asociado.nacimiento.edad).Replace(" con 00/100", "");
                            break;
                        case ("ocupacion"):
                            texto = asociado.trabajo.cargo;
                            break;
                        case ("municipio"):
                            texto = asociado.infoPersonal.municipio;
                            break;
                        case ("departamento"):
                            texto = asociado.infoPersonal.departamento;
                            break;
                        case ("dui"):
                            texto = duiLet;
                            break;
                        case ("nit"):
                            texto = nitLet;
                            break;
                        case ("monto"):
                            texto = Numalet.ToCardinal(credito.monto).ToUpper();
                            break;
                        case ("plazo"):
                            texto = Numalet.ToCardinal(credito.plazo).ToUpper();
                            break;
                        case ("interes"):
                            texto = Numalet.ToCardinal(credito.interes / 12).ToUpper();
                            break;
                        case ("cuota"):
                            texto = Numalet.ToCardinal(credito.cuota).ToUpper();
                            break;
                        case ("plazomenos"):
                            texto = Numalet.ToCardinal(credito.plazo - 1);
                            break;
                        case ("aportacion"):
                            texto = Numalet.ToCardinal(credito.aportacion);
                            break;
                        case ("dia"):
                            texto = credito.fecha.Day.ToString();
                            break;
                        case ("fecha"):
                            texto = DateTime.Today.fechaLargaTexto();
                            break;
                        default:
                            texto = "INGRESAR CAMPO";
                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }

            wordDoc.SaveAs2(@ubicacion + "Mutuo", Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
        }

        public static void ordenDescuento(Asociado asociado, Credito credito) {
            crearCarpeta(asociado, credito.codigo);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Orden de descuento credito.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Word.Field campo in wordDoc.Fields)
            {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    campo.Select();
                    string texto = "";
                    #region Campos
                    switch (fieldName)
                    {
                        case ("fecha"):
                            texto = DateTime.Today.fechaLarga();
                            break;
                        case ("asociado"):
                            texto = nomAsociado;
                            break;
                        case ("puestoTrabajo"):
                            texto = asociado.trabajo.cargo;
                            break;
                        case ("numCuotasLetras"):
                            texto = Numalet.ToCardinal(credito.plazo).ToUpper();
                            break;
                        case ("cuotaLetras"):
                            texto = Numalet.ToCardinal(credito.cuota);
                            break;
                        case ("cuota"):
                            texto = credito.cuota.ToString("C");
                            break;
                        case ("codigo"):
                            texto = credito.codigo;
                            break;
                        case ("sueldo"):
                            texto = asociado.infoPersonal.ingresos.ToString("C");
                            break;
                        case ("lugartrabajo"):
                            texto = asociado.trabajo.lugar.nombre;
                            break;
                        case ("mes"):
                            texto = mes(credito.fecha.Month + 1);
                            break;
                        case ("anio"):
                            int y = credito.fecha.Year;
                            if (credito.fecha.Month == 12) y++;
                            texto = y.ToString();
                            break;
                        default:
                            texto = "EDITAR CAMPO";
                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }

            wordDoc.SaveAs2(@ubicacion + "Orden de descuento", Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
        }

        public static void ordenDescuento(Asociado asociado, Ahorro ahorro)
        {
            crearCarpeta(asociado, ahorro.codigo);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Orden de descuento ahorro.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Word.Field campo in wordDoc.Fields)
            {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    campo.Select();
                    string texto = "";
                    #region Campos
                    switch (fieldName)
                    {
                        case ("fecha"):
                            texto = DateTime.Today.fechaLarga();
                            break;
                        case ("asociado"):
                            texto = nomAsociado;
                            break;
                        case ("puestoTrabajo"):
                            texto = asociado.trabajo.cargo;
                            break;
                        case ("numCuotasLetras"):
                            texto = Numalet.ToCardinal(ahorro.ahorroProgramado.duracion);
                            break;
                        case ("cuotaLetras"):
                            texto = Numalet.ToCardinal(ahorro.ahorroProgramado.cuota);
                            break;
                        case ("cuota"):
                            texto = ahorro.ahorroProgramado.cuota.ToString("C");
                            break;
                        case ("codigo"):
                            texto = ahorro.codigo;
                            break;
                        case ("sueldo"):
                            texto = asociado.infoPersonal.ingresos.ToString("C");
                            break;
                        case ("lugartrabajo"):
                            texto = asociado.trabajo.lugar.nombre;
                            break;
                        case ("mes"):
                            texto = mes(ahorro.fecha.Month + 1);
                            break;
                        case ("anio"):
                            int y = ahorro.fecha.Year;
                            if (ahorro.fecha.Month == 12) y++;
                            texto = y.ToString();
                            break;
                        default:
                            texto = "EDITAR CAMPO";
                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }

            wordDoc.SaveAs2(@ubicacion + "Orden de descuento", Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
        }

        public static void constanciaSaldos(Asociado asociado, Credito credito) {
            crearCarpeta(asociado, credito.codigo);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Constancia de saldos.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Word.Field campo in wordDoc.Fields)
            {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    campo.Select();
                    string texto = "";
                    #region Campos
                    switch (fieldName)
                    {
                        case ("asociada"):
                            texto = nomAsociado;
                            break;
                        case ("saldoActual"):
                            texto = Numalet.ToCardinal(credito.saldoActual);
                            break;
                        case("dui"):
                            texto = asociado.dui.numero;
                            break;
                        case("fecha"):
                            texto = DateTime.Today.fechaLarga();
                            break;
                        case ("codigo"):
                            texto = credito.codigo;
                            break;
                        case ("fechaOtorgamiento"):
                            texto = credito.fecha.ToShortDateString();
                            break;
                        case ("fechaVencimiento"):
                            texto = credito.fecha.AddMonths(credito.plazo).ToShortDateString();
                            break;
                        case ("plazo"):
                            texto = credito.plazo.ToString();
                            break;
                        case ("tasa"):
                            texto = credito.interes + " %";
                            break;
                        case ("categoria"):
                            texto = credito.categoria.ToString();
                            break;
                        case ("diasMora"):
                            texto = credito.diasMora.ToString();
                            break;
                        case ("monto"):
                            texto = credito.monto.ToString("C");
                            break;
                        case ("cuota"):
                            texto = credito.cuota.ToString("C");
                            break;
                        case ("estado"):
                            if(DateTime.Today > credito.fecha.AddMonths(credito.plazo)){
                                texto = "VENCIDO";
                            }else{
                                texto = "VIGENTE A LA FECHA";
                            }                                
                            break;
                        case ("saldo"):
                            texto = credito.saldoActual.ToString("C");
                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }

            wordDoc.SaveAs2(@ubicacion + "Constancia de saldo " + DateTime.Today.Day.ToString() + "-" + mes(DateTime.Today.Month), Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
        }
        
        public static void contraorden(Asociado asociado, Credito credito)
        {
            crearCarpeta(asociado, credito.codigo);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Contraorden de descuento.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Word.Field campo in wordDoc.Fields)
            {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    campo.Select();
                    string texto = "";
                    #region Campos
                    switch (fieldName)
                    {
                        case ("fecha"):
                            texto = DateTime.Today.fechaLarga();
                            break;
                        case ("lugartrabajo"):
                            texto = asociado.trabajo.lugar.nombre;
                            break;
                        case ("asociado"):
                            texto = nomAsociado;
                            break;
                        case ("puestoTrabajo"):
                            texto = asociado.trabajo.cargo;
                            break;
                        case ("cuotaLetras"):
                            texto = Numalet.ToCardinal(credito.cuota);
                            break;
                        case ("cuota"):
                            texto = credito.cuota.ToString("C");
                            break;
                        case ("mes"):
                            texto = mes(credito.fecha.Month + 1);
                            break;
                        case ("anio"):
                            int y = credito.fecha.Year;
                            if (credito.fecha.Month == 12) y++;
                            texto = y.ToString();
                            break;
                        case ("sueldo"):
                            texto = asociado.infoPersonal.ingresos.ToString("C");
                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }

            wordDoc.SaveAs2(@ubicacion + "Contraorden de descuento", Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
        }

        public static void contraorden(Asociado asociado, Ahorro ahorro)
        {
            crearCarpeta(asociado, ahorro.codigo);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Contraorden de descuento.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Word.Field campo in wordDoc.Fields)
            {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    campo.Select();
                    string texto = "";
                    #region Campos
                    switch (fieldName)
                    {
                        case ("fecha"):
                            texto = DateTime.Today.fechaLarga();
                            break;
                        case ("lugartrabajo"):
                            texto = asociado.trabajo.lugar.nombre;
                            break;
                        case ("asociado"):
                            texto = nomAsociado;
                            break;
                        case ("puestoTrabajo"):
                            texto = asociado.trabajo.cargo;
                            break;
                        case ("cuotaLetras"):
                            texto = Numalet.ToCardinal(ahorro.ahorroProgramado.cuota);
                            break;
                        case ("cuota"):
                            texto = ahorro.ahorroProgramado.cuota.ToString("C");
                            break;
                        case ("mes"):
                            texto = mes(ahorro.fecha.Month + 1);
                            break;
                        case ("anio"):
                            int y = ahorro.fecha.Year;
                            if (ahorro.fecha.Month == 12) y++;
                            texto = y.ToString();
                            break;
                        case ("sueldo"):
                            texto = asociado.infoPersonal.ingresos.ToString("C");
                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }

            wordDoc.SaveAs2(@ubicacion + "Contraorden de descuento", Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
        }

        public static void contratoAhorroProgramado(Asociado asociado, Ahorro ahorro)
        {
            crearCarpeta(asociado, ahorro.codigo);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Contrato ahorro programado.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            string duiLet;
            string[] dui = docLetras(asociado.dui.numero.ToString());

            duiLet = dui[0] + " - " + dui[1];

            foreach (Word.Field campo in wordDoc.Fields)
            {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    campo.Select();
                    string texto = "";
                    #region Campos
                    switch (fieldName)
                    {
                        case ("codigo"):
                            texto = ahorro.codigo;
                            break;
                        case ("fecha"):
                            texto = DateTime.Today.fechaLarga();
                            break;
                        case ("nombre"):
                            texto = asociado.nombre + " " + asociado.apellido;
                            break;
                        case ("edad"):
                            texto = Numalet.ToCardinal(asociado.nacimiento.edad).Replace(" con 00/100", "");
                            break;
                        case ("puestoTrabajo"):
                            texto = asociado.trabajo.cargo;
                            break;
                        case ("estadoCivil"):
                            texto = asociado.infoPersonal.estadoCivil;
                            break;
                        case ("municipio"):
                            texto = asociado.infoPersonal.municipio;
                            break;
                        case ("departamento"):
                            texto = asociado.infoPersonal.departamento;
                            break;
                        case ("dui"):
                            texto = duiLet;
                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }
            wordDoc.SaveAs2(@ubicacion + "Contrato", Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
        }

        public static void contratoAhorroCorriente(Asociado asociado, Ahorro ahorro)
        {
            crearCarpeta(asociado, ahorro.codigo);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Contrato ahorro corriente.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            string duiLet;
            string[] dui = docLetras(asociado.dui.numero.ToString());

            duiLet = dui[0] + " - " + dui[1];

            foreach (Word.Field campo in wordDoc.Fields)
            {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    campo.Select();
                    string texto = "";
                    #region Campos
                    switch (fieldName)
                    {
                        case ("codigo"):
                            texto = ahorro.codigo;
                            break;
                        case ("fecha"):
                            texto = DateTime.Today.fechaLarga();
                            break;
                        case ("nombre"):
                            texto = asociado.nombre + " " + asociado.apellido;
                            break;
                        case ("edad"):
                            texto = Numalet.ToCardinal(asociado.nacimiento.edad).Replace(" con 00/100", "");
                            break;
                        case ("puestoTrabajo"):
                            texto = asociado.trabajo.cargo;
                            break;
                        case ("estadoCivil"):
                            texto = asociado.infoPersonal.estadoCivil;
                            break;
                        case ("municipio"):
                            texto = asociado.infoPersonal.municipio;
                            break;
                        case ("departamento"):
                            texto = asociado.infoPersonal.departamento;
                            break;
                        case ("dui"):
                            texto = duiLet;
                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }

            wordDoc.SaveAs2(@ubicacion + "Contrato", Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
        }

        public static void certificado(Asociado asociado, Ahorro ahorro)
        {
            crearCarpeta(asociado, ahorro.codigo);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Certificado deposito plazo.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            string duiLet;
            string[] dui = docLetras(asociado.dui.numero.ToString());

            duiLet = dui[0] + " - " + dui[1];

            foreach (Word.Field campo in wordDoc.Fields)
            {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    campo.Select();
                    string texto = "";
                    #region Campos
                    switch (fieldName)
                    {
                        case ("numAsociado"):
                            texto = asociado.ToString();
                            break;
                        case ("fecha"):
                            texto = DateTime.Today.fechaLarga();
                            break;
                        case ("codAhorro"):
                            texto = ahorro.codigo;
                            break;
                        case ("asociado"):
                            texto = asociado.nombre + " " + asociado.apellido;
                            break;
                        case ("monto"):
                            texto = "$" + ahorro.ahorroPlazo.montoInicial;
                            break;
                        case ("plazo"):
                            texto = ahorro.ahorroPlazo.duracion.ToString();
                            break;
                        case ("interes"):
                            texto = ahorro.interes + "%";
                            break;
                        case ("vencimiento"):
                            texto = ahorro.fechaVencimiento.fechaLarga();
                            break;
                        case("codAhorroC"):
                            texto = ahorro.ahorroPlazo.codigoCuenta;
                            break;
                        case ("beneficiarios"):
                            texto = "";

                            foreach (Beneficiario beneficiary in ahorro.beneficiarios) {
                                texto += beneficiary.nombre + "\t\t" + beneficiary.parentesco + "\t\t" + beneficiary.edad + "\t\t" + beneficiary.porcentaje + "%\n";
                            }

                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }

            wordDoc.SaveAs2(@ubicacion + "Certificado", Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
        }

        public static void reciboPago(Asociado asociado, Credito credito, CreditoDetalle detalle) {
            crearCarpeta(asociado, credito.codigo);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Recibo de pago.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Word.Field campo in wordDoc.Fields)
            {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    campo.Select();
                    string texto = "";
                    #region Campos
                    switch (fieldName)
                    {
                        case("codigo"):
                            texto = credito.codigo;
                            break;
                        case ("fecha"):
                            texto = detalle.fecha.fechaLarga();
                            break;
                        case ("asociado"):
                            texto = asociado.nombre + " " + asociado.apellido;
                            break;
                        case("N"):
                            texto = detalle.correlativo.ToString();
                            break;
                        case("monto"):
                            texto = detalle.monto_pagado.ToString("C");
                            break;
                        case("aportacion"):
                            texto = detalle.aportacion.ToString("C");
                            break;
                        case("comision"):
                            texto = detalle.cuota_social.ToString("C");
                            break;
                        case("intereses"):
                            texto = detalle.interes.ToString("C");
                            break;
                        case("capital"):
                            texto = detalle.capital.ToString("C");
                            break;
                        case("saldo"):
                            texto = detalle.saldoParcial.ToString("C");
                            break;
                        default:
                            texto = "COMPLETAR CAMPO";
                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }

            wordDoc.SaveAs2(@ubicacion + "Recibo de pago "+ detalle.correlativo + " " + detalle.fecha.fechaLarga(), Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.PrintOut();
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);        
        }

        public static void comprobanteMovimiento(Asociado asociado, Ahorro ahorro, AhorroDetalle detalle)
        {
            crearCarpeta(asociado, ahorro.codigo);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Comprobante de movimiento.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Word.Field campo in wordDoc.Fields)
            {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    campo.Select();
                    string texto = "";
                    #region Campos

                    decimal deposito, retiro;
                    if (detalle.tipo == "Abono")
                    {
                        deposito = detalle.monto;
                        retiro = 0;
                    }
                    else
                    {
                        deposito = 0;
                        retiro = detalle.monto;
                    }

                    switch (fieldName)
                    {
                        case ("codigo"):
                            texto = ahorro.codigo;
                            break;
                        case ("fecha"):
                            texto = detalle.fecha.fechaLarga();
                            break;
                        case ("asociado"):
                            texto = asociado.nombre + " " + asociado.apellido;
                            break;    
                        case ("movimiento"):
                            texto = detalle.tipo.ToUpper();
                            break;
                        case ("deposito"):
                            texto = deposito.ToString("C2");
                            break;
                        case ("retiro"):
                            texto = retiro.ToString("C2");
                            break;
                        case ("saldo"):
                            texto = detalle.saldoParcial.ToString("C2");
                            break;
                        case("saldoA"):
                            texto = detalle.saldoAnterior.ToString("C2");
                            break;
                        default:
                            texto = "COMPLETAR CAMPO";
                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }

            wordDoc.SaveAs2(@ubicacion + "Comprobante de " + detalle.tipo + " " + detalle.correlativo + " " + detalle.fecha.fechaLarga(), Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.PrintOut();
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
        }

        public static void comprobanteAportacion(Asociado asociado, AportacionDetalle detalle)
        {
            crearCarpeta(asociado);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Comprobante de movimiento.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Word.Field campo in wordDoc.Fields)
            {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    campo.Select();
                    string texto = "";
                    #region Campos
                    switch (fieldName)
                    {
                        case ("codigo"):
                            texto = asociado.ToString();
                            break;
                        case ("fecha"):
                            texto = detalle.fecha.fechaLarga();
                            break;
                        case ("asociado"):
                            texto = asociado.nombre + " " + asociado.apellido;
                            break;
                        case ("movimiento"):
                            texto = "APORTACIÓN";
                            break;
                        case ("deposito"):
                            texto = detalle.monto.ToString("C2");
                            break;
                        case("retiro"):
                            texto = "$0.00";
                            break;
                        case ("saldo"):
                            texto = detalle.saldoParcial.ToString("C2");
                            break;
                        case ("saldoA"):
                            texto = detalle.saldoAnterior.ToString("C2");
                            break;
                        default:
                            texto = "COMPLETAR CAMPO";
                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }

            wordDoc.SaveAs2(@ubicacion + "Comprobante de aportación " + detalle.fecha.fechaLarga(), Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.PrintOut();
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
        }

        public static void comprobanteAportacion(Asociado asociado)
        {
            crearCarpeta(asociado);

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = @path + "\\0.Plantillas\\Comprobante de movimiento.dotx";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = new Word.Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Word.Field campo in wordDoc.Fields)
            {
                Word.Range rngFieldCode = campo.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLenght = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    campo.Select();
                    string texto = "";
                    #region Campos
                    switch (fieldName)
                    {
                        case ("codigo"):
                            texto = asociado.ToString();
                            break;
                        case ("fecha"):
                            texto = DateTime.Today.fechaLarga();
                            break;
                        case ("asociado"):
                            texto = asociado.nombre + " " + asociado.apellido;
                            break;
                        case ("movimiento"):
                            texto = "RETIRO DE APORTACIONES";
                            break;
                        case ("deposito"):
                            texto = "$0.00";
                            break;
                        case ("retiro"):
                            texto = asociado.aportacion.ToString("C2");
                            break;
                        case ("saldo"):
                            texto = "$0.00";
                            break;
                        case ("saldoA"):
                            texto = asociado.aportacion.ToString("C2");
                            break;
                        default:
                            texto = "COMPLETAR CAMPO";
                            break;
                    }
                    #endregion
                    wordApp.Selection.TypeText(texto);
                }
            }

            wordDoc.SaveAs2(@ubicacion + "Comprobante de retiro de aportaciones", Word.WdSaveFormat.wdFormatDocumentDefault);
            wordDoc.PrintOut();
            wordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
        }

        /*#########################################################################*
         *                          DOCUMENTOS .PDF                             *
         *#########################################################################*/
        public static void proyeccionPagos(Asociado asociado, Credito credito){
            crearCarpeta(asociado, credito.codigo);

            //Cargar el reporte
            
            ReportDocument rep = new ReportDocument();
            rep.Load( @path + "\\0.Plantillas\\CReport_Proyeccion.rpt");

            DS_Proyeccion ds = new DS_Proyeccion();

            //Agregar información
            DS_Proyeccion.informacionRow rowDatos = ds.informacion.NewinformacionRow();
            rowDatos.ASOCIADO = asociado.nombre + " " + asociado.apellido;
            rowDatos.CODIGO = credito.codigo;

            ds.informacion.AddinformacionRow(rowDatos);

            //Datos para la proyección

            //Variables auxiliares
            DateTime fechaInicio =  credito.fecha;
            decimal  saldo = credito.monto,
                    cuota = credito.cuota,
                    aportacion = credito.aportacion,
                    comision = 1.25M,
                    tasa = (decimal)credito.interes / 1200,
                    capital, intereses;
      
            int i=1;
            while (Math.Round((double)saldo, 2) > 0.0) {
                DS_Proyeccion.proyeccionRow dr = ds.proyeccion.NewproyeccionRow();

                dr.N = i;
                dr.CUOTA = cuota;

                if (i == 0){                   
                    intereses=0;
                    capital = 0;
                    dr.APORTACION = 0;
                    dr.COMISION = 0;                    
                }
                else {
                    fechaInicio = fechaInicio.AddMonths(1);
                    dr.APORTACION = aportacion;
                    dr.COMISION = comision;
                    intereses = saldo * tasa;                    
                    capital = cuota - intereses - aportacion - comision;
                    saldo = saldo - capital;
                }

                dr.FECHA = fechaInicio.ToShortDateString();
                dr.INT = Math.Round(intereses, 2);
                dr.CAPITAL = Math.Round(capital, 2);
                dr.SALDO = Math.Round(saldo, 2);

                ds.proyeccion.AddproyeccionRow(dr);
                i++;
            }
            //Agregar conjunto de datos al reporte
            rep.SetDataSource(ds);
            
            //Para exportar a pdf
            string nomArchivo = "Proyección de pagos";
            try
            {
                ExportOptions crEO;
                DiskFileDestinationOptions crDFDO = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFTO = new PdfRtfWordFormatOptions();
                crDFDO.DiskFileName = @ubicacion + nomArchivo + ".pdf";
                crEO = rep.ExportOptions;
                {
                    crEO.ExportDestinationType = ExportDestinationType.DiskFile;
                    crEO.ExportFormatType = ExportFormatType.PortableDocFormat;
                    crEO.ExportDestinationOptions = crDFDO;
                    crEO.ExportFormatOptions = crFTO;
                }
                rep.Export();

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = @ubicacion + nomArchivo + ".pdf";
                proc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public static void estadoCuenta(Asociado asociado, Credito credito){
            crearCarpeta(asociado, credito.codigo);

            //Cargar el reporte
            ReportDocument rep = new ReportDocument();
            rep.Load(@path + "\\0.Plantillas\\CReport_Estado.rpt");

            DSEstado ds = new DSEstado();

            //Agregar información
            DSEstado.informacionRow rowDatos = ds.informacion.NewinformacionRow();
            rowDatos.ASOCIADO = asociado.nombre + " " + asociado.apellido;
            rowDatos.CODIGO = credito.codigo;
            rowDatos.SALDO = credito.saldoActual.ToString("C");

            ds.informacion.AddinformacionRow(rowDatos);
            
            //Agregar elementos al Estado de Cuenta   
            foreach(CreditoDetalle detalle in credito.detallesPago){
                DSEstado.estadoRow rowEstado = ds.estado.NewestadoRow();

                rowEstado.N = detalle.correlativo.ToString();
                rowEstado.FECHA = detalle.fecha.ToShortDateString();
                rowEstado.CUOTA = detalle.monto_pagado.ToString();
                rowEstado.APORTACION = detalle.aportacion.ToString();
                rowEstado.COMISION = detalle.cuota_social.ToString();
                rowEstado.INT = detalle.interes.ToString();
                rowEstado.CAPITAL = detalle.capital.ToString();
                rowEstado.SALDO = detalle.saldoParcial.ToString();

                ds.estado.AddestadoRow(rowEstado);
            }
            
            //Agregar Conjunto de datos al reporte
            rep.SetDataSource(ds);

            //Para exportar a pdf
            string nomArchivo = "Estado de cuentas " +  DateTime.Today.Day.ToString() + "-" + mes(DateTime.Today.Month);
            try
            {
                ExportOptions crEO;
                DiskFileDestinationOptions crDFDO = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFTO = new PdfRtfWordFormatOptions();
                crDFDO.DiskFileName = @ubicacion + nomArchivo + ".pdf";
                crEO = rep.ExportOptions;
                {
                    crEO.ExportDestinationType = ExportDestinationType.DiskFile;
                    crEO.ExportFormatType = ExportFormatType.PortableDocFormat;
                    crEO.ExportDestinationOptions = crDFDO;
                    crEO.ExportFormatOptions = crFTO;
                }
                rep.Export();

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = @ubicacion + nomArchivo + ".pdf";
                proc.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void pagosDiariosCredito(DateTime fecha)
        {
            ubicacion = path + "Pagos de créditos diarios\\";
            if (!Directory.Exists(ubicacion))
                Directory.CreateDirectory(ubicacion);

            //Cargar el reporte
            ReportDocument rep = new ReportDocument();
            rep.Load(@path + "\\0.Plantillas\\CReport_PagosCreditoDiario.rpt");

            DS_PagosCreditosDiarios ds = new DS_PagosCreditosDiarios();
            

            DataTable detalles = CreditoServicio.obtenerDetalles(fecha);
            decimal montoT = 0, aportacionT = 0, cSocialT = 0, interesT = 0, capitalT = 0;
            foreach (DataRow detalle in detalles.Rows)
            {
                DS_PagosCreditosDiarios.PagoRow pagoRow = ds.Pago.NewPagoRow();

                decimal monto = detalle.Field<decimal>("monto_pagado");
                decimal aportacion = detalle.Field<decimal>("aportacion");
                decimal cSocial = detalle.Field<decimal>("cuota_social");
                decimal interes = detalle.Field<decimal>("interes");
                decimal capital = detalle.Field<decimal>("capital");

                pagoRow.Codigo = detalle.Field<string>("codigo");
                pagoRow.Cuota = monto.ToString();
                pagoRow.Aportacion = aportacion.ToString();
                pagoRow.CSocial = cSocial.ToString();
                pagoRow.Interes = interes.ToString();
                pagoRow.Capital = capital.ToString();

                ds.Pago.AddPagoRow(pagoRow);

                montoT += monto;
                aportacionT += aportacion;
                cSocialT += cSocial;
                interesT += interes;
                capitalT += capital;
            }

            //Agregar información
            DS_PagosCreditosDiarios.InformacionRow rowInfo = ds.Informacion.NewInformacionRow();
            rowInfo.Fecha = fecha.ToShortDateString();
            rowInfo.CuotaT = montoT.ToString("C");
            rowInfo.AportacionT = aportacionT.ToString("C");
            rowInfo.CSocialT = cSocialT.ToString("C");
            rowInfo.InteresT = interesT.ToString("C");
            rowInfo.CapitalT = capitalT.ToString("C");

            ds.Informacion.AddInformacionRow(rowInfo);

            //Agregar Conjunto de datos al reporte
            rep.SetDataSource(ds);

            //Para exportar a pdf
            string nomArchivo = fecha.Day.ToString() + "-" + mes(fecha.Month) + "-" + fecha.Year.ToString();
            try
            {
                ExportOptions crEO;
                DiskFileDestinationOptions crDFDO = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFTO = new PdfRtfWordFormatOptions();
                crDFDO.DiskFileName = @ubicacion + nomArchivo + ".pdf";
                crEO = rep.ExportOptions;
                {
                    crEO.ExportDestinationType = ExportDestinationType.DiskFile;
                    crEO.ExportFormatType = ExportFormatType.PortableDocFormat;
                    crEO.ExportDestinationOptions = crDFDO;
                    crEO.ExportFormatOptions = crFTO;
                }
                rep.Export();

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = @ubicacion + nomArchivo + ".pdf";
                proc.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*#####################      Documentos a letras      #####################*/
        public static string ceros(string texto)
        {
            string ceros = "";
            char[] cad = texto.ToCharArray();
            int l = cad.Length, i;
            if (char.Equals(cad[0], '0'))
            {
                char corte = ' ';
                for (i = 0; i < l; i++)
                {
                    if (!char.Equals(cad[i], '0'))
                    {
                        corte = cad[i];
                        String[] substring = texto.Split(corte);
                        for (int j = 0; j < substring[0].Length; j++)
                        {
                            ceros = ceros + "cero ";
                        }
                        break;
                    }
                }
            }
            return ceros;
        }

        public static string[] docLetras(string texto)
        {
            string[] cadena = texto.Split('-'),
                docText = new String[4];
            string d, m, y, a, b, c;

            int i = 0;
            foreach (string word in cadena)
            {
                if (i == 1 && word.Length > 1)
                {
                    a = word.Substring(0, 2);
                    b = word.Substring(2, 2);
                    c = word.Substring(4, 2);

                    d = ceros(a) + Numalet.ToCardinal(a);
                    m = ceros(b) + Numalet.ToCardinal(b);
                    y = ceros(c) + Numalet.ToCardinal(c);

                    d = d.Replace(" con 00/100", "");
                    m = m.Replace(" con 00/100", "");
                    y = y.Replace(" con 00/100", "");

                    docText[i] = d + " " + m + " " + y;
                }
                else
                {
                    docText[i] = ceros(word) + Numalet.ToCardinal(word);
                    docText[i] = docText[i].Replace(" con 00/100", "");
                }

                if ((i == 1 || i == 3) && docText[i].CompareTo("un") == 0)
                {
                    docText[i] = "uno";
                }

                i++;
            }

            return docText;
        }

        /*                                    Extra                               */
        public static string mes(int numMes) {
            string mes = "";

            while (numMes > 12) numMes -= 12;

            switch (numMes) { 
                case 1:
                    mes =  "Enero";
                    break;
                case 2:
                    mes =  "Febrero";
                    break;
                case 3:
                    mes =  "Marzo";
                    break;
                case 4:
                    mes =  "Abril";
                    break;
                case 5:
                    mes =  "Mayo";
                    break;
                case 6:
                    mes =  "Junio";
                    break;
                case 7:
                    mes =  "Julio";
                    break;
                case 8:
                    mes =  "Agosto";
                    break;
                case 9:
                    mes =  "Septiembre";
                    break;
                case 10:
                    mes =  "Octubre";
                    break;
                case 11:
                    mes =  "Noviembre";
                    break;
                case 12:
                    mes =  "Diciembre";
                    break;
            }

            return mes;
        }

        public static void abrirCarpeta()
        {
            System.Diagnostics.Process.Start(ubicacion);
        }
    }
}
