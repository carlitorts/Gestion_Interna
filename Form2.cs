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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            B_Sin_Fecha.Checked = true;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            B_Sin_Fecha.Select();
        }

        private void B_Buscar_Memo_Click(object sender, EventArgs e)
        {
            DataTable Datos = new DataTable();
            SqlCommand Buscar = new SqlCommand(null, Conexion.Conectar());
            SqlDataAdapter Adaptador = new SqlDataAdapter(Buscar);
            bool Memo_ID = !string.IsNullOrEmpty(Id_Memo.Text);                     //Analizo los 3 cuadros de texto, si tienen algo almaceno un true
            bool Memo_Destino = !string.IsNullOrEmpty(Destino_Memo.Text);           //same  
            bool Memo_Comentario = !string.IsNullOrEmpty(Comentario_Memo.Text);     //same
            string query = "select * from Memos where (";
            string Fecha = "";
            if (!Memo_ID && !Memo_Destino && !Memo_Comentario && B_Sin_Fecha.Checked)
            {
                MessageBox.Show("campos vacios");
            }
            if (Memo_ID && Memo_Destino && Memo_Comentario && B_Sin_Fecha.Checked) // No Fecha, ID Destino Comentario
            {
                query += "ID_Memo='" + Id_Memo.Text + "' and Destino='" + Destino_Memo.Text + "' and Comentario='" + Comentario_Memo.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (Memo_ID && !Memo_Destino && !Memo_Comentario && B_Sin_Fecha.Checked)// No Fecha, ID
            {
                query += "ID_Memo='" + Id_Memo.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (Memo_ID && Memo_Destino && !Memo_Comentario && B_Sin_Fecha.Checked)// No fecha, ID Destino
            {
                query += "ID_Memo='" + Id_Memo.Text + "' and Destino='" + Destino_Memo.Text +  "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (Memo_ID && !Memo_Destino && Memo_Comentario && B_Sin_Fecha.Checked)// No fecha, ID Comentario
            {
                query += "ID_Memo='" + Id_Memo.Text + "' and Comentario='" + Comentario_Memo.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (!Memo_ID && Memo_Destino && !Memo_Comentario && B_Sin_Fecha.Checked)// No fecha, Destino
            {
                query += "Destino='" + Destino_Memo.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (!Memo_ID && Memo_Destino && Memo_Comentario && B_Sin_Fecha.Checked)// No fecha, Destino comentario
            {
                query += "Destino='" + Destino_Memo.Text + "' and Comentario='" + Comentario_Memo.Text + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (!Memo_ID && !Memo_Destino && Memo_Comentario && B_Sin_Fecha.Checked)// No fecha, Comentario
            {
                    query += "Comentario='" + Comentario_Memo.Text + "')";
                    Buscar.CommandText = query;
                    Buscar.ExecuteNonQuery();
                    Adaptador.Fill(Datos);
                    Grilla.DataSource = Datos;
                    Grilla.Columns[0].HeaderText = "Numero Memo";
                    Grilla.Columns[1].HeaderText = "Destino";
                    Grilla.Columns[2].HeaderText = "Comentario";
                    Grilla.Columns[3].HeaderText = "Fecha";
                    Grilla.Columns[4].Visible = false;
            }// Cambio a con fechaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
            if (!Memo_ID && !Memo_Destino && !Memo_Comentario && B_Un_Dia.Checked)
            {
                query += "Fecha='" + Fecha_Inicio_Memo.Value + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (Memo_ID && Memo_Destino && Memo_Comentario && B_Un_Dia.Checked) // una Fecha, ID Destino Comentario
            {
                query += "ID_Memo='" + Id_Memo.Text + "' and Destino='" + Destino_Memo.Text + "' and Comentario='" + Comentario_Memo.Text + "'and Fecha='" + Fecha_Inicio_Memo.Value + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (Memo_ID && !Memo_Destino && !Memo_Comentario && B_Un_Dia.Checked)// Una Fecha, ID
            {
                query += "ID_Memo='" + Id_Memo.Text + "'and Fecha='" + Fecha_Inicio_Memo.Value + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (Memo_ID && Memo_Destino && !Memo_Comentario && B_Un_Dia.Checked)// una fecha, ID Destino
            {
                query += "ID_Memo='" + Id_Memo.Text + "' and Destino='" + Destino_Memo.Text + "'and Fecha='" + Fecha_Inicio_Memo.Value + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (Memo_ID && !Memo_Destino && Memo_Comentario && B_Un_Dia.Checked)// una fecha, ID Comentario
            {
                query += "ID_Memo='" + Id_Memo.Text + "' and Comentario='" + Comentario_Memo.Text + "'and Fecha='" + Fecha_Inicio_Memo.Value + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (!Memo_ID && Memo_Destino && !Memo_Comentario && B_Un_Dia.Checked)// una fecha, Destino
            {
                query += "Destino='" + Destino_Memo.Text + "'and Fecha='" + Fecha_Inicio_Memo.Value + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (!Memo_ID && Memo_Destino && Memo_Comentario && B_Un_Dia.Checked)// una fecha, Destino comentario
            {
                query += "Destino='" + Destino_Memo.Text + "' and Comentario='" + Comentario_Memo.Text + "'and Fecha='" + Fecha_Inicio_Memo.Value + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (!Memo_ID && !Memo_Destino && Memo_Comentario && B_Un_Dia.Checked)// una fecha, Comentario
            {
                query += "Comentario='" + Comentario_Memo.Text + "'and Fecha='" + Fecha_Inicio_Memo.Value + "')";
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }//intervalo de fechaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaas
            if (!Memo_ID && !Memo_Destino && !Memo_Comentario && B_Intervalo.Checked)
            {
                Fecha += "Fecha>='" + Fecha_Inicio_Memo.Value.Year + "-" + Fecha_Inicio_Memo.Value.Month + "-" + Fecha_Inicio_Memo.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Memo.Value.Year + "-" + Fecha_Termino_Memo.Value.Month + "-" + Fecha_Termino_Memo.Value.Day + "')";
                query += Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (Memo_ID && Memo_Destino && Memo_Comentario && B_Intervalo.Checked) // una Fecha, ID Destino Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Memo.Value.Year + "-" + Fecha_Inicio_Memo.Value.Month + "-" + Fecha_Inicio_Memo.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Memo.Value.Year + "-" + Fecha_Termino_Memo.Value.Month + "-" + Fecha_Termino_Memo.Value.Day + "')";
                query += "ID_Memo='" + Id_Memo.Text + "' and Destino='" + Destino_Memo.Text + "' and Comentario='" + Comentario_Memo.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (Memo_ID && !Memo_Destino && !Memo_Comentario && B_Intervalo.Checked)// Una Fecha, ID
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Memo.Value.Year + "-" + Fecha_Inicio_Memo.Value.Month + "-" + Fecha_Inicio_Memo.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Memo.Value.Year + "-" + Fecha_Termino_Memo.Value.Month + "-" + Fecha_Termino_Memo.Value.Day + "')";
                query += "ID_Memo='" + Id_Memo.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (Memo_ID && Memo_Destino && !Memo_Comentario && B_Intervalo.Checked)// una fecha, ID Destino
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Memo.Value.Year + "-" + Fecha_Inicio_Memo.Value.Month + "-" + Fecha_Inicio_Memo.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Memo.Value.Year + "-" + Fecha_Termino_Memo.Value.Month + "-" + Fecha_Termino_Memo.Value.Day + "')";
                query += "ID_Memo='" + Id_Memo.Text + "' and Destino='" + Destino_Memo.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (Memo_ID && !Memo_Destino && Memo_Comentario && B_Intervalo.Checked)// una fecha, ID Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Memo.Value.Year + "-" + Fecha_Inicio_Memo.Value.Month + "-" + Fecha_Inicio_Memo.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Memo.Value.Year + "-" + Fecha_Termino_Memo.Value.Month + "-" + Fecha_Termino_Memo.Value.Day + "')";
                query += "ID_Memo='" + Id_Memo.Text + "' and Comentario='" + Comentario_Memo.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (!Memo_ID && Memo_Destino && !Memo_Comentario && B_Intervalo.Checked)// una fecha, Destino
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Memo.Value.Year + "-" + Fecha_Inicio_Memo.Value.Month + "-" + Fecha_Inicio_Memo.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Memo.Value.Year + "-" + Fecha_Termino_Memo.Value.Month + "-" + Fecha_Termino_Memo.Value.Day + "')";
                query += "Destino='" + Destino_Memo.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (!Memo_ID && Memo_Destino && Memo_Comentario && B_Intervalo.Checked)// una fecha, Destino comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Memo.Value.Year + "-" + Fecha_Inicio_Memo.Value.Month + "-" + Fecha_Inicio_Memo.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Memo.Value.Year + "-" + Fecha_Termino_Memo.Value.Month + "-" + Fecha_Termino_Memo.Value.Day + "')";
                query += "Destino='" + Destino_Memo.Text + "' and Comentario='" + Comentario_Memo.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
            if (!Memo_ID && !Memo_Destino && Memo_Comentario && B_Intervalo.Checked)// una fecha, Comentario
            {
                Fecha += "' and Fecha>='" + Fecha_Inicio_Memo.Value.Year + "-" + Fecha_Inicio_Memo.Value.Month + "-" + Fecha_Inicio_Memo.Value.Day;
                Fecha += "' and Fecha<='" + Fecha_Termino_Memo.Value.Year + "-" + Fecha_Termino_Memo.Value.Month + "-" + Fecha_Termino_Memo.Value.Day + "')";
                query += "Comentario='" + Comentario_Memo.Text + Fecha;
                Buscar.CommandText = query;
                Buscar.ExecuteNonQuery();
                Adaptador.Fill(Datos);
                Grilla.DataSource = Datos;
                Grilla.Columns[0].HeaderText = "Numero Memo";
                Grilla.Columns[1].HeaderText = "Destino";
                Grilla.Columns[2].HeaderText = "Comentario";
                Grilla.Columns[3].HeaderText = "Fecha";
                Grilla.Columns[4].Visible = false;
            }
        }

        private void B_Sin_Fecha_CheckedChanged(object sender, EventArgs e)
        {
            Fecha_Inicio_Memo.Visible = false;
            Fecha_Termino_Memo.Visible = false;
            L_Fecha_Inicio.Visible = false;
            L_Fecha_Fin.Visible = false;
        }

        private void B_Un_Dia_CheckedChanged(object sender, EventArgs e)
        {
            Fecha_Inicio_Memo.Visible = true;
            Fecha_Termino_Memo.Visible = false;
            L_Fecha_Inicio.Visible = false;
            L_Fecha_Fin.Visible = false;
        }

        private void B_Intervalo_CheckedChanged(object sender, EventArgs e)
        {
            Fecha_Inicio_Memo.Visible = true;
            Fecha_Termino_Memo.Visible = true;
            L_Fecha_Inicio.Visible = true;
            L_Fecha_Fin.Visible = true;
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void Grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Process.Start(Grilla.CurrentRow.Cells[4].Value.ToString());
        }
    }
}
