using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sistema_de_Gestion_de_Materiales.Material;

namespace Sistema_de_Gestion_de_Materiales
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Material frmNuevo_Material = new Nuevo_Material();
            frmNuevo_Material.Show();
        }
    }
}
