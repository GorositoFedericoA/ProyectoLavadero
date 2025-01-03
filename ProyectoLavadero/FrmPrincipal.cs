﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLavadero
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemCargarCliente_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1)) 
                    return;
            }


            form1.MdiParent = this;

            form1.Show();


        }

        private void ToolStripMenuItemFinalizados_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form2))
                    return;
            }

            form2.MdiParent = this;

            form2.Show();
        }
    }
}
