using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace Gestion_Interna
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            B_Sin_Fecha_Cartas.Checked = true;
        }

        private void B_Buscar_Carta_Click(object sender, EventArgs e)
        {
            DataTable Datos = new DataTable();
            SqlCommand Buscar = new SqlCommand(null, Conexion.Conectar());
            SqlDataAdapter Adaptador = new SqlDataAdapter(Buscar);
            bool Cartas_De = !string.IsNullOrEmpty(De_Cartas.Text);                     //Analizo los 3 cuadros de texto, si tienen algo almaceno un true
            bool Cartas_Para = !string.IsNullOrEmpty(Para_Cartas.Text);           //same  
            bool Cartas_Comentario = !string.IsNullOrEmpty(Comentario_Cartas.Text);     //same
            string query = "select * from Cartas where (";
            string Fecha = "";
            if (!Cartas_De && !Cartas_Para && !Cartas_Comentario && B_Sin_Fecha_Cartas.Checked)
            {
                MessageBox.Show("campos vacios");
            }
            if (Cartas_De && Cartas_Para && Cartas_Comentario && B_Sin_Fecha_Cartas.Checked) // No Fecha, ID Destino Comentario
            {
                query += "De='" + De_Cartas.Text + "' and Para='" + Para_Cartas.Text + "' and Comentario='" + Comentario_Cartas.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Cartas_De && !Cartas_Para && !Cartas_Comentario && B_Sin_Fecha_Cartas.Checked)// No Fecha, ID
            {
                query += "De='" + De_Cartas.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Cartas_De && Cartas_Para && !Cartas_Comentario && B_Sin_Fecha_Cartas.Checked)// No fecha, ID Destino
            {
                query += "De='" + De_Cartas.Text + "' and Para='" + Para_Cartas.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Cartas_De && !Cartas_Para && Cartas_Comentario && B_Sin_Fecha_Cartas.Checked)// No fecha, ID Comentario
            {
                query += "De='" + De_Cartas.Text + "' and Comentario='" + Comentario_Cartas.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Cartas_De && Cartas_Para && !Cartas_Comentario && B_Sin_Fecha_Cartas.Checked)// No fecha, Destino
            {
                query += "Para='" + Para_Cartas.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Cartas_De && Cartas_Para && Cartas_Comentario && B_Sin_Fecha_Cartas.Checked)// No fecha, Destino comentario
            {
                query += "Para='" + Para_Cartas.Text + "' and Comentario='" + Comentario_Cartas.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Cartas_De && !Cartas_Para && Cartas_Comentario && B_Sin_Fecha_Cartas.Checked)// No fecha, Comentario
            {
                query += "Comentario='" + Comentario_Cartas.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }// Cambio a con fechaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
            if (!Cartas_De && !Cartas_Para && !Cartas_Comentario && B_Un_Dia_Cartas.Checked)
            {
                Fecha += "Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                query += Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Cartas_De && Cartas_Para && Cartas_Comentario && B_Un_Dia_Cartas.Checked) // una Fecha, ID Destino Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                query += "De='" + De_Cartas.Text + "' and Para='" + Para_Cartas.Text + "' and Comentario='" + Comentario_Cartas.Text + Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Cartas_De && !Cartas_Para && !Cartas_Comentario && B_Un_Dia_Cartas.Checked)// Una Fecha, ID
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                query += "De='" + De_Cartas.Text + Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Cartas_De && Cartas_Para && !Cartas_Comentario && B_Un_Dia_Cartas.Checked)// una fecha, ID Destino
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                query += "De='" + De_Cartas.Text + "' and Para='" + Para_Cartas.Text + Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Cartas_De && !Cartas_Para && Cartas_Comentario && B_Un_Dia_Cartas.Checked)// una fecha, ID Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                query += "De='" + De_Cartas.Text + "' and Comentario='" + Comentario_Cartas.Text + Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Cartas_De && Cartas_Para && !Cartas_Comentario && B_Un_Dia_Cartas.Checked)// una fecha, Destino
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                query += "Para='" + Para_Cartas.Text + Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Cartas_De && Cartas_Para && Cartas_Comentario && B_Un_Dia_Cartas.Checked)// una fecha, Destino comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                query += "Para='" + Para_Cartas.Text + "' and Comentario='" + Comentario_Cartas.Text + Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Cartas_De && !Cartas_Para && Cartas_Comentario && B_Un_Dia_Cartas.Checked)// una fecha, Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                query += "Comentario='" + Comentario_Cartas.Text + Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }//intervalo de fechaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaas
            if (!Cartas_De && !Cartas_Para && !Cartas_Comentario && B_Intervalo_Cartas.Checked)
            {
                Fecha += "Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Cartas.Value.Year + "-" + Fecha_Termino_Cartas.Value.Month + "-" + Fecha_Termino_Cartas.Value.Day + "')";
                query += Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Cartas_De && Cartas_Para && Cartas_Comentario && B_Intervalo_Cartas.Checked) // una Fecha, ID Destino Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Cartas.Value.Year + "-" + Fecha_Termino_Cartas.Value.Month + "-" + Fecha_Termino_Cartas.Value.Day + "')";
                query += "De='" + De_Cartas.Text + "' and Para='" + Para_Cartas.Text + "' and Comentario='" + Comentario_Cartas.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Cartas_De && !Cartas_Para && !Cartas_Comentario && B_Intervalo_Cartas.Checked)// Una Fecha, ID
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Cartas.Value.Year + "-" + Fecha_Termino_Cartas.Value.Month + "-" + Fecha_Termino_Cartas.Value.Day + "')";
                query += "De='" + De_Cartas.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Cartas_De && Cartas_Para && !Cartas_Comentario && B_Intervalo_Cartas.Checked)// una fecha, ID Destino
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Cartas.Value.Year + "-" + Fecha_Termino_Cartas.Value.Month + "-" + Fecha_Termino_Cartas.Value.Day + "')";
                query += "De='" + De_Cartas.Text + "' and Para='" + Para_Cartas.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Cartas_De && !Cartas_Para && Cartas_Comentario && B_Intervalo_Cartas.Checked)// una fecha, ID Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Cartas.Value.Year + "-" + Fecha_Termino_Cartas.Value.Month + "-" + Fecha_Termino_Cartas.Value.Day + "')";
                query += "De='" + De_Cartas.Text + "' and Comentario='" + Comentario_Cartas.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Cartas_De && Cartas_Para && !Cartas_Comentario && B_Intervalo_Cartas.Checked)// una fecha, Destino
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Cartas.Value.Year + "-" + Fecha_Termino_Cartas.Value.Month + "-" + Fecha_Termino_Cartas.Value.Day + "')";
                query += "Para='" + Para_Cartas.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Cartas_De && Cartas_Para && Cartas_Comentario && B_Intervalo_Cartas.Checked)// una fecha, Destino comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Cartas.Value.Year + "-" + Fecha_Termino_Cartas.Value.Month + "-" + Fecha_Termino_Cartas.Value.Day + "')";
                query += "Para='" + Para_Cartas.Text + "' and Comentario='" + Comentario_Cartas.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Cartas_De && !Cartas_Para && Cartas_Comentario && B_Intervalo_Cartas.Checked)// una fecha, Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Cartas.Value.Year + "-" + Fecha_Inicio_Cartas.Value.Month + "-" + Fecha_Inicio_Cartas.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Cartas.Value.Year + "-" + Fecha_Termino_Cartas.Value.Month + "-" + Fecha_Termino_Cartas.Value.Day + "')";
                query += "Comentario='" + Comentario_Cartas.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "De";
                Grilla.Columns[2].HeaderText = "Para";
                Grilla.Columns[3].HeaderText = "Comentario";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
        }
        private void B_Sin_Fecha_Cartas_CheckedChanged(object sender, EventArgs e)
        {
            Fecha_Inicio_Cartas.Visible = false;
            Fecha_Termino_Cartas.Visible = false;
            L_Fecha_Inicio.Visible = false;
            L_Fecha_Fin.Visible = false;
        }

        private void B_Un_Dia_Cartas_CheckedChanged(object sender, EventArgs e)
        {
            Fecha_Inicio_Cartas.Visible = true;
            Fecha_Termino_Cartas.Visible = false;
            L_Fecha_Inicio.Visible = false;
            L_Fecha_Fin.Visible = false;
        }

        private void B_Intervalo_Cartas_CheckedChanged(object sender, EventArgs e)
        {
            Fecha_Inicio_Cartas.Visible = true;
            Fecha_Termino_Cartas.Visible = true;
            L_Fecha_Inicio.Visible = true;
            L_Fecha_Fin.Visible = true;
        }

        private void Grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Process.Start(Grilla.CurrentRow.Cells[5].Value.ToString());
        }
    }
}
