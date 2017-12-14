using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAlmacen.Formularios.Configs
{
    class Conexion
    {
        string usuario;
        string basedatos;
        string servidor;
        string passwd;
        //string cadena;
        string mensaje;
        

        public string Usuario { get => usuario; set => usuario = value; }
        public string Basedatos { get => basedatos; set => basedatos = value; }
        public string Servidor { get => servidor; set => servidor = value; }
        public string Passwd { get => passwd; set => passwd = value; }
        //public string Cadena { get => cadena; set => cadena = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }

        private static Conexion datos;
        public static Conexion Instancia()
        {
            if (datos == null)
            {
                datos = new Conexion();
            }
            return datos;
        }

        public bool ConsultarConexion(string servidor, string basedatos, string usuario, string passwd)
        {
            bool ConexionRealizada = false;
            string cadenaPrueba = String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", servidor, basedatos,usuario, passwd);
            SqlConnection miConexion = new SqlConnection(cadenaPrueba);

            PleaseWaitForm pleaseWait = new PleaseWaitForm();

            try
            {               
                // Display form modelessly
                pleaseWait.Show();

                //  ALlow main UI thread to properly display please wait form.
                Application.DoEvents();

                // Show or load the main form.
                //mainForm.ShowDialog();

                miConexion.Open();
                ConexionRealizada = true;
                Mensaje = "Conexion exitosa";
            }
            catch (SqlException ex)
            {
                Mensaje = ex.Message;
            }
            finally
            {
                miConexion.Close();
                pleaseWait.Hide();
            }
            return ConexionRealizada;
        }

        public string DevolverCadena()
        {
            return String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", Servidor, Basedatos, Usuario, Passwd);
        }
    }
}
