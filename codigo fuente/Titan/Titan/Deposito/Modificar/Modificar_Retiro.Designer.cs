namespace Titan.Deposito
{
    partial class Modificar_Retiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar_Retiro));
            this.panelModificarRetiro = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarRetiro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.divisionDeCurso = new System.Windows.Forms.NumericUpDown();
            this.añoDeCurso = new System.Windows.Forms.NumericUpDown();
            this.comboBoxAlumnos = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.txtFechayHora = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.comboBoxProfesor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumRetiro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelModificarRetiro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divisionDeCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.añoDeCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // panelModificarRetiro
            // 
            this.panelModificarRetiro.Controls.Add(this.label2);
            this.panelModificarRetiro.Controls.Add(this.btnBuscarRetiro);
            this.panelModificarRetiro.Controls.Add(this.groupBox1);
            this.panelModificarRetiro.Controls.Add(this.txtNumRetiro);
            this.panelModificarRetiro.Controls.Add(this.label11);
            this.panelModificarRetiro.Location = new System.Drawing.Point(2, 1);
            this.panelModificarRetiro.Name = "panelModificarRetiro";
            this.panelModificarRetiro.Size = new System.Drawing.Size(919, 489);
            this.panelModificarRetiro.TabIndex = 0;
            this.panelModificarRetiro.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Escriba el numero de retiro a modificar y llene los campos segun corresponda.";
            // 
            // btnBuscarRetiro
            // 
            this.btnBuscarRetiro.Location = new System.Drawing.Point(619, 71);
            this.btnBuscarRetiro.Name = "btnBuscarRetiro";
            this.btnBuscarRetiro.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarRetiro.TabIndex = 37;
            this.btnBuscarRetiro.Text = "Buscar";
            this.btnBuscarRetiro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnBuscarAlumno);
            this.groupBox1.Controls.Add(this.divisionDeCurso);
            this.groupBox1.Controls.Add(this.añoDeCurso);
            this.groupBox1.Controls.Add(this.comboBoxAlumnos);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.calendario);
            this.groupBox1.Controls.Add(this.txtFechayHora);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtUnidad);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.comboBoxProfesor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Retiro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(454, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(287, 313);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 47;
            this.btnModificar.Text = "Modicar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Location = new System.Drawing.Point(587, 73);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAlumno.TabIndex = 46;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            // 
            // divisionDeCurso
            // 
            this.divisionDeCurso.Location = new System.Drawing.Point(463, 73);
            this.divisionDeCurso.Name = "divisionDeCurso";
            this.divisionDeCurso.Size = new System.Drawing.Size(66, 20);
            this.divisionDeCurso.TabIndex = 45;
            // 
            // añoDeCurso
            // 
            this.añoDeCurso.Location = new System.Drawing.Point(321, 73);
            this.añoDeCurso.Name = "añoDeCurso";
            this.añoDeCurso.Size = new System.Drawing.Size(69, 20);
            this.añoDeCurso.TabIndex = 44;
            // 
            // comboBoxAlumnos
            // 
            this.comboBoxAlumnos.FormattingEnabled = true;
            this.comboBoxAlumnos.Location = new System.Drawing.Point(286, 111);
            this.comboBoxAlumnos.Name = "comboBoxAlumnos";
            this.comboBoxAlumnos.Size = new System.Drawing.Size(243, 21);
            this.comboBoxAlumnos.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Division:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Año:";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(587, 256);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(200, 20);
            this.calendario.TabIndex = 40;
            // 
            // txtFechayHora
            // 
            this.txtFechayHora.Location = new System.Drawing.Point(286, 256);
            this.txtFechayHora.Name = "txtFechayHora";
            this.txtFechayHora.Size = new System.Drawing.Size(242, 20);
            this.txtFechayHora.TabIndex = 39;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(286, 219);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(242, 20);
            this.txtCantidad.TabIndex = 38;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(286, 182);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(242, 20);
            this.txtUnidad.TabIndex = 37;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(286, 145);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(242, 20);
            this.txtProducto.TabIndex = 36;
            // 
            // comboBoxProfesor
            // 
            this.comboBoxProfesor.FormattingEnabled = true;
            this.comboBoxProfesor.Location = new System.Drawing.Point(286, 42);
            this.comboBoxProfesor.Name = "comboBoxProfesor";
            this.comboBoxProfesor.Size = new System.Drawing.Size(242, 21);
            this.comboBoxProfesor.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Profesor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Alumno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Unidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fecha y Hora:";
            // 
            // txtNumRetiro
            // 
            this.txtNumRetiro.Location = new System.Drawing.Point(319, 71);
            this.txtNumRetiro.Name = "txtNumRetiro";
            this.txtNumRetiro.Size = new System.Drawing.Size(242, 20);
            this.txtNumRetiro.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Retiro Numero:";
            // 
            // Modificar_Retiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 489);
            this.Controls.Add(this.panelModificarRetiro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modificar_Retiro";
            this.Text = "Modificar_Retiro";
            this.panelModificarRetiro.ResumeLayout(false);
            this.panelModificarRetiro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divisionDeCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.añoDeCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelModificarRetiro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumRetiro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscarRetiro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.NumericUpDown divisionDeCurso;
        private System.Windows.Forms.NumericUpDown añoDeCurso;
        private System.Windows.Forms.ComboBox comboBoxAlumnos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.TextBox txtFechayHora;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.ComboBox comboBoxProfesor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}