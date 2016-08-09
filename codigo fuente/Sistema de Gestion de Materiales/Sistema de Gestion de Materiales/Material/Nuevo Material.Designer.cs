namespace Sistema_de_Gestion_de_Materiales.Material
{
    partial class Nuevo_Material
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
            this.pnlNuevoMaterial = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEscanear = new System.Windows.Forms.Button();
            this.txtDescripLarga = new System.Windows.Forms.RichTextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtDescripCorta = new System.Windows.Forms.TextBox();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.txtCodInterno = new System.Windows.Forms.TextBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblDescripcionCorta = new System.Windows.Forms.Label();
            this.lblDescripcionLarga = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.lblCodigoInterno = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlNuevoMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNuevoMaterial
            // 
            this.pnlNuevoMaterial.Controls.Add(this.comboBox1);
            this.pnlNuevoMaterial.Controls.Add(this.btnLimpiar);
            this.pnlNuevoMaterial.Controls.Add(this.btnCancelar);
            this.pnlNuevoMaterial.Controls.Add(this.btnAceptar);
            this.pnlNuevoMaterial.Controls.Add(this.btnEscanear);
            this.pnlNuevoMaterial.Controls.Add(this.txtDescripLarga);
            this.pnlNuevoMaterial.Controls.Add(this.txtUnidad);
            this.pnlNuevoMaterial.Controls.Add(this.txtDescripCorta);
            this.pnlNuevoMaterial.Controls.Add(this.txtCodBarra);
            this.pnlNuevoMaterial.Controls.Add(this.txtCodInterno);
            this.pnlNuevoMaterial.Controls.Add(this.lblUnidad);
            this.pnlNuevoMaterial.Controls.Add(this.lblDescripcionCorta);
            this.pnlNuevoMaterial.Controls.Add(this.lblDescripcionLarga);
            this.pnlNuevoMaterial.Controls.Add(this.lblCodigoBarras);
            this.pnlNuevoMaterial.Controls.Add(this.lblCodigoInterno);
            this.pnlNuevoMaterial.Location = new System.Drawing.Point(12, 27);
            this.pnlNuevoMaterial.Name = "pnlNuevoMaterial";
            this.pnlNuevoMaterial.Size = new System.Drawing.Size(1240, 642);
            this.pnlNuevoMaterial.TabIndex = 3;
            this.pnlNuevoMaterial.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSisGestMateriales_Paint);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(952, 455);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Borrar todo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(688, 547);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(425, 547);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnEscanear
            // 
            this.btnEscanear.Location = new System.Drawing.Point(765, 164);
            this.btnEscanear.Name = "btnEscanear";
            this.btnEscanear.Size = new System.Drawing.Size(98, 23);
            this.btnEscanear.TabIndex = 10;
            this.btnEscanear.Text = "Escanear";
            this.btnEscanear.UseVisualStyleBackColor = true;
            // 
            // txtDescripLarga
            // 
            this.txtDescripLarga.Location = new System.Drawing.Point(346, 236);
            this.txtDescripLarga.Name = "txtDescripLarga";
            this.txtDescripLarga.Size = new System.Drawing.Size(517, 113);
            this.txtDescripLarga.TabIndex = 9;
            this.txtDescripLarga.Text = "";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(346, 457);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(110, 20);
            this.txtUnidad.TabIndex = 8;
            // 
            // txtDescripCorta
            // 
            this.txtDescripCorta.Location = new System.Drawing.Point(346, 394);
            this.txtDescripCorta.Name = "txtDescripCorta";
            this.txtDescripCorta.Size = new System.Drawing.Size(517, 20);
            this.txtDescripCorta.TabIndex = 7;
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Location = new System.Drawing.Point(346, 166);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(298, 20);
            this.txtCodBarra.TabIndex = 6;
            // 
            // txtCodInterno
            // 
            this.txtCodInterno.Location = new System.Drawing.Point(346, 128);
            this.txtCodInterno.Name = "txtCodInterno";
            this.txtCodInterno.Size = new System.Drawing.Size(140, 20);
            this.txtCodInterno.TabIndex = 5;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(195, 460);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(44, 13);
            this.lblUnidad.TabIndex = 4;
            this.lblUnidad.Text = "Unidad:";
            // 
            // lblDescripcionCorta
            // 
            this.lblDescripcionCorta.AutoSize = true;
            this.lblDescripcionCorta.Location = new System.Drawing.Point(195, 397);
            this.lblDescripcionCorta.Name = "lblDescripcionCorta";
            this.lblDescripcionCorta.Size = new System.Drawing.Size(94, 13);
            this.lblDescripcionCorta.TabIndex = 3;
            this.lblDescripcionCorta.Text = "Descripción Corta:";
            // 
            // lblDescripcionLarga
            // 
            this.lblDescripcionLarga.AutoSize = true;
            this.lblDescripcionLarga.Location = new System.Drawing.Point(195, 239);
            this.lblDescripcionLarga.Name = "lblDescripcionLarga";
            this.lblDescripcionLarga.Size = new System.Drawing.Size(96, 13);
            this.lblDescripcionLarga.TabIndex = 2;
            this.lblDescripcionLarga.Text = "Descripción Larga:";
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(195, 169);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(86, 13);
            this.lblCodigoBarras.TabIndex = 1;
            this.lblCodigoBarras.Text = "Código de Barra:";
            // 
            // lblCodigoInterno
            // 
            this.lblCodigoInterno.AutoSize = true;
            this.lblCodigoInterno.Location = new System.Drawing.Point(195, 128);
            this.lblCodigoInterno.Name = "lblCodigoInterno";
            this.lblCodigoInterno.Size = new System.Drawing.Size(79, 13);
            this.lblCodigoInterno.TabIndex = 0;
            this.lblCodigoInterno.Text = "Código Interno:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(473, 457);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // Nuevo_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlNuevoMaterial);
            this.Name = "Nuevo_Material";
            this.Text = "Nuevo Material";
            this.pnlNuevoMaterial.ResumeLayout(false);
            this.pnlNuevoMaterial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNuevoMaterial;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnEscanear;
        private System.Windows.Forms.RichTextBox txtDescripLarga;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtDescripCorta;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.TextBox txtCodInterno;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblDescripcionCorta;
        private System.Windows.Forms.Label lblDescripcionLarga;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.Label lblCodigoInterno;
    }
}