namespace Sistema_de_Gestion_de_Materiales.frmMaterial
{
    partial class Buscar_Material
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
            this.pnlBuscarMaterial = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEscanear = new System.Windows.Forms.Button();
            this.txtDescripCorta = new System.Windows.Forms.TextBox();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.txtCodInterno = new System.Windows.Forms.TextBox();
            this.lblDescripcionCorta = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.lblCodigoInterno = new System.Windows.Forms.Label();
            this.dataGridResultadoBusqueda = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlBuscarMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultadoBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBuscarMaterial
            // 
            this.pnlBuscarMaterial.Controls.Add(this.btnLimpiar);
            this.pnlBuscarMaterial.Controls.Add(this.btnBuscar);
            this.pnlBuscarMaterial.Controls.Add(this.dataGridResultadoBusqueda);
            this.pnlBuscarMaterial.Controls.Add(this.btnCancelar);
            this.pnlBuscarMaterial.Controls.Add(this.btnEscanear);
            this.pnlBuscarMaterial.Controls.Add(this.txtDescripCorta);
            this.pnlBuscarMaterial.Controls.Add(this.txtCodBarra);
            this.pnlBuscarMaterial.Controls.Add(this.txtCodInterno);
            this.pnlBuscarMaterial.Controls.Add(this.lblDescripcionCorta);
            this.pnlBuscarMaterial.Controls.Add(this.lblCodigoBarras);
            this.pnlBuscarMaterial.Controls.Add(this.lblCodigoInterno);
            this.pnlBuscarMaterial.Location = new System.Drawing.Point(12, 27);
            this.pnlBuscarMaterial.Name = "pnlBuscarMaterial";
            this.pnlBuscarMaterial.Size = new System.Drawing.Size(1240, 642);
            this.pnlBuscarMaterial.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(773, 572);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEscanear
            // 
            this.btnEscanear.Location = new System.Drawing.Point(824, 114);
            this.btnEscanear.Name = "btnEscanear";
            this.btnEscanear.Size = new System.Drawing.Size(98, 23);
            this.btnEscanear.TabIndex = 10;
            this.btnEscanear.Text = "Escanear";
            this.btnEscanear.UseVisualStyleBackColor = true;
            // 
            // txtDescripCorta
            // 
            this.txtDescripCorta.Location = new System.Drawing.Point(436, 159);
            this.txtDescripCorta.Name = "txtDescripCorta";
            this.txtDescripCorta.Size = new System.Drawing.Size(486, 20);
            this.txtDescripCorta.TabIndex = 7;
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Location = new System.Drawing.Point(436, 116);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(298, 20);
            this.txtCodBarra.TabIndex = 6;
            // 
            // txtCodInterno
            // 
            this.txtCodInterno.Location = new System.Drawing.Point(436, 78);
            this.txtCodInterno.Name = "txtCodInterno";
            this.txtCodInterno.Size = new System.Drawing.Size(140, 20);
            this.txtCodInterno.TabIndex = 5;
            // 
            // lblDescripcionCorta
            // 
            this.lblDescripcionCorta.AutoSize = true;
            this.lblDescripcionCorta.Location = new System.Drawing.Point(285, 162);
            this.lblDescripcionCorta.Name = "lblDescripcionCorta";
            this.lblDescripcionCorta.Size = new System.Drawing.Size(94, 13);
            this.lblDescripcionCorta.TabIndex = 3;
            this.lblDescripcionCorta.Text = "Descripción Corta:";
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(285, 119);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(86, 13);
            this.lblCodigoBarras.TabIndex = 1;
            this.lblCodigoBarras.Text = "Código de Barra:";
            // 
            // lblCodigoInterno
            // 
            this.lblCodigoInterno.AutoSize = true;
            this.lblCodigoInterno.Location = new System.Drawing.Point(285, 78);
            this.lblCodigoInterno.Name = "lblCodigoInterno";
            this.lblCodigoInterno.Size = new System.Drawing.Size(79, 13);
            this.lblCodigoInterno.TabIndex = 0;
            this.lblCodigoInterno.Text = "Código Interno:";
            // 
            // dataGridResultadoBusqueda
            // 
            this.dataGridResultadoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResultadoBusqueda.Location = new System.Drawing.Point(215, 287);
            this.dataGridResultadoBusqueda.Name = "dataGridResultadoBusqueda";
            this.dataGridResultadoBusqueda.Size = new System.Drawing.Size(797, 235);
            this.dataGridResultadoBusqueda.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(576, 206);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(427, 572);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Buscar_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlBuscarMaterial);
            this.Name = "Buscar_Material";
            this.Text = "Buscar Material";
            this.Load += new System.EventHandler(this.Buscar_Material_Load);
            this.pnlBuscarMaterial.ResumeLayout(false);
            this.pnlBuscarMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultadoBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBuscarMaterial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEscanear;
        private System.Windows.Forms.TextBox txtDescripCorta;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.TextBox txtCodInterno;
        private System.Windows.Forms.Label lblDescripcionCorta;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.Label lblCodigoInterno;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridResultadoBusqueda;
        private System.Windows.Forms.Button btnLimpiar;
    }
}