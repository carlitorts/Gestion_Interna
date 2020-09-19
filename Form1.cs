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
    public partial class Formulario_Subida : Form
    {
        
        private void Subir_Memo()
        {
            if (!string.IsNullOrEmpty(ID_Memo.Text) && ID_Memo.Text.All(char.IsDigit) && !string.IsNullOrEmpty(Destino_Memo.Text) && !string.IsNullOrEmpty(Comentario_Memo.Text))
            {
                if (!string.IsNullOrEmpty(BuscarAdjunto_Memo.FileName)) //verificacion de campos
                {
                    string Carpeta_Memo = @"C:\Gestion_Documental\Memos\"; //definir variables a utilizar 
                    string ext = "";
                    int aux = 0;
                    char punto = '.';
                    string archivo = "";
                    StringBuilder errorMessages = new StringBuilder();
                    for (int i = 0; i < BuscarAdjunto_Memo.FileName.Length; i++)            //extraigo la extension del archivo
                    {
                        if (BuscarAdjunto_Memo.FileName[i] == punto)
                        {
                            aux = 1;
                        }
                        if (aux == 1)
                        {
                            ext += BuscarAdjunto_Memo.FileName[i];
                        }
                    }                                                                       //termino de extraer extension del archivo
                    archivo += Carpeta_Memo; //creo el directorio, nombre del archivo y extension
                    archivo += ID_Memo.Text;
                    archivo += ext;          //termino de crear directorio, nombre del archivo y extension
                    string Fecha = "";                      //creo la fecha sin hora 
                    Fecha += Fecha_Memo.Value.Year;
                    Fecha += "-";
                    Fecha += Fecha_Memo.Value.Month;
                    Fecha += "-";
                    Fecha += Fecha_Memo.Value.Day;          //termino de crear la fecha sin hora
                    //string insert = "insert Memos values (@ID_Memo, @Adjunto, @Comentario, @Destino, @Fecha);";
                    string queryF = "insert Memos values ('";               // Comienzo a crear la Consulta
                    queryF += ID_Memo.Text;
                    queryF += "', '";
                    queryF += Destino_Memo.Text;
                    queryF += "', '";
                    queryF += Comentario_Memo.Text;
                    queryF += "', '";
                    queryF += Fecha;
                    queryF += "', '";
                    queryF += archivo;
                    queryF += "');";                                        //termino la consulta
                    SqlCommand Ins_Memo = new SqlCommand(queryF, Conexion.Conectar()); //creo entorno consulta
                    try//       intentare ejecutar la consulta
                    {
                        Ins_Memo.ExecuteNonQuery(); //ejecuto consulta
                        System.IO.File.Copy(BuscarAdjunto_Memo.FileName, archivo, true); //creo copia del memo en directorio y nombre correspondiente
                        ID_Memo.Clear();                    //limpio campos
                        Destino_Memo.Clear();               //limpio campos
                        Comentario_Memo.Clear();            //limpio campos
                        BuscarAdjunto_Memo.Reset();         //limpio campos
                        LAdjunto_Memo.Text = "";             //limpio campos
                        string query_Memos = "select ID_Memo, Destino, Comentario, Fecha, Archivo From Memos order by ID_Memo desc";
                        SqlCommand Consulta_Memos = new SqlCommand(query_Memos, Conexion.Conectar());
                        SqlDataAdapter Date_Memos = new SqlDataAdapter(Consulta_Memos)
                        {
                            SelectCommand = Consulta_Memos
                        };
                        DataTable Datos_Memos = new DataTable();
                        Date_Memos.Fill(Datos_Memos);
                        Grilla_Memos.DataSource = Datos_Memos;
                        Grilla_Memos.Columns[0].HeaderText = "Numero Memo";
                        Grilla_Memos.Columns[1].HeaderText = "Destino";
                        Grilla_Memos.Columns[2].HeaderText = "Comentario";
                        Grilla_Memos.Columns[3].HeaderText = "Fecha";
                        Grilla_Memos.Columns[4].Visible = false;
                        MessageBox.Show("Memo creado Exitosamente");        //aviso que se creo con exito
                    }
                    catch (SqlException ex)         //procedimiento si falla la query
                    {
                        for (int i = 0; i < ex.Errors.Count; i++)//ejecuto errores
                        {
                            errorMessages.Append("Index #" + i + "\n" +
                                "Message: " + ex.Errors[i].Message + "\n" +
                                "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                "Source: " + ex.Errors[i].Source + "\n" +
                                "Procedure: " + ex.Errors[i].Procedure + "\n");
                        }
                        Console.WriteLine(errorMessages.ToString());    //aviso en consola el error
                        ID_Memo.Clear();            //limpio campos
                        Destino_Memo.Clear();       //limpio campos
                        Comentario_Memo.Clear();    //limpio campos
                        BuscarAdjunto_Memo.Reset();//limpio campos
                        LAdjunto_Memo.Text = "";    //limpio campos
                        MessageBox.Show("Error en crear el Memo");  //aviso que no se creo el memo
                    }
                }
            }                                                                                    //Rebotar y limpiar formularios
            if (string.IsNullOrEmpty(ID_Memo.Text) || !ID_Memo.Text.All(char.IsDigit))//Rebotar y limpiar formularios
                {
                    Help.ShowPopup(ID_Memo, "Numero de memo no valido", new Point(ID_Memo.Right, ID_Memo.Bottom));
                    ID_Memo.Clear();
                }
            if (string.IsNullOrEmpty(Destino_Memo.Text))                               //Rebotar y limpiar formularios
                {
                    Help.ShowPopup(Destino_Memo, "Destino Invalido", new Point(Destino_Memo.Right, Destino_Memo.Bottom));
                    Destino_Memo.Clear();
                }
            if (string.IsNullOrEmpty(Comentario_Memo.Text))                             //Rebotar y limpiar formularios
            {
                    Help.ShowPopup(Comentario_Memo, "Comentario Invalido", new Point(Comentario_Memo.Right, Destino_Memo.Bottom));
                    Comentario_Memo.Clear();
                }
            if (string.IsNullOrEmpty(BuscarAdjunto_Memo.FileName))                      //Rebotar y limpiar formularios
            {
                    Help.ShowPopup(BAdjuntar_Memo, "ingrese documento", new Point(BAdjuntar_Memo.Right, BAdjuntar_Memo.Bottom));
            }                           //fin de rebotar y limpiar formularios
        }
        private void Subir_Carta()
        {       //verifico campos
            if (!string.IsNullOrEmpty(De_Carta.Text) && !string.IsNullOrEmpty(Para_Carta.Text) && !string.IsNullOrEmpty(Comentario_Carta.Text) && !string.IsNullOrEmpty(BuscarAdjunto_Carta.FileName))
            {
                StringBuilder errorMessages = new StringBuilder(); //donde guardare el mensaje de error de bbdd
                DataTable Ultimo_Id = new DataTable(); //creo datatable donde guardare el ultimo id de la bbdd
                string Traer_Id_Query = "select top 1 ID from Cartas order by ID desc"; // creo consulta para obtener el ultimo id  
                SqlCommand Get_ID_Carta = new SqlCommand(Traer_Id_Query, Conexion.Conectar()); //preparo consulta
                
                try
                {
                    Get_ID_Carta.ExecuteNonQuery();//ejecuto consulta
                    string Carpeta_Carta = @"C:\Gestion_Documental\Cartas\"; //donde guardare cartas
                    string Archivo = "";
                    int Nuevo_Id = 0;
                    string Fecha = "";
                    Fecha += Fecha_Carta.Value.Year;
                    Fecha += "-";
                    Fecha += Fecha_Carta.Value.Month;
                    Fecha += "-";
                    Fecha += Fecha_Carta.Value.Day;
                    string ext = "";
                    char punto = '.';
                    int aux = 0;

                    SqlDataAdapter datos = new SqlDataAdapter(Get_ID_Carta);    //acomodo los datos 
                    datos.Fill(Ultimo_Id);  //los mando a la variable de datatable
                    //MessageBox.Show(UltimoId.Rows[0][0].ToString());
                    int ID = Int32.Parse(Ultimo_Id.Rows[0][0].ToString());  //los almaceno como entero
                    Nuevo_Id = (ID + 1);    //le sumo uno para tener el nuevo id de la carta
                    for (int i = 0; i < BuscarAdjunto_Carta.FileName.Length; i++)            //extraigo la extension del archivo
                    {
                        if (BuscarAdjunto_Carta.FileName[i] == punto)
                        {
                            aux = 1;
                        }
                        if (aux == 1)
                        {
                            ext += BuscarAdjunto_Carta.FileName[i];
                        }
                    }
                    Archivo += Carpeta_Carta;
                    Archivo += De_Carta.Text;
                    Archivo += Nuevo_Id.ToString();
                    Archivo += ext;
                    string Query_Subir_Carta = "insert into Cartas values (@ID, @De, @Para, @Comentario, @Fecha, @Archivo);";
                    SqlCommand Subir_Carta = new SqlCommand(Query_Subir_Carta, Conexion.Conectar());
                    Subir_Carta.Parameters.AddWithValue("@ID", Nuevo_Id.ToString());
                    Subir_Carta.Parameters.AddWithValue("@De", De_Carta.Text);
                    Subir_Carta.Parameters.AddWithValue("@Para", Para_Carta.Text);
                    Subir_Carta.Parameters.AddWithValue("@Fecha", Fecha);
                    Subir_Carta.Parameters.AddWithValue("@Comentario", Comentario_Carta.Text);
                    Subir_Carta.Parameters.AddWithValue("@Archivo", Archivo);
                    try
                    {
                        Subir_Carta.ExecuteNonQuery();
                        System.IO.File.Copy(BuscarAdjunto_Carta.FileName, Archivo, true); //creo copia de la Carta en directorio y nombre correspondiente
                        De_Carta.Clear();            //limpio campos
                        Para_Carta.Clear();       //limpio campos
                        Comentario_Carta.Clear();    //limpio campos
                        BuscarAdjunto_Carta.Reset();//limpio campos
                        L_Ad_Carta.Text = "";    //limpio campos
                        string query_Cartas = "select ID, De, Para, Comentario, Fecha, Archivo From Cartas order by ID desc";
                        SqlCommand consulta_Cartas = new SqlCommand(query_Cartas, Conexion.Conectar());
                        SqlDataAdapter date_Cartas = new SqlDataAdapter(consulta_Cartas)
                        {
                            SelectCommand = consulta_Cartas
                        };
                        DataTable Datos_Cartas = new DataTable();
                        date_Cartas.Fill(Datos_Cartas);
                        Grilla_Cartas.DataSource = Datos_Cartas;
                        Grilla_Cartas.Columns[1].HeaderText = "De";
                        Grilla_Cartas.Columns[2].HeaderText = "Para";
                        Grilla_Cartas.Columns[3].HeaderText = "Comentario";
                        Grilla_Cartas.Columns[4].HeaderText = "Fecha";
                        Grilla_Cartas.Columns[0].Visible = false;
                        Grilla_Cartas.Columns[5].Visible = false;
                        MessageBox.Show("Carta subida con exito! jiji :D");
                    }
                    catch (SqlException ex)
                    {
                        for (int i = 0; i < ex.Errors.Count; i++)//ejecuto errores
                        {
                            errorMessages.Append("Index #" + i + "\n" +
                                "Message: " + ex.Errors[i].Message + "\n" +
                                "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                "Source: " + ex.Errors[i].Source + "\n" +
                                "Procedure: " + ex.Errors[i].Procedure + "\n");
                        }
                        Console.WriteLine(errorMessages.ToString());    //aviso en consola el error
                        De_Carta.Clear();            //limpio campos
                        Para_Carta.Clear();       //limpio campos
                        Comentario_Carta.Clear();    //limpio campos
                        BuscarAdjunto_Carta.Reset();//limpio campos
                        L_Ad_Carta.Text = "";    //limpio campos
                        MessageBox.Show("No se pudo subir la carta :c");  //aviso que no se pudo subir la carta
                    }
                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)//ejecuto errores
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    Console.WriteLine(errorMessages.ToString());    //aviso en consola el error
                    ID_Memo.Clear();            //limpio campos
                    Destino_Memo.Clear();       //limpio campos
                    Comentario_Memo.Clear();    //limpio campos
                    BuscarAdjunto_Memo.Reset();//limpio campos
                    LAdjunto_Memo.Text = "";    //limpio campos
                    MessageBox.Show("No se pudo conectar con la base de datos :c");  //aviso que no se pudo conectar a la base de datos
                }

            }
            if (string.IsNullOrEmpty(De_Carta.Text))
            {
                Help.ShowPopup(BAdjuntar_Carta, "Ingrese datos", new Point(De_Carta.Right, De_Carta.Bottom));
            }
            if (string.IsNullOrEmpty(Para_Carta.Text))
            {
                Help.ShowPopup(BAdjuntar_Carta, "Ingrese datos", new Point(Para_Carta.Right, Para_Carta.Bottom));
            }
            if (string.IsNullOrEmpty(Comentario_Carta.Text))
            {
                Help.ShowPopup(BAdjuntar_Carta, "Ingrese datos", new Point(Comentario_Carta.Right, Comentario_Carta.Bottom));
            }
            if (string.IsNullOrEmpty(BuscarAdjunto_Carta.FileName))
            {
                Help.ShowPopup(BAdjuntar_Carta, "Ingrese datos", new Point(BAdjuntar_Carta.Right, BAdjuntar_Carta.Bottom));
            }
        }
        private void Subir_Judicial()
        {
            if (!string.IsNullOrEmpty(Rit_Jud.ToString()) && !string.IsNullOrEmpty(Ruc_Jud.ToString()) && !string.IsNullOrEmpty(Caratulado_Jud.ToString()) && !string.IsNullOrEmpty(BuscarAdjunto_Jud.FileName))
            {
                string Traer_Id_Query = "select top 1 ID from Judiciales order by ID desc"; // creo consulta para obtener el ultimo id  
                SqlCommand Get_ID_Jud = new SqlCommand(Traer_Id_Query, Conexion.Conectar()); // preparo consulta 
                StringBuilder errorMessages = new StringBuilder();  //creo variable donde almacenar error
                try
                {
                    int aux = 0; //                 Crear variables chicooos
                    char punto = '.';
                    string ext = "";
                    DataTable Ultimo_Id = new DataTable();
                    int Nuevo_Id = 0;
                    string Carpeta_Jud = @"C:\Gestion_Documental\Judiciales\"; //donde guardare jud
                    string Archivo = ""; //         termino de crear variables chicooos
                    Get_ID_Jud.ExecuteNonQuery();                     //ejecuto consulta
                    for (int i = 0; i < BuscarAdjunto_Jud.FileName.Length; i++)            //extraigo la extension del archivo
                    {
                        if (BuscarAdjunto_Jud.FileName[i] == punto)
                        {
                            aux = 1;
                        }
                        if (aux == 1)
                        {
                            ext += BuscarAdjunto_Jud.FileName[i];
                        }
                    }//                                                                     Termino de extraer la extension del archivo
                    string Fecha = ""; //           Comienzo a preparar la fecha en formato de BBDD
                    Fecha += Fecha_Jud.Value.Year;
                    Fecha += "-";
                    Fecha += Fecha_Jud.Value.Month;
                    Fecha += "-";//                 Termino de preparar la fecha en formato BBDD
                    Fecha += Fecha_Jud.Value.Day;                   
                    SqlDataAdapter datos = new SqlDataAdapter(Get_ID_Jud);    //    acomodo el id recibido de la BBDD
                    datos.Fill(Ultimo_Id);  //  Lo guardo en datatable
                    //MessageBox.Show(UltimoId.Rows[0][0].ToString());
                    int ID = Int32.Parse(Ultimo_Id.Rows[0][0].ToString());  //Almaceno como entero el valor de id sacado de la BBDD
                    Nuevo_Id = (ID + 1);    // Sumo 1 para tener el id del dato que subire
                    Archivo += Carpeta_Jud;//       Comienzo a buscar la carpeta y nombre del nuevo documento judicial
                    Archivo += Rit_Jud.Text;
                    Archivo += "-";
                    Archivo += Ruc_Jud.Text;
                    Archivo += "_";
                    Archivo += Nuevo_Id.ToString();
                    Archivo += ext;//               Termino de crear el directorio y nombre de la copia del documento judicial
                    string Query_Subir_Jud = "insert into Judiciales values (@ID, @Rit, @Ruc, @Caratulado, @Fecha, @Archivo);"; //preparo la consulta con los datos que tengo en los textbox
                    SqlCommand Subir_Jud = new SqlCommand(Query_Subir_Jud, Conexion.Conectar());
                    Subir_Jud.Parameters.AddWithValue("@ID", Nuevo_Id.ToString());
                    Subir_Jud.Parameters.AddWithValue("@Rit", Rit_Jud.Text);
                    Subir_Jud.Parameters.AddWithValue("@Ruc", Ruc_Jud.Text);
                    Subir_Jud.Parameters.AddWithValue("@Caratulado", Caratulado_Jud.Text);
                    Subir_Jud.Parameters.AddWithValue("@Fecha", Fecha);
                    Subir_Jud.Parameters.AddWithValue("@Archivo", Archivo);//                                               termino de preparar la consulta 
                    try
                    {
                        Subir_Jud.ExecuteNonQuery();//Ejecuto la query de buscar id
                        System.IO.File.Copy(BuscarAdjunto_Jud.FileName, Archivo, true); //creo copia de la Carta en directorio y nombre correspondiente
                        Rit_Jud.Clear();            //limpio campos
                        Ruc_Jud.Clear();       //limpio campos
                        Caratulado_Jud.Clear();    //limpio campos
                        BuscarAdjunto_Jud.Reset();//limpio campos
                        L_Adj_Jud.Text = "";    //limpio campos
                        string query_Judicial = "select ID, Rit, Ruc, Caratulado, Fecha, Archivo From Judiciales order by ID desc";
                        SqlCommand consulta_Judicial = new SqlCommand(query_Judicial, Conexion.Conectar());
                        SqlDataAdapter date_Judicial = new SqlDataAdapter(consulta_Judicial)
                        {
                            SelectCommand = consulta_Judicial
                        };
                        DataTable Datos_Judicial = new DataTable();
                        date_Judicial.Fill(Datos_Judicial);
                        Grilla_Judicial.DataSource = Datos_Judicial;
                        Grilla_Judicial.Columns[1].HeaderText = "Rit";
                        Grilla_Judicial.Columns[2].HeaderText = "Ruc";
                        Grilla_Judicial.Columns[3].HeaderText = "Caratulado";
                        Grilla_Judicial.Columns[4].HeaderText = "Fecha";
                        Grilla_Judicial.Columns[0].Visible = false;
                        Grilla_Judicial.Columns[5].Visible = false;
                        MessageBox.Show("Documento Judicial subido con exito! jiji :D"); //aviso que se subio con exito
                    }
                    catch (SqlException ex)
                    {
                        for (int i = 0; i < ex.Errors.Count; i++)//ejecuto errores
                        {
                            errorMessages.Append("Index #" + i + "\n" +
                                "Message: " + ex.Errors[i].Message + "\n" +
                                "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                "Source: " + ex.Errors[i].Source + "\n" +
                                "Procedure: " + ex.Errors[i].Procedure + "\n");
                        }
                        Console.WriteLine(errorMessages.ToString());    //aviso en consola el error
                        Rit_Jud.Clear();            //limpio campos
                        Ruc_Jud.Clear();       //limpio campos
                        Caratulado_Jud.Clear();    //limpio campos
                        BuscarAdjunto_Jud.Reset();//limpio campos
                        L_Adj_Jud.Text = "";    //limpio campos-
                        MessageBox.Show("No se pudo subir el documento judicial :c");  //aviso que no se pudo subir la carta
                    }
                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)//ejecuto errores
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    Console.WriteLine(errorMessages.ToString());    //aviso en consola el error
                    Rit_Jud.Clear();            //limpio campos
                    Ruc_Jud.Clear();       //limpio campos
                    Caratulado_Jud.Clear();    //limpio campos
                    BuscarAdjunto_Jud.Reset();//limpio campos
                    L_Adj_Jud.Text = "";    //limpio campos
                    MessageBox.Show("No se pudo conectar con la base de datos :c");  //aviso que no se pudo conectar a la base de datos
                }               
            }
            if (string.IsNullOrEmpty(Rit_Jud.Text))
            {
                Help.ShowPopup(B_Adj_Jud, "Ingrese datos", new Point(Rit_Jud.Right, Rit_Jud.Bottom));
            }
            if (string.IsNullOrEmpty(Ruc_Jud.Text))
            {
                Help.ShowPopup(B_Adj_Jud, "Ingrese datos", new Point(Ruc_Jud.Right, Ruc_Jud.Bottom));
            }
            if (string.IsNullOrEmpty(Caratulado_Jud.Text))
            {
                Help.ShowPopup(B_Adj_Jud, "Ingrese datos", new Point(Caratulado_Jud.Right, Caratulado_Jud.Bottom));
            }
            if (string.IsNullOrEmpty(BuscarAdjunto_Carta.FileName))
            {
                Help.ShowPopup(B_Adj_Jud, "Ingrese datos", new Point(B_Adj_Jud.Right, B_Adj_Jud.Bottom));
            }
        }

        public Formulario_Subida()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query_Memos = "select ID_Memo, Destino, Comentario, Fecha, Archivo From Memos order by ID_Memo desc";
            SqlCommand Consulta_Memos = new SqlCommand(query_Memos, Conexion.Conectar());
            SqlDataAdapter Date_Memos = new SqlDataAdapter(Consulta_Memos)
            {
                SelectCommand = Consulta_Memos
            };
            DataTable Datos_Memos = new DataTable();
            Date_Memos.Fill(Datos_Memos);
            Grilla_Memos.DataSource = Datos_Memos;
            Grilla_Memos.Columns[0].HeaderText = "Numero Memo";
            Grilla_Memos.Columns[1].HeaderText = "Destino";
            Grilla_Memos.Columns[2].HeaderText = "Comentario";
            Grilla_Memos.Columns[3].HeaderText = "Fecha";
            Grilla_Memos.Columns[4].Visible = false;
            string query_Cartas = "select ID, De, Para, Comentario, Fecha, Archivo From Cartas order by ID desc";
            SqlCommand consulta_Cartas = new SqlCommand(query_Cartas, Conexion.Conectar());
            SqlDataAdapter date_Cartas = new SqlDataAdapter(consulta_Cartas)
            {
                SelectCommand = consulta_Cartas
            };
            DataTable Datos_Cartas = new DataTable();
            date_Cartas.Fill(Datos_Cartas);
            Grilla_Cartas.DataSource = Datos_Cartas;
            Grilla_Cartas.Columns[1].HeaderText = "De";
            Grilla_Cartas.Columns[2].HeaderText = "Para";
            Grilla_Cartas.Columns[3].HeaderText = "Comentario";
            Grilla_Cartas.Columns[4].HeaderText = "Fecha";
            Grilla_Cartas.Columns[0].Visible = false;
            Grilla_Cartas.Columns[5].Visible = false;
            string query_Judicial = "select ID, Rit, Ruc, Caratulado, Fecha, Archivo From Judiciales order by ID desc";
            SqlCommand consulta_Judicial = new SqlCommand(query_Judicial, Conexion.Conectar());
            SqlDataAdapter date_Judicial = new SqlDataAdapter(consulta_Judicial)
            {
                SelectCommand = consulta_Judicial
            };
            DataTable Datos_Judicial = new DataTable();
            date_Judicial.Fill(Datos_Judicial);
            Grilla_Judicial.DataSource = Datos_Judicial;
            Grilla_Judicial.Columns[1].HeaderText = "Rit";
            Grilla_Judicial.Columns[2].HeaderText = "Ruc";
            Grilla_Judicial.Columns[3].HeaderText = "Caratulado";
            Grilla_Judicial.Columns[4].HeaderText = "Fecha";
            Grilla_Judicial.Columns[0].Visible = false;
            Grilla_Judicial.Columns[5].Visible = false;
        }
        private void BAdjuntar_Memo_Click(object sender, EventArgs e)
        {
            BuscarAdjunto_Memo.ShowDialog();
            LAdjunto_Memo.Text = BuscarAdjunto_Memo.FileName;
        }

        private void BAdjuntar_Carta_Click(object sender, EventArgs e)
        {
            BuscarAdjunto_Carta.ShowDialog();
            L_Ad_Carta.Text = BuscarAdjunto_Carta.FileName;
        }
        private void B_Adj_Jud_Click(object sender, EventArgs e)
        {
            BuscarAdjunto_Jud.ShowDialog();
            L_Adj_Jud.Text = BuscarAdjunto_Jud.FileName;
        }

        private void BAdj_Jud_Click(object sender, EventArgs e)
        {
            Subir_Judicial();
        }

        private void B_Subir_Memo_Click(object sender, EventArgs e)
        {
            Subir_Memo();
        }

        private void B_Subir_Carta_Click(object sender, EventArgs e)
        {
            Subir_Carta();
        }

        private void Grilla_Memos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Process.Start(Grilla_Memos.CurrentRow.Cells[4].Value.ToString());
        }

        private void Grilla_Cartas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Process.Start(Grilla_Cartas.CurrentRow.Cells[5].Value.ToString());
        }

        private void Grilla_Judicial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Process.Start(Grilla_Judicial.CurrentRow.Cells[5].Value.ToString());
        }

        private void B_Buscar_Memo_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void B_Buscar_Carta_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void B_Buscar_Judicial_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            string comando = "SERVER=";
            TextReader Datos = new StreamReader("Conexion.txt");
            comando += Datos.ReadLine();
            comando += ";DATABASE=";
            comando += Datos.ReadLine();
            comando += ";integrated security=true;";
            //SERVER=DESKTOP-DINQFR0;DATABASE=Gestion_Interna;integrated security=true;
            SqlConnection cn = new SqlConnection(comando);
            cn.Open();
            return cn;
        }
    }

}
