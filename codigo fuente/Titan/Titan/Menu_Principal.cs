using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Titan.Deposito;
using Titan.Oficina_Tecnica;
using Titan.Oficina_Tecnica.Modificar;
using Titan.Oficina_Tecnica.Modulo;

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
            this.panelMenuPrincipal.Controls.Clear();
            Nuevo_Articulo frmNuevoArticulo = new Nuevo_Articulo();
            //frmNuevoArticulo.Show();
            this.panelMenuPrincipal.Controls.Add(frmNuevoArticulo.panelNuevoArticulo);
            this.Refresh();

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

        private void profesorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Nuevo_Alumno frmNuevoAlumno = new Nuevo_Alumno();
            frmNuevoAlumno.Show();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente...");
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Profesor frmNuevoProfesor = new Nuevo_Profesor();
            frmNuevoProfesor.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Proveedor frmNuevoProveedor = new Nuevo_Proveedor();
            frmNuevoProveedor.Show();
        }

        private void alumnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Eliminar_Alumno frmNuevoAlumno = new Eliminar_Alumno();
            frmNuevoAlumno.Show();
        }

        private void personalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente...");
        }

        private void profesorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Eliminar_Profesor frmEliminarProfesor = new Eliminar_Profesor();
            frmEliminarProfesor.Show();
        }

        private void proveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Eliminar_Proveedor frmEliminarProveedor = new Eliminar_Proveedor();
            frmEliminarProveedor.Show();
        }

        private void alumnoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Modificar_Alumno frmModificarAlumno = new Modificar_Alumno();
            frmModificarAlumno.Show();
        }

        private void personalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximente...");
        }

        private void profesorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Modificar_Profesor frmModificarProfesor = new Modificar_Profesor();
            frmModificarProfesor.Show();
        }

        private void proveedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Modificar_Proveedor frmModificarProveedor = new Modificar_Proveedor();
            frmModificarProveedor.Show();
        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximente...");
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximente...");
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente...");
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sistemaDeGestionDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema_de_Gestion_Materiales frmSistemaGestionMateriales = new Sistema_de_Gestion_Materiales();
            frmSistemaGestionMateriales.Show();
        }
    }
}
