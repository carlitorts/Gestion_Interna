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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            B_Sin_Fecha_Jud.Checked = true;
        }

        private void B_Sin_Fecha_Jud_CheckedChanged(object sender, EventArgs e)
        {
            Fecha_Inicio_Jud.Visible = false;
            Fecha_Termino_Jud.Visible = false;
            L_Fecha_Inicio.Visible = false;
            L_Fecha_Fin.Visible = false;
        }

        private void B_Un_Dia_Jud_CheckedChanged(object sender, EventArgs e)
        {
            Fecha_Inicio_Jud.Visible = true;
            Fecha_Termino_Jud.Visible = false;
            L_Fecha_Inicio.Visible = false;
            L_Fecha_Fin.Visible = false;
        }

        private void B_Intervalo_Jud_CheckedChanged(object sender, EventArgs e)
        {
            Fecha_Inicio_Jud.Visible = true;
            Fecha_Termino_Jud.Visible = true;
            L_Fecha_Inicio.Visible = true;
            L_Fecha_Fin.Visible = true;
        }

        private void B_Buscar_Jud_Click(object sender, EventArgs e)
        {
            DataTable Datos = new DataTable();
            SqlCommand Buscar = new SqlCommand(null, Conexion.Conectar());
            SqlDataAdapter Adaptador = new SqlDataAdapter(Buscar);
            bool Jud_Rit = !string.IsNullOrEmpty(Rit_Jud.Text);                     //Analizo los 3 cuadros de texto, si tienen algo almaceno un true
            bool Jud_Ruc = !string.IsNullOrEmpty(Ruc_Jud.Text);           //same  
            bool Jud_Caratulado = !string.IsNullOrEmpty(Caratulado_Jud.Text);     //same
            string query = "select * from Judiciales where (";
            string Fecha = "";
            if (!Jud_Rit && !Jud_Ruc && !Jud_Caratulado && B_Sin_Fecha_Jud.Checked)
            {
                MessageBox.Show("campos vacios");
            }
            if (Jud_Rit && Jud_Ruc && Jud_Caratulado && B_Sin_Fecha_Jud.Checked) // No Fecha, ID Destino Comentario
            {
                query += "Rit='" + Rit_Jud.Text + "' and Ruc='" + Ruc_Jud.Text + "' and Caratulado='" + Caratulado_Jud.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Jud_Rit && !Jud_Ruc && !Jud_Caratulado && B_Sin_Fecha_Jud.Checked)// No Fecha, ID
            {
                query += "Rit='" + Rit_Jud.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Jud_Rit && Jud_Ruc && !Jud_Caratulado && B_Sin_Fecha_Jud.Checked)// No fecha, ID Destino
            {
                query += "Rit='" + Rit_Jud.Text + "' and Ruc='" + Ruc_Jud.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Jud_Rit && !Jud_Ruc && Jud_Caratulado && B_Sin_Fecha_Jud.Checked)// No fecha, ID Comentario
            {
                query += "Rit='" + Rit_Jud.Text + "' and Caratulado='" + Caratulado_Jud.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Jud_Rit && Jud_Ruc && !Jud_Caratulado && B_Sin_Fecha_Jud.Checked)// No fecha, Destino
            {
                query += "Ruc='" + Ruc_Jud.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Jud_Rit && Jud_Ruc && Jud_Caratulado && B_Sin_Fecha_Jud.Checked)// No fecha, Destino comentario
            {
                query += "Ruc='" + Ruc_Jud.Text + "' and Caratulado='" + Caratulado_Jud.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Jud_Rit && !Jud_Ruc && Jud_Caratulado && B_Sin_Fecha_Jud.Checked)// No fecha, Comentario
            {
                query += "Caratulado='" + Caratulado_Jud.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }// Cambio a con fechaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
            if (!Jud_Rit && !Jud_Ruc && !Jud_Caratulado && B_Un_Dia_Jud.Checked)
            {
                Fecha += "Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                query += Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Jud_Rit && Jud_Ruc && Jud_Caratulado && B_Un_Dia_Jud.Checked) // una Fecha, ID Destino Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                query += "Rit='" + Rit_Jud.Text + "' and Ruc='" + Ruc_Jud.Text + "' and Caratulado='" + Caratulado_Jud.Text + Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Jud_Rit && !Jud_Ruc && !Jud_Caratulado && B_Un_Dia_Jud.Checked)// Una Fecha, ID
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                query += "Rit='" + Rit_Jud.Text + Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Jud_Rit && Jud_Ruc && !Jud_Caratulado && B_Un_Dia_Jud.Checked)// una fecha, ID Destino
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                query += "Rit='" + Rit_Jud.Text + "' and Ruc='" + Ruc_Jud.Text + Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Jud_Rit && !Jud_Ruc && Jud_Caratulado && B_Un_Dia_Jud.Checked)// una fecha, ID Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                query += "Rit='" + Rit_Jud.Text + "' and Caratulado='" + Caratulado_Jud.Text + Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Jud_Rit && Jud_Ruc && !Jud_Caratulado && B_Un_Dia_Jud.Checked)// una fecha, Destino
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                query += "Ruc='" + Ruc_Jud.Text + Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Jud_Rit && Jud_Ruc && Jud_Caratulado && B_Un_Dia_Jud.Checked)// una fecha, Destino comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                query += "Ruc='" + Ruc_Jud.Text + "' and Caratulado='" + Caratulado_Jud.Text + Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Jud_Rit && !Jud_Ruc && Jud_Caratulado && B_Un_Dia_Jud.Checked)// una fecha, Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                query += "Caratulado='" + Caratulado_Jud.Text + Fecha + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }//intervalo de fechaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaas
            if (!Jud_Rit && !Jud_Ruc && !Jud_Caratulado && B_Intervalo_Jud.Checked)
            {
                Fecha += "Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Jud.Value.Year + "-" + Fecha_Termino_Jud.Value.Month + "-" + Fecha_Termino_Jud.Value.Day + "')";
                query += Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Jud_Rit && Jud_Ruc && Jud_Caratulado && B_Intervalo_Jud.Checked) // una Fecha, ID Destino Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Jud.Value.Year + "-" + Fecha_Termino_Jud.Value.Month + "-" + Fecha_Termino_Jud.Value.Day + "')";
                query += "Rit='" + Rit_Jud.Text + "' and Ruc='" + Ruc_Jud.Text + "' and Caratulado='" + Caratulado_Jud.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Jud_Rit && !Jud_Ruc && !Jud_Caratulado && B_Intervalo_Jud.Checked)// Una Fecha, ID
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Jud.Value.Year + "-" + Fecha_Termino_Jud.Value.Month + "-" + Fecha_Termino_Jud.Value.Day + "')";
                query += "Rit='" + Rit_Jud.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Jud_Rit && Jud_Ruc && !Jud_Caratulado && B_Intervalo_Jud.Checked)// una fecha, ID Destino
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Jud.Value.Year + "-" + Fecha_Termino_Jud.Value.Month + "-" + Fecha_Termino_Jud.Value.Day + "')";
                query += "Rit='" + Rit_Jud.Text + "' and Ruc='" + Ruc_Jud.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (Jud_Rit && !Jud_Ruc && Jud_Caratulado && B_Intervalo_Jud.Checked)// una fecha, ID Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Jud.Value.Year + "-" + Fecha_Termino_Jud.Value.Month + "-" + Fecha_Termino_Jud.Value.Day + "')";
                query += "Rit='" + Rit_Jud.Text + "' and Caratulado='" + Caratulado_Jud.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Jud_Rit && Jud_Ruc && !Jud_Caratulado && B_Intervalo_Jud.Checked)// una fecha, Destino
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Jud.Value.Year + "-" + Fecha_Termino_Jud.Value.Month + "-" + Fecha_Termino_Jud.Value.Day + "')";
                query += "Ruc='" + Ruc_Jud.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Jud_Rit && Jud_Ruc && Jud_Caratulado && B_Intervalo_Jud.Checked)// una fecha, Destino comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Jud.Value.Year + "-" + Fecha_Termino_Jud.Value.Month + "-" + Fecha_Termino_Jud.Value.Day + "')";
                query += "Ruc='" + Ruc_Jud.Text + "' and Caratulado='" + Caratulado_Jud.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
            if (!Jud_Rit && !Jud_Ruc && Jud_Caratulado && B_Intervalo_Jud.Checked)// una fecha, Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Jud.Value.Year + "-" + Fecha_Inicio_Jud.Value.Month + "-" + Fecha_Inicio_Jud.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Jud.Value.Year + "-" + Fecha_Termino_Jud.Value.Month + "-" + Fecha_Termino_Jud.Value.Day + "')";
                query += "Caratulado='" + Caratulado_Jud.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].Visible = false;
                Grilla.Columns[1].HeaderText = "Rit";
                Grilla.Columns[2].HeaderText = "Ruc";
                Grilla.Columns[3].HeaderText = "Caratulado";
                Grilla.Columns[4].HeaderText = "Fecha";
                Grilla.Columns[5].Visible = false;
            }
        }

        private void Grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Process.Start(Grilla.CurrentRow.Cells[5].Value.ToString());
        }
    }
}
