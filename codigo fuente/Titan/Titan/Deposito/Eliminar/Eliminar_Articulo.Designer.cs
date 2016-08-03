namespace Titan.Deposito
{
    partial class Eliminar_Articulo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar_Articulo));
            this.panelEliminarArticulo = new System.Windows.Forms.Panel();
            this.groupBoxEliminarArticulo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCodFisico = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelEliminarArticulo.SuspendLayout();
            this.groupBoxEliminarArticulo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEliminarArticulo
            // 
            this.panelEliminarArticulo.Controls.Add(this.groupBoxEliminarArticulo);
            this.panelEliminarArticulo.Controls.Add(this.statusStrip1);
            this.panelEliminarArticulo.Location = new System.Drawing.Point(2, 1);
            this.panelEliminarArticulo.Name = "panelEliminarArticulo";
            this.panelEliminarArticulo.Size = new System.Drawing.Size(918, 517);
            this.panelEliminarArticulo.TabIndex = 0;
            // 
            // groupBoxEliminarArticulo
            // 
            this.groupBoxEliminarArticulo.Controls.Add(this.label3);
            this.groupBoxEliminarArticulo.Controls.Add(this.txtProducto);
            this.groupBoxEliminarArticulo.Controls.Add(this.label1);
            this.groupBoxEliminarArticulo.Controls.Add(this.btnCancelar);
            this.groupBoxEliminarArticulo.Controls.Add(this.btnEliminar);
            this.groupBoxEliminarArticulo.Controls.Add(this.txtCodFisico);
            this.groupBoxEliminarArticulo.Controls.Add(this.btnBuscar);
            this.groupBoxEliminarArticulo.Controls.Add(this.listBoxResultado);
            this.groupBoxEliminarArticulo.Controls.Add(this.label2);
            this.groupBoxEliminarArticulo.Location = new System.Drawing.Point(31, 18);
            this.groupBoxEliminarArticulo.Name = "groupBoxEliminarArticulo";
            this.groupBoxEliminarArticulo.Size = new System.Drawing.Size(855, 455);
            this.groupBoxEliminarArticulo.TabIndex = 1;
            this.groupBoxEliminarArticulo.TabStop = false;
            this.groupBoxEliminarArticulo.Text = "Eliminar Articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(519, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Escriba el nombre y/o codigo fisico del articulo a eliminar. Despues seleccione e" +
                "n la lista según corresponda.";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(300, 92);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(234, 20);
            this.txtProducto.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Producto:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(593, 402);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(190, 402);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtCodFisico
            // 
            this.txtCodFisico.Location = new System.Drawing.Point(300, 136);
            this.txtCodFisico.Name = "txtCodFisico";
            this.txtCodFisico.Size = new System.Drawing.Size(234, 20);
            this.txtCodFisico.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(593, 110);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(190, 192);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(478, 173);
            this.listBoxResultado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Fisico:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(122, 17);
            this.toolStripStatusLabel1.Text = "Estoy haciendo algo...";
            // 
            // Eliminar_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 520);
            this.Controls.Add(this.panelEliminarArticulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Eliminar_Articulo";
            this.Text = "Eliminar_Articulo";
            this.panelEliminarArticulo.ResumeLayout(false);
            this.panelEliminarArticulo.PerformLayout();
            this.groupBoxEliminarArticulo.ResumeLayout(false);
            this.groupBoxEliminarArticulo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEliminarArticulo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBoxEliminarArticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodFisico;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}