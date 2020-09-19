namespace Gestion_Interna
{
    partial class Form2
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
            this.L_Titulo = new System.Windows.Forms.Label();
            this.L_Id_Memo = new System.Windows.Forms.Label();
            this.L_Destino = new System.Windows.Forms.Label();
            this.L_Comentario = new System.Windows.Forms.Label();
            this.L_Fechas = new System.Windows.Forms.Label();
            this.Id_Memo = new System.Windows.Forms.TextBox();
            this.Destino_Memo = new System.Windows.Forms.TextBox();
            this.Comentario_Memo = new System.Windows.Forms.TextBox();
            this.Fecha_Inicio_Memo = new System.Windows.Forms.DateTimePicker();
            this.Fecha_Termino_Memo = new System.Windows.Forms.DateTimePicker();
            this.L_Fecha_Inicio = new System.Windows.Forms.Label();
            this.L_Fecha_Fin = new System.Windows.Forms.Label();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.B_Buscar_Memo = new System.Windows.Forms.Button();
            this.B_Sin_Fecha = new System.Windows.Forms.RadioButton();
            this.B_Un_Dia = new System.Windows.Forms.RadioButton();
            this.B_Intervalo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Titulo
            // 
            this.L_Titulo.AutoSize = true;
            this.L_Titulo.Font = new System.Drawing.Font("Wide Latin", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Titulo.Location = new System.Drawing.Point(310, 9);
            this.L_Titulo.Name = "L_Titulo";
            this.L_Titulo.Size = new System.Drawing.Size(367, 33);
            this.L_Titulo.TabIndex = 0;
            this.L_Titulo.Text = "Buscar Memos";
            // 
            // L_Id_Memo
            // 
            this.L_Id_Memo.AutoSize = true;
            this.L_Id_Memo.Location = new System.Drawing.Point(12, 61);
            this.L_Id_Memo.Name = "L_Id_Memo";
            this.L_Id_Memo.Size = new System.Drawing.Size(85, 13);
            this.L_Id_Memo.TabIndex = 1;
            this.L_Id_Memo.Text = "Ingrese Numero:";
            // 
            // L_Destino
            // 
            this.L_Destino.AutoSize = true;
            this.L_Destino.Location = new System.Drawing.Point(229, 62);
            this.L_Destino.Name = "L_Destino";
            this.L_Destino.Size = new System.Drawing.Size(84, 13);
            this.L_Destino.TabIndex = 2;
            this.L_Destino.Text = "Ingrese Destino:";
            // 
            // L_Comentario
            // 
            this.L_Comentario.AutoSize = true;
            this.L_Comentario.Location = new System.Drawing.Point(442, 65);
            this.L_Comentario.Name = "L_Comentario";
            this.L_Comentario.Size = new System.Drawing.Size(101, 13);
            this.L_Comentario.TabIndex = 3;
            this.L_Comentario.Text = "Ingrese Comentario:";
            // 
            // L_Fechas
            // 
            this.L_Fechas.AutoSize = true;
            this.L_Fechas.Location = new System.Drawing.Point(675, 61);
            this.L_Fechas.Name = "L_Fechas";
            this.L_Fechas.Size = new System.Drawing.Size(86, 13);
            this.L_Fechas.TabIndex = 4;
            this.L_Fechas.Text = "Entre las fechas:";
            // 
            // Id_Memo
            // 
            this.Id_Memo.Location = new System.Drawing.Point(103, 58);
            this.Id_Memo.Name = "Id_Memo";
            this.Id_Memo.Size = new System.Drawing.Size(120, 20);
            this.Id_Memo.TabIndex = 5;
            // 
            // Destino_Memo
            // 
            this.Destino_Memo.Location = new System.Drawing.Point(316, 59);
            this.Destino_Memo.Name = "Destino_Memo";
            this.Destino_Memo.Size = new System.Drawing.Size(120, 20);
            this.Destino_Memo.TabIndex = 6;
            // 
            // Comentario_Memo
            // 
            this.Comentario_Memo.Location = new System.Drawing.Point(549, 59);
            this.Comentario_Memo.Name = "Comentario_Memo";
            this.Comentario_Memo.Size = new System.Drawing.Size(120, 20);
            this.Comentario_Memo.TabIndex = 7;
            // 
            // Fecha_Inicio_Memo
            // 
            this.Fecha_Inicio_Memo.Location = new System.Drawing.Point(814, 56);
            this.Fecha_Inicio_Memo.Name = "Fecha_Inicio_Memo";
            this.Fecha_Inicio_Memo.Size = new System.Drawing.Size(200, 20);
            this.Fecha_Inicio_Memo.TabIndex = 8;
            this.Fecha_Inicio_Memo.Visible = false;
            // 
            // Fecha_Termino_Memo
            // 
            this.Fecha_Termino_Memo.Location = new System.Drawing.Point(814, 82);
            this.Fecha_Termino_Memo.Name = "Fecha_Termino_Memo";
            this.Fecha_Termino_Memo.Size = new System.Drawing.Size(200, 20);
            this.Fecha_Termino_Memo.TabIndex = 9;
            this.Fecha_Termino_Memo.Visible = false;
            // 
            // L_Fecha_Inicio
            // 
            this.L_Fecha_Inicio.AutoSize = true;
            this.L_Fecha_Inicio.Location = new System.Drawing.Point(767, 62);
            this.L_Fecha_Inicio.Name = "L_Fecha_Inicio";
            this.L_Fecha_Inicio.Size = new System.Drawing.Size(41, 13);
            this.L_Fecha_Inicio.TabIndex = 10;
            this.L_Fecha_Inicio.Text = "Desde:";
            this.L_Fecha_Inicio.Visible = false;
            // 
            // L_Fecha_Fin
            // 
            this.L_Fecha_Fin.AutoSize = true;
            this.L_Fecha_Fin.Location = new System.Drawing.Point(770, 82);
            this.L_Fecha_Fin.Name = "L_Fecha_Fin";
            this.L_Fecha_Fin.Size = new System.Drawing.Size(38, 13);
            this.L_Fecha_Fin.TabIndex = 11;
            this.L_Fecha_Fin.Text = "Hasta:";
            this.L_Fecha_Fin.Visible = false;
            // 
            // Grilla
            // 
            this.Grilla.BackgroundColor = System.Drawing.SystemColors.Info;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(12, 137);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(1010, 412);
            this.Grilla.TabIndex = 12;
            this.Grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellContentClick);
            // 
            // B_Buscar_Memo
            // 
            this.B_Buscar_Memo.Location = new System.Drawing.Point(12, 108);
            this.B_Buscar_Memo.Name = "B_Buscar_Memo";
            this.B_Buscar_Memo.Size = new System.Drawing.Size(1002, 23);
            this.B_Buscar_Memo.TabIndex = 13;
            this.B_Buscar_Memo.Text = "Buscar";
            this.B_Buscar_Memo.UseVisualStyleBackColor = true;
            this.B_Buscar_Memo.Click += new System.EventHandler(this.B_Buscar_Memo_Click);
            // 
            // B_Sin_Fecha
            // 
            this.B_Sin_Fecha.AutoSize = true;
            this.B_Sin_Fecha.Location = new System.Drawing.Point(773, 22);
            this.B_Sin_Fecha.Name = "B_Sin_Fecha";
            this.B_Sin_Fecha.Size = new System.Drawing.Size(73, 17);
            this.B_Sin_Fecha.TabIndex = 14;
            this.B_Sin_Fecha.TabStop = true;
            this.B_Sin_Fecha.Text = "Sin Fecha";
            this.B_Sin_Fecha.UseVisualStyleBackColor = true;
            this.B_Sin_Fecha.CheckedChanged += new System.EventHandler(this.B_Sin_Fecha_CheckedChanged);
            // 
            // B_Un_Dia
            // 
            this.B_Un_Dia.AutoSize = true;
            this.B_Un_Dia.Location = new System.Drawing.Point(852, 22);
            this.B_Un_Dia.Name = "B_Un_Dia";
            this.B_Un_Dia.Size = new System.Drawing.Size(92, 17);
            this.B_Un_Dia.TabIndex = 15;
            this.B_Un_Dia.TabStop = true;
            this.B_Un_Dia.Text = "Dia especifico";
            this.B_Un_Dia.UseVisualStyleBackColor = true;
            this.B_Un_Dia.CheckedChanged += new System.EventHandler(this.B_Un_Dia_CheckedChanged);
            // 
            // B_Intervalo
            // 
            this.B_Intervalo.AutoSize = true;
            this.B_Intervalo.Location = new System.Drawing.Point(950, 22);
            this.B_Intervalo.Name = "B_Intervalo";
            this.B_Intervalo.Size = new System.Drawing.Size(66, 17);
            this.B_Intervalo.TabIndex = 16;
            this.B_Intervalo.TabStop = true;
            this.B_Intervalo.Text = "Intervalo";
            this.B_Intervalo.UseVisualStyleBackColor = true;
            this.B_Intervalo.CheckedChanged += new System.EventHandler(this.B_Intervalo_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.B_Intervalo);
            this.Controls.Add(this.B_Un_Dia);
            this.Controls.Add(this.B_Sin_Fecha);
            this.Controls.Add(this.B_Buscar_Memo);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.L_Fecha_Fin);
            this.Controls.Add(this.L_Fecha_Inicio);
            this.Controls.Add(this.Fecha_Termino_Memo);
            this.Controls.Add(this.Fecha_Inicio_Memo);
            this.Controls.Add(this.Comentario_Memo);
            this.Controls.Add(this.Destino_Memo);
            this.Controls.Add(this.Id_Memo);
            this.Controls.Add(this.L_Fechas);
            this.Controls.Add(this.L_Comentario);
            this.Controls.Add(this.L_Destino);
            this.Controls.Add(this.L_Id_Memo);
            this.Controls.Add(this.L_Titulo);
            this.MaximumSize = new System.Drawing.Size(1050, 600);
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Titulo;
        private System.Windows.Forms.Label L_Id_Memo;
        private System.Windows.Forms.Label L_Destino;
        private System.Windows.Forms.Label L_Comentario;
        private System.Windows.Forms.Label L_Fechas;
        private System.Windows.Forms.TextBox Id_Memo;
        private System.Windows.Forms.TextBox Destino_Memo;
        private System.Windows.Forms.TextBox Comentario_Memo;
        private System.Windows.Forms.DateTimePicker Fecha_Inicio_Memo;
        private System.Windows.Forms.DateTimePicker Fecha_Termino_Memo;
        private System.Windows.Forms.Label L_Fecha_Inicio;
        private System.Windows.Forms.Label L_Fecha_Fin;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Button B_Buscar_Memo;
        private System.Windows.Forms.RadioButton B_Sin_Fecha;
        private System.Windows.Forms.RadioButton B_Un_Dia;
        private System.Windows.Forms.RadioButton B_Intervalo;
    }
}