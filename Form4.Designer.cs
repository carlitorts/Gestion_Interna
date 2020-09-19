namespace Gestion_Interna
{
    partial class Form4
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
            this.B_Intervalo_Jud = new System.Windows.Forms.RadioButton();
            this.B_Un_Dia_Jud = new System.Windows.Forms.RadioButton();
            this.B_Sin_Fecha_Jud = new System.Windows.Forms.RadioButton();
            this.B_Buscar_Jud = new System.Windows.Forms.Button();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.L_Fecha_Fin = new System.Windows.Forms.Label();
            this.L_Fecha_Inicio = new System.Windows.Forms.Label();
            this.Fecha_Termino_Jud = new System.Windows.Forms.DateTimePicker();
            this.Fecha_Inicio_Jud = new System.Windows.Forms.DateTimePicker();
            this.Caratulado_Jud = new System.Windows.Forms.TextBox();
            this.Ruc_Jud = new System.Windows.Forms.TextBox();
            this.Rit_Jud = new System.Windows.Forms.TextBox();
            this.L_Fechas = new System.Windows.Forms.Label();
            this.L_Caratulado = new System.Windows.Forms.Label();
            this.L_Ruc_Jud = new System.Windows.Forms.Label();
            this.L_Rit_Jud = new System.Windows.Forms.Label();
            this.L_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Intervalo_Jud
            // 
            this.B_Intervalo_Jud.AutoSize = true;
            this.B_Intervalo_Jud.Location = new System.Drawing.Point(924, 86);
            this.B_Intervalo_Jud.Name = "B_Intervalo_Jud";
            this.B_Intervalo_Jud.Size = new System.Drawing.Size(66, 17);
            this.B_Intervalo_Jud.TabIndex = 50;
            this.B_Intervalo_Jud.TabStop = true;
            this.B_Intervalo_Jud.Text = "Intervalo";
            this.B_Intervalo_Jud.UseVisualStyleBackColor = true;
            this.B_Intervalo_Jud.CheckedChanged += new System.EventHandler(this.B_Intervalo_Jud_CheckedChanged);
            // 
            // B_Un_Dia_Jud
            // 
            this.B_Un_Dia_Jud.AutoSize = true;
            this.B_Un_Dia_Jud.Location = new System.Drawing.Point(924, 63);
            this.B_Un_Dia_Jud.Name = "B_Un_Dia_Jud";
            this.B_Un_Dia_Jud.Size = new System.Drawing.Size(92, 17);
            this.B_Un_Dia_Jud.TabIndex = 49;
            this.B_Un_Dia_Jud.TabStop = true;
            this.B_Un_Dia_Jud.Text = "Dia especifico";
            this.B_Un_Dia_Jud.UseVisualStyleBackColor = true;
            this.B_Un_Dia_Jud.CheckedChanged += new System.EventHandler(this.B_Un_Dia_Jud_CheckedChanged);
            // 
            // B_Sin_Fecha_Jud
            // 
            this.B_Sin_Fecha_Jud.AutoSize = true;
            this.B_Sin_Fecha_Jud.Location = new System.Drawing.Point(924, 40);
            this.B_Sin_Fecha_Jud.Name = "B_Sin_Fecha_Jud";
            this.B_Sin_Fecha_Jud.Size = new System.Drawing.Size(73, 17);
            this.B_Sin_Fecha_Jud.TabIndex = 48;
            this.B_Sin_Fecha_Jud.TabStop = true;
            this.B_Sin_Fecha_Jud.Text = "Sin Fecha";
            this.B_Sin_Fecha_Jud.UseVisualStyleBackColor = true;
            this.B_Sin_Fecha_Jud.CheckedChanged += new System.EventHandler(this.B_Sin_Fecha_Jud_CheckedChanged);
            // 
            // B_Buscar_Jud
            // 
            this.B_Buscar_Jud.Location = new System.Drawing.Point(12, 109);
            this.B_Buscar_Jud.Name = "B_Buscar_Jud";
            this.B_Buscar_Jud.Size = new System.Drawing.Size(1002, 23);
            this.B_Buscar_Jud.TabIndex = 47;
            this.B_Buscar_Jud.Text = "Buscar";
            this.B_Buscar_Jud.UseVisualStyleBackColor = true;
            this.B_Buscar_Jud.Click += new System.EventHandler(this.B_Buscar_Jud_Click);
            // 
            // Grilla
            // 
            this.Grilla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(12, 138);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(1010, 412);
            this.Grilla.TabIndex = 46;
            this.Grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellContentClick);
            // 
            // L_Fecha_Fin
            // 
            this.L_Fecha_Fin.AutoSize = true;
            this.L_Fecha_Fin.Location = new System.Drawing.Point(674, 83);
            this.L_Fecha_Fin.Name = "L_Fecha_Fin";
            this.L_Fecha_Fin.Size = new System.Drawing.Size(38, 13);
            this.L_Fecha_Fin.TabIndex = 45;
            this.L_Fecha_Fin.Text = "Hasta:";
            this.L_Fecha_Fin.Visible = false;
            // 
            // L_Fecha_Inicio
            // 
            this.L_Fecha_Inicio.AutoSize = true;
            this.L_Fecha_Inicio.Location = new System.Drawing.Point(671, 63);
            this.L_Fecha_Inicio.Name = "L_Fecha_Inicio";
            this.L_Fecha_Inicio.Size = new System.Drawing.Size(41, 13);
            this.L_Fecha_Inicio.TabIndex = 44;
            this.L_Fecha_Inicio.Text = "Desde:";
            this.L_Fecha_Inicio.Visible = false;
            // 
            // Fecha_Termino_Jud
            // 
            this.Fecha_Termino_Jud.Location = new System.Drawing.Point(718, 83);
            this.Fecha_Termino_Jud.Name = "Fecha_Termino_Jud";
            this.Fecha_Termino_Jud.Size = new System.Drawing.Size(200, 20);
            this.Fecha_Termino_Jud.TabIndex = 43;
            this.Fecha_Termino_Jud.Visible = false;
            // 
            // Fecha_Inicio_Jud
            // 
            this.Fecha_Inicio_Jud.Location = new System.Drawing.Point(718, 57);
            this.Fecha_Inicio_Jud.Name = "Fecha_Inicio_Jud";
            this.Fecha_Inicio_Jud.Size = new System.Drawing.Size(200, 20);
            this.Fecha_Inicio_Jud.TabIndex = 42;
            this.Fecha_Inicio_Jud.Visible = false;
            // 
            // Caratulado_Jud
            // 
            this.Caratulado_Jud.Location = new System.Drawing.Point(439, 59);
            this.Caratulado_Jud.Name = "Caratulado_Jud";
            this.Caratulado_Jud.Size = new System.Drawing.Size(120, 20);
            this.Caratulado_Jud.TabIndex = 41;
            // 
            // Ruc_Jud
            // 
            this.Ruc_Jud.Location = new System.Drawing.Point(206, 59);
            this.Ruc_Jud.Name = "Ruc_Jud";
            this.Ruc_Jud.Size = new System.Drawing.Size(120, 20);
            this.Ruc_Jud.TabIndex = 40;
            // 
            // Rit_Jud
            // 
            this.Rit_Jud.Location = new System.Drawing.Point(42, 59);
            this.Rit_Jud.Name = "Rit_Jud";
            this.Rit_Jud.Size = new System.Drawing.Size(120, 20);
            this.Rit_Jud.TabIndex = 39;
            // 
            // L_Fechas
            // 
            this.L_Fechas.AutoSize = true;
            this.L_Fechas.Location = new System.Drawing.Point(579, 62);
            this.L_Fechas.Name = "L_Fechas";
            this.L_Fechas.Size = new System.Drawing.Size(86, 13);
            this.L_Fechas.TabIndex = 38;
            this.L_Fechas.Text = "Entre las fechas:";
            // 
            // L_Caratulado
            // 
            this.L_Caratulado.AutoSize = true;
            this.L_Caratulado.Location = new System.Drawing.Point(332, 62);
            this.L_Caratulado.Name = "L_Caratulado";
            this.L_Caratulado.Size = new System.Drawing.Size(61, 13);
            this.L_Caratulado.TabIndex = 37;
            this.L_Caratulado.Text = "Caratulado:";
            // 
            // L_Ruc_Jud
            // 
            this.L_Ruc_Jud.AutoSize = true;
            this.L_Ruc_Jud.Location = new System.Drawing.Point(168, 62);
            this.L_Ruc_Jud.Name = "L_Ruc_Jud";
            this.L_Ruc_Jud.Size = new System.Drawing.Size(30, 13);
            this.L_Ruc_Jud.TabIndex = 36;
            this.L_Ruc_Jud.Text = "Ruc:";
            // 
            // L_Rit_Jud
            // 
            this.L_Rit_Jud.AutoSize = true;
            this.L_Rit_Jud.Location = new System.Drawing.Point(12, 62);
            this.L_Rit_Jud.Name = "L_Rit_Jud";
            this.L_Rit_Jud.Size = new System.Drawing.Size(23, 13);
            this.L_Rit_Jud.TabIndex = 35;
            this.L_Rit_Jud.Text = "Rit:";
            // 
            // L_Titulo
            // 
            this.L_Titulo.AutoSize = true;
            this.L_Titulo.Font = new System.Drawing.Font("Wide Latin", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Titulo.Location = new System.Drawing.Point(266, 9);
            this.L_Titulo.Name = "L_Titulo";
            this.L_Titulo.Size = new System.Drawing.Size(478, 33);
            this.L_Titulo.TabIndex = 34;
            this.L_Titulo.Text = "Buscar dcc Judicial";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.B_Intervalo_Jud);
            this.Controls.Add(this.B_Un_Dia_Jud);
            this.Controls.Add(this.B_Sin_Fecha_Jud);
            this.Controls.Add(this.B_Buscar_Jud);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.L_Fecha_Fin);
            this.Controls.Add(this.L_Fecha_Inicio);
            this.Controls.Add(this.Fecha_Termino_Jud);
            this.Controls.Add(this.Fecha_Inicio_Jud);
            this.Controls.Add(this.Caratulado_Jud);
            this.Controls.Add(this.Ruc_Jud);
            this.Controls.Add(this.Rit_Jud);
            this.Controls.Add(this.L_Fechas);
            this.Controls.Add(this.L_Caratulado);
            this.Controls.Add(this.L_Ruc_Jud);
            this.Controls.Add(this.L_Rit_Jud);
            this.Controls.Add(this.L_Titulo);
            this.MaximumSize = new System.Drawing.Size(1050, 600);
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "Form4";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton B_Intervalo_Jud;
        private System.Windows.Forms.RadioButton B_Un_Dia_Jud;
        private System.Windows.Forms.RadioButton B_Sin_Fecha_Jud;
        private System.Windows.Forms.Button B_Buscar_Jud;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Label L_Fecha_Fin;
        private System.Windows.Forms.Label L_Fecha_Inicio;
        private System.Windows.Forms.DateTimePicker Fecha_Termino_Jud;
        private System.Windows.Forms.DateTimePicker Fecha_Inicio_Jud;
        private System.Windows.Forms.TextBox Caratulado_Jud;
        private System.Windows.Forms.TextBox Ruc_Jud;
        private System.Windows.Forms.TextBox Rit_Jud;
        private System.Windows.Forms.Label L_Fechas;
        private System.Windows.Forms.Label L_Caratulado;
        private System.Windows.Forms.Label L_Ruc_Jud;
        private System.Windows.Forms.Label L_Rit_Jud;
        private System.Windows.Forms.Label L_Titulo;
    }
}