﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Familiar.Formularios
{
    public partial class FormEspera : Form
    {
        public FormEspera()
        {
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
        }

        
    }
}
