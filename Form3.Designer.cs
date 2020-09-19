namespace Gestion_Interna
{
    partial class Form3
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
            this.B_Intervalo_Cartas = new System.Windows.Forms.RadioButton();
            this.B_Un_Dia_Cartas = new System.Windows.Forms.RadioButton();
            this.B_Sin_Fecha_Cartas = new System.Windows.Forms.RadioButton();
            this.B_Buscar_Carta = new System.Windows.Forms.Button();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.L_Fecha_Fin = new System.Windows.Forms.Label();
            this.L_Fecha_Inicio = new System.Windows.Forms.Label();
            this.Fecha_Termino_Cartas = new System.Windows.Forms.DateTimePicker();
            this.Fecha_Inicio_Cartas = new System.Windows.Forms.DateTimePicker();
            this.Comentario_Cartas = new System.Windows.Forms.TextBox();
            this.Para_Cartas = new System.Windows.Forms.TextBox();
            this.De_Cartas = new System.Windows.Forms.TextBox();
            this.L_Fechas = new System.Windows.Forms.Label();
            this.L_Comentario = new System.Windows.Forms.Label();
            this.L_Para_Carta = new System.Windows.Forms.Label();
            this.L_De_Cartas = new System.Windows.Forms.Label();
            this.L_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Intervalo_Cartas
            // 
            this.B_Intervalo_Cartas.AutoSize = true;
            this.B_Intervalo_Cartas.Location = new System.Drawing.Point(924, 84);
            this.B_Intervalo_Cartas.Name = "B_Intervalo_Cartas";
            this.B_Intervalo_Cartas.Size = new System.Drawing.Size(66, 17);
            this.B_Intervalo_Cartas.TabIndex = 33;
            this.B_Intervalo_Cartas.TabStop = true;
            this.B_Intervalo_Cartas.Text = "Intervalo";
            this.B_Intervalo_Cartas.UseVisualStyleBackColor = true;
            this.B_Intervalo_Cartas.CheckedChanged += new System.EventHandler(this.B_Intervalo_Cartas_CheckedChanged);
            // 
            // B_Un_Dia_Cartas
            // 
            this.B_Un_Dia_Cartas.AutoSize = true;
            this.B_Un_Dia_Cartas.Location = new System.Drawing.Point(924, 61);
            this.B_Un_Dia_Cartas.Name = "B_Un_Dia_Cartas";
            this.B_Un_Dia_Cartas.Size = new System.Drawing.Size(92, 17);
            this.B_Un_Dia_Cartas.TabIndex = 32;
            this.B_Un_Dia_Cartas.TabStop = true;
            this.B_Un_Dia_Cartas.Text = "Dia especifico";
            this.B_Un_Dia_Cartas.UseVisualStyleBackColor = true;
            this.B_Un_Dia_Cartas.CheckedChanged += new System.EventHandler(this.B_Un_Dia_Cartas_CheckedChanged);
            // 
            // B_Sin_Fecha_Cartas
            // 
            this.B_Sin_Fecha_Cartas.AutoSize = true;
            this.B_Sin_Fecha_Cartas.Location = new System.Drawing.Point(924, 38);
            this.B_Sin_Fecha_Cartas.Name = "B_Sin_Fecha_Cartas";
            this.B_Sin_Fecha_Cartas.Size = new System.Drawing.Size(73, 17);
            this.B_Sin_Fecha_Cartas.TabIndex = 31;
            this.B_Sin_Fecha_Cartas.TabStop = true;
            this.B_Sin_Fecha_Cartas.Text = "Sin Fecha";
            this.B_Sin_Fecha_Cartas.UseVisualStyleBackColor = true;
            this.B_Sin_Fecha_Cartas.CheckedChanged += new System.EventHandler(this.B_Sin_Fecha_Cartas_CheckedChanged);
            // 
            // B_Buscar_Carta
            // 
            this.B_Buscar_Carta.Location = new System.Drawing.Point(12, 107);
            this.B_Buscar_Carta.Name = "B_Buscar_Carta";
            this.B_Buscar_Carta.Size = new System.Drawing.Size(1002, 23);
            this.B_Buscar_Carta.TabIndex = 30;
            this.B_Buscar_Carta.Text = "Buscar";
            this.B_Buscar_Carta.UseVisualStyleBackColor = true;
            this.B_Buscar_Carta.Click += new System.EventHandler(this.B_Buscar_Carta_Click);
            // 
            // Grilla
            // 
            this.Grilla.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(12, 136);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(1010, 412);
            this.Grilla.TabIndex = 29;
            this.Grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellContentClick);
            // 
            // L_Fecha_Fin
            // 
            this.L_Fecha_Fin.AutoSize = true;
            this.L_Fecha_Fin.Location = new System.Drawing.Point(674, 81);
            this.L_Fecha_Fin.Name = "L_Fecha_Fin";
            this.L_Fecha_Fin.Size = new System.Drawing.Size(38, 13);
            this.L_Fecha_Fin.TabIndex = 28;
            this.L_Fecha_Fin.Text = "Hasta:";
            this.L_Fecha_Fin.Visible = false;
            // 
            // L_Fecha_Inicio
            // 
            this.L_Fecha_Inicio.AutoSize = true;
            this.L_Fecha_Inicio.Location = new System.Drawing.Point(671, 61);
            this.L_Fecha_Inicio.Name = "L_Fecha_Inicio";
            this.L_Fecha_Inicio.Size = new System.Drawing.Size(41, 13);
            this.L_Fecha_Inicio.TabIndex = 27;
            this.L_Fecha_Inicio.Text = "Desde:";
            this.L_Fecha_Inicio.Visible = false;
            // 
            // Fecha_Termino_Cartas
            // 
            this.Fecha_Termino_Cartas.Location = new System.Drawing.Point(718, 81);
            this.Fecha_Termino_Cartas.Name = "Fecha_Termino_Cartas";
            this.Fecha_Termino_Cartas.Size = new System.Drawing.Size(200, 20);
            this.Fecha_Termino_Cartas.TabIndex = 26;
            this.Fecha_Termino_Cartas.Visible = false;
            // 
            // Fecha_Inicio_Cartas
            // 
            this.Fecha_Inicio_Cartas.Location = new System.Drawing.Point(718, 55);
            this.Fecha_Inicio_Cartas.Name = "Fecha_Inicio_Cartas";
            this.Fecha_Inicio_Cartas.Size = new System.Drawing.Size(200, 20);
            this.Fecha_Inicio_Cartas.TabIndex = 25;
            this.Fecha_Inicio_Cartas.Visible = false;
            // 
            // Comentario_Cartas
            // 
            this.Comentario_Cartas.Location = new System.Drawing.Point(439, 57);
            this.Comentario_Cartas.Name = "Comentario_Cartas";
            this.Comentario_Cartas.Size = new System.Drawing.Size(120, 20);
            this.Comentario_Cartas.TabIndex = 24;
            // 
            // Para_Cartas
            // 
            this.Para_Cartas.Location = new System.Drawing.Point(206, 57);
            this.Para_Cartas.Name = "Para_Cartas";
            this.Para_Cartas.Size = new System.Drawing.Size(120, 20);
            this.Para_Cartas.TabIndex = 23;
            // 
            // De_Cartas
            // 
            this.De_Cartas.Location = new System.Drawing.Point(42, 57);
            this.De_Cartas.Name = "De_Cartas";
            this.De_Cartas.Size = new System.Drawing.Size(120, 20);
            this.De_Cartas.TabIndex = 22;
            // 
            // L_Fechas
            // 
            this.L_Fechas.AutoSize = true;
            this.L_Fechas.Location = new System.Drawing.Point(579, 60);
            this.L_Fechas.Name = "L_Fechas";
            this.L_Fechas.Size = new System.Drawing.Size(86, 13);
            this.L_Fechas.TabIndex = 21;
            this.L_Fechas.Text = "Entre las fechas:";
            // 
            // L_Comentario
            // 
            this.L_Comentario.AutoSize = true;
            this.L_Comentario.Location = new System.Drawing.Point(332, 60);
            this.L_Comentario.Name = "L_Comentario";
            this.L_Comentario.Size = new System.Drawing.Size(101, 13);
            this.L_Comentario.TabIndex = 20;
            this.L_Comentario.Text = "Ingrese Comentario:";
            // 
            // L_Para_Carta
            // 
            this.L_Para_Carta.AutoSize = true;
            this.L_Para_Carta.Location = new System.Drawing.Point(168, 60);
            this.L_Para_Carta.Name = "L_Para_Carta";
            this.L_Para_Carta.Size = new System.Drawing.Size(32, 13);
            this.L_Para_Carta.TabIndex = 19;
            this.L_Para_Carta.Text = "Para:";
            // 
            // L_De_Cartas
            // 
            this.L_De_Cartas.AutoSize = true;
            this.L_De_Cartas.Location = new System.Drawing.Point(12, 60);
            this.L_De_Cartas.Name = "L_De_Cartas";
            this.L_De_Cartas.Size = new System.Drawing.Size(24, 13);
            this.L_De_Cartas.TabIndex = 18;
            this.L_De_Cartas.Text = "De:";
            // 
            // L_Titulo
            // 
            this.L_Titulo.AutoSize = true;
            this.L_Titulo.Font = new System.Drawing.Font("Wide Latin", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Titulo.Location = new System.Drawing.Point(310, 8);
            this.L_Titulo.Name = "L_Titulo";
            this.L_Titulo.Size = new System.Drawing.Size(354, 33);
            this.L_Titulo.TabIndex = 17;
            this.L_Titulo.Text = "Buscar Cartas";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.B_Intervalo_Cartas);
            this.Controls.Add(this.B_Un_Dia_Cartas);
            this.Controls.Add(this.B_Sin_Fecha_Cartas);
            this.Controls.Add(this.B_Buscar_Carta);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.L_Fecha_Fin);
            this.Controls.Add(this.L_Fecha_Inicio);
            this.Controls.Add(this.Fecha_Termino_Cartas);
            this.Controls.Add(this.Fecha_Inicio_Cartas);
            this.Controls.Add(this.Comentario_Cartas);
            this.Controls.Add(this.Para_Cartas);
            this.Controls.Add(this.De_Cartas);
            this.Controls.Add(this.L_Fechas);
            this.Controls.Add(this.L_Comentario);
            this.Controls.Add(this.L_Para_Carta);
            this.Controls.Add(this.L_De_Cartas);
            this.Controls.Add(this.L_Titulo);
            this.MaximumSize = new System.Drawing.Size(1050, 600);
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton B_Intervalo_Cartas;
        private System.Windows.Forms.RadioButton B_Un_Dia_Cartas;
        private System.Windows.Forms.RadioButton B_Sin_Fecha_Cartas;
        private System.Windows.Forms.Button B_Buscar_Carta;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Label L_Fecha_Fin;
        private System.Windows.Forms.Label L_Fecha_Inicio;
        private System.Windows.Forms.DateTimePicker Fecha_Termino_Cartas;
        private System.Windows.Forms.DateTimePicker Fecha_Inicio_Cartas;
        private System.Windows.Forms.TextBox Comentario_Cartas;
        private System.Windows.Forms.TextBox Para_Cartas;
        private System.Windows.Forms.TextBox De_Cartas;
        private System.Windows.Forms.Label L_Fechas;
        private System.Windows.Forms.Label L_Comentario;
        private System.Windows.Forms.Label L_Para_Carta;
        private System.Windows.Forms.Label L_De_Cartas;
        private System.Windows.Forms.Label L_Titulo;
    }
}