namespace Titan.Oficina_Tecnica
{
    partial class Eliminar_Alumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar_Alumno));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListaDeAlumnos = new System.Windows.Forms.ListBox();
            this.btnBuscarCurso = new System.Windows.Forms.Button();
            this.txtCicloLectivo = new System.Windows.Forms.TextBox();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 518);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Complete los campos correspondientes para buscar los alumnos y selecione el que c" +
                "orresponda.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListaDeAlumnos);
            this.groupBox1.Controls.Add(this.btnBuscarCurso);
            this.groupBox1.Controls.Add(this.txtCicloLectivo);
            this.groupBox1.Controls.Add(this.txtDivision);
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Location = new System.Drawing.Point(99, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 383);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Alumno";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ListaDeAlumnos
            // 
            this.ListaDeAlumnos.FormattingEnabled = true;
            this.ListaDeAlumnos.Location = new System.Drawing.Point(188, 179);
            this.ListaDeAlumnos.Name = "ListaDeAlumnos";
            this.ListaDeAlumnos.Size = new System.Drawing.Size(315, 134);
            this.ListaDeAlumnos.TabIndex = 30;
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.Location = new System.Drawing.Point(428, 125);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarCurso.TabIndex = 29;
            this.btnBuscarCurso.Text = "Buscar";
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            // 
            // txtCicloLectivo
            // 
            this.txtCicloLectivo.Location = new System.Drawing.Point(313, 125);
            this.txtCicloLectivo.Name = "txtCicloLectivo";
            this.txtCicloLectivo.Size = new System.Drawing.Size(66, 20);
            this.txtCicloLectivo.TabIndex = 28;
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(313, 96);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(66, 20);
            this.txtDivision.TabIndex = 27;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(313, 62);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(66, 20);
            this.txtAño.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Curso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "División:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ciclo Lectivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Año:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(428, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(188, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Eliminar_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 520);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Eliminar_Alumno";
            this.Text = "Eliminar_Alumno";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox ListaDeAlumnos;
        private System.Windows.Forms.Button btnBuscarCurso;
        private System.Windows.Forms.TextBox txtCicloLectivo;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}