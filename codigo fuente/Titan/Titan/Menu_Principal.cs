using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Titan.Deposito;

namespace Titan
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ingresarNuevoArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Articulo frmNuevoArticulo = new Nuevo_Articulo();
            frmNuevoArticulo.Show();
        }

        private void retiroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Nuevo_Retiro frmNuevoRetiro = new Nuevo_Retiro();
            frmNuevoRetiro.Show();
        }

        private void articuloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Eliminar_Articulo frmEliminarArticulo = new Eliminar_Articulo();
            frmEliminarArticulo.Show();
        }

        private void articuloToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Modificar_Articulo frmModificarArticulo = new Modificar_Articulo();
            frmModificarArticulo.Show();
        }

        private void retiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Retiro frmModificarRetiro = new Modificar_Retiro();
            frmModificarRetiro.Show();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultar frmConsultar = new Consultar();
            frmConsultar.Show();
        }
    }
}
