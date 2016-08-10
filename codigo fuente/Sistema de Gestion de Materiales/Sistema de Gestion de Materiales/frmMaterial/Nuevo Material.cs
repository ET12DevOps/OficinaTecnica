using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sistema_de_Gestion_de_Materiales.Dominio;

namespace Sistema_de_Gestion_de_Materiales.frmMaterial
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //verificar si estan vacios
            //verificar tipo de datos
            //verificar existencia de ID

            //realizo el insert
            try
            {
                Material.ConnectionString("win2012-01", "3306", "pp67_materiales", "root", "Lujho12");
                Material.Insert(new Material(this.txtCodInterno.Text, txtCodBarra.Text, txtDescripLarga.Text, txtDescripCorta.Text, txtUnidad.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en el ingreso del material");
                return;
            }
            MessageBox.Show("El material fue guardado exitosamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
