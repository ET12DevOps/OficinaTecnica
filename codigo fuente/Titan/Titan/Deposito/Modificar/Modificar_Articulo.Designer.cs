namespace Titan.Deposito
{
    partial class Modificar_Articulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar_Articulo));
            this.panelModificarArticulo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboBoxArticulos = new System.Windows.Forms.ComboBox();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodFisicoNuevo = new System.Windows.Forms.TextBox();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtProductoNuevo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodFisico = new System.Windows.Forms.TextBox();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelModificarArticulo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelModificarArticulo
            // 
            this.panelModificarArticulo.Controls.Add(this.groupBox1);
            this.panelModificarArticulo.Location = new System.Drawing.Point(1, 1);
            this.panelModificarArticulo.Name = "panelModificarArticulo";
            this.panelModificarArticulo.Size = new System.Drawing.Size(919, 519);
            this.panelModificarArticulo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.comboBoxArticulos);
            this.groupBox1.Controls.Add(this.txtFechaIngreso);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCodFisicoNuevo);
            this.groupBox1.Controls.Add(this.txtStockMinimo);
            this.groupBox1.Controls.Add(this.txtUnidad);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtProductoNuevo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.calendario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodFisico);
            this.groupBox1.Controls.Add(this.btnBuscarArticulo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Articulo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(598, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Escriba el nombre del producto y/o codigo fisico. Seleccione el articulo correspo" +
                "ndiente y luego llene los campos a modificar. ";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(176, 431);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 26);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(609, 431);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 26);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // comboBoxArticulos
            // 
            this.comboBoxArticulos.FormattingEnabled = true;
            this.comboBoxArticulos.Location = new System.Drawing.Point(327, 164);
            this.comboBoxArticulos.Name = "comboBoxArticulos";
            this.comboBoxArticulos.Size = new System.Drawing.Size(235, 21);
            this.comboBoxArticulos.TabIndex = 33;
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(327, 323);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(235, 20);
            this.txtFechaIngreso.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Fecha de Ingreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Codigo Fisico:";
            // 
            // txtCodFisicoNuevo
            // 
            this.txtCodFisicoNuevo.Location = new System.Drawing.Point(327, 203);
            this.txtCodFisicoNuevo.Name = "txtCodFisicoNuevo";
            this.txtCodFisicoNuevo.Size = new System.Drawing.Size(234, 20);
            this.txtCodFisicoNuevo.TabIndex = 29;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(328, 347);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(234, 20);
            this.txtStockMinimo.TabIndex = 28;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(327, 299);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(235, 20);
            this.txtUnidad.TabIndex = 27;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(328, 275);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(234, 20);
            this.txtCantidad.TabIndex = 26;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(328, 251);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(234, 20);
            this.txtDescripcion.TabIndex = 25;
            // 
            // txtProductoNuevo
            // 
            this.txtProductoNuevo.Location = new System.Drawing.Point(328, 227);
            this.txtProductoNuevo.Name = "txtProductoNuevo";
            this.txtProductoNuevo.Size = new System.Drawing.Size(234, 20);
            this.txtProductoNuevo.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Stock Minimo:";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(580, 323);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(201, 20);
            this.calendario.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Unidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Descripción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cantidad:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(327, 65);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(234, 20);
            this.txtProducto.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Producto:";
            // 
            // txtCodFisico
            // 
            this.txtCodFisico.Location = new System.Drawing.Point(327, 109);
            this.txtCodFisico.Name = "txtCodFisico";
            this.txtCodFisico.Size = new System.Drawing.Size(234, 20);
            this.txtCodFisico.TabIndex = 12;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(620, 83);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarArticulo.TabIndex = 11;
            this.btnBuscarArticulo.Text = "Buscar";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Codigo Fisico:";
            // 
            // Modificar_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 521);
            this.Controls.Add(this.panelModificarArticulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modificar_Articulo";
            this.Text = "Modificar_Articulo";
            this.panelModificarArticulo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelModificarArticulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodFisico;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxArticulos;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodFisicoNuevo;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtProductoNuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label10;
    }
}