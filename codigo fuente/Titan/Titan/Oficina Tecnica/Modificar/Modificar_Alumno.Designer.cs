namespace Titan.Oficina_Tecnica.Modificar
{
    partial class Modificar_Alumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar_Alumno));
            this.panelModificarAlumno = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAñoNuevo = new System.Windows.Forms.TextBox();
            this.txtDivisionNueva = new System.Windows.Forms.TextBox();
            this.txtCicloLectivoNuevo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaDeAlumnos = new System.Windows.Forms.ListBox();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.txtCicloLectivo = new System.Windows.Forms.TextBox();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelModificarAlumno.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelModificarAlumno
            // 
            this.panelModificarAlumno.Controls.Add(this.groupBox1);
            this.panelModificarAlumno.Location = new System.Drawing.Point(1, 1);
            this.panelModificarAlumno.Name = "panelModificarAlumno";
            this.panelModificarAlumno.Size = new System.Drawing.Size(919, 518);
            this.panelModificarAlumno.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtAñoNuevo);
            this.groupBox1.Controls.Add(this.txtDivisionNueva);
            this.groupBox1.Controls.Add(this.txtCicloLectivoNuevo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ListaDeAlumnos);
            this.groupBox1.Controls.Add(this.btnBuscarAlumno);
            this.groupBox1.Controls.Add(this.txtCicloLectivo);
            this.groupBox1.Controls.Add(this.txtDivision);
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Location = new System.Drawing.Point(62, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 440);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Alumno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(370, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Una vez seleccionado el alumno en la lista, complete los campos a modificar.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(469, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Complete los datos del curso del alumno para buscar lo. Seleccione en la lista se" +
                "gun corresponda.";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(168, 252);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(208, 20);
            this.txtApellido.TabIndex = 40;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(168, 276);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 20);
            this.txtNombre.TabIndex = 39;
            // 
            // txtAñoNuevo
            // 
            this.txtAñoNuevo.Location = new System.Drawing.Point(168, 300);
            this.txtAñoNuevo.Name = "txtAñoNuevo";
            this.txtAñoNuevo.Size = new System.Drawing.Size(208, 20);
            this.txtAñoNuevo.TabIndex = 38;
            this.txtAñoNuevo.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtDivisionNueva
            // 
            this.txtDivisionNueva.Location = new System.Drawing.Point(168, 324);
            this.txtDivisionNueva.Name = "txtDivisionNueva";
            this.txtDivisionNueva.Size = new System.Drawing.Size(208, 20);
            this.txtDivisionNueva.TabIndex = 37;
            // 
            // txtCicloLectivoNuevo
            // 
            this.txtCicloLectivoNuevo.Location = new System.Drawing.Point(168, 348);
            this.txtCicloLectivoNuevo.Name = "txtCicloLectivoNuevo";
            this.txtCicloLectivoNuevo.Size = new System.Drawing.Size(208, 20);
            this.txtCicloLectivoNuevo.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ciclo Lectivo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Año:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "División:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre:";
            // 
            // ListaDeAlumnos
            // 
            this.ListaDeAlumnos.FormattingEnabled = true;
            this.ListaDeAlumnos.Location = new System.Drawing.Point(440, 78);
            this.ListaDeAlumnos.Name = "ListaDeAlumnos";
            this.ListaDeAlumnos.Size = new System.Drawing.Size(293, 290);
            this.ListaDeAlumnos.TabIndex = 30;
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Location = new System.Drawing.Point(301, 168);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarAlumno.TabIndex = 29;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCicloLectivo
            // 
            this.txtCicloLectivo.Location = new System.Drawing.Point(186, 168);
            this.txtCicloLectivo.Name = "txtCicloLectivo";
            this.txtCicloLectivo.Size = new System.Drawing.Size(66, 20);
            this.txtCicloLectivo.TabIndex = 28;
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(186, 136);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(66, 20);
            this.txtDivision.TabIndex = 27;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(186, 104);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(66, 20);
            this.txtAño.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Curso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "División:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ciclo Lectivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Año:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(490, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(186, 396);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // Modificar_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 520);
            this.Controls.Add(this.panelModificarAlumno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modificar_Alumno";
            this.Text = "Modificar_Alumno";
            this.panelModificarAlumno.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelModificarAlumno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListaDeAlumnos;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.TextBox txtCicloLectivo;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAñoNuevo;
        private System.Windows.Forms.TextBox txtDivisionNueva;
        private System.Windows.Forms.TextBox txtCicloLectivoNuevo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}