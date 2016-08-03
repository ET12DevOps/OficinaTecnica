namespace Titan.Deposito
{
    partial class Consultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar));
            this.panelConsultar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ListaDeAtrubutos = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboBoxTipoDeBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConsultar
            // 
            this.panelConsultar.Controls.Add(this.label4);
            this.panelConsultar.Controls.Add(this.label3);
            this.panelConsultar.Controls.Add(this.label2);
            this.panelConsultar.Controls.Add(this.btnSalir);
            this.panelConsultar.Controls.Add(this.ListaDeAtrubutos);
            this.panelConsultar.Controls.Add(this.btnBuscar);
            this.panelConsultar.Controls.Add(this.comboBoxTipoDeBusqueda);
            this.panelConsultar.Controls.Add(this.label1);
            this.panelConsultar.Location = new System.Drawing.Point(1, 1);
            this.panelConsultar.Name = "panelConsultar";
            this.panelConsultar.Size = new System.Drawing.Size(920, 522);
            this.panelConsultar.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Seleccione un atributo de la lista para ver la informacion detallada.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "La lista se llenara con atributos que existen de acuerdo con lo seleccionado arri" +
                "ba. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Seleccione los que desea buscar.";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(799, 82);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // ListaDeAtrubutos
            // 
            this.ListaDeAtrubutos.FormattingEnabled = true;
            this.ListaDeAtrubutos.Location = new System.Drawing.Point(49, 185);
            this.ListaDeAtrubutos.Name = "ListaDeAtrubutos";
            this.ListaDeAtrubutos.Size = new System.Drawing.Size(825, 290);
            this.ListaDeAtrubutos.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(433, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipoDeBusqueda
            // 
            this.comboBoxTipoDeBusqueda.FormattingEnabled = true;
            this.comboBoxTipoDeBusqueda.Items.AddRange(new object[] {
            "Alumnos",
            "Profesores",
            "Productos",
            "Proveedores"});
            this.comboBoxTipoDeBusqueda.Location = new System.Drawing.Point(155, 84);
            this.comboBoxTipoDeBusqueda.Name = "comboBoxTipoDeBusqueda";
            this.comboBoxTipoDeBusqueda.Size = new System.Drawing.Size(224, 21);
            this.comboBoxTipoDeBusqueda.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccionar:";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 521);
            this.Controls.Add(this.panelConsultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            this.panelConsultar.ResumeLayout(false);
            this.panelConsultar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox ListaDeAtrubutos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox comboBoxTipoDeBusqueda;
        private System.Windows.Forms.Label label1;

    }
}