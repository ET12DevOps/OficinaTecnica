using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Gestion_de_Materiales.Material
{
    public partial class Nuevo_Material : Form
    {
        public Nuevo_Material()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodBarra.Clear();
            txtCodInterno.Clear();
            txtDescripCorta.Clear();
            txtDescripLarga.Clear();
            txtUnidad.Clear();

            MessageBox.Show("Se borraron todos los campos.");
        }

        private void PanelSisGestMateriales_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
