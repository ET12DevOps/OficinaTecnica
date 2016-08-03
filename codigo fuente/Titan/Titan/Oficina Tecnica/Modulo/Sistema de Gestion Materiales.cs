using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Titan.Oficina_Tecnica.Modulo
{
    public partial class Sistema_de_Gestion_Materiales : Form
    {
        public Sistema_de_Gestion_Materiales()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
