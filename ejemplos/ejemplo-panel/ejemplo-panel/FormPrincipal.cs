using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_panel
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void item1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelFormPrincipal.Controls.Clear();
            FormSecundario frmSecundario = new FormSecundario();
            this.panelFormPrincipal.Controls.Add(frmSecundario.panelFormSecundario);
            this.panelFormPrincipal.Refresh();
        }
    }
}
