using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAlmacen.Formularios.Configs
{
    public partial class ConexionSIGA : Form
    {
        Formularios.Configs.Conexion clase_conexion = Configs.Conexion.Instancia();

        public ConexionSIGA()
        {
            InitializeComponent();
        }

        private void ConexionSIGA_Load(object sender, EventArgs e)
        {
            txtServidor.Text = clase_conexion.Servidor;
            txtBaseDatos.Text = clase_conexion.Basedatos;
            txtUsuario.Text = clase_conexion.Usuario;
            txtPasswd.Text = clase_conexion.Passwd;
            txtCadena.Text = clase_conexion.DevolverCadena();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Esta operacion puede tardar\n Desea Continuar", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information))

                if (clase_conexion.ConsultarConexion(txtServidor.Text, txtBaseDatos.Text, txtUsuario.Text, txtPasswd.Text))
                    MessageBox.Show(clase_conexion.Mensaje, "Conexion", MessageBoxButtons.OK);
                else
                    MessageBox.Show(clase_conexion.Mensaje, "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SIGA_servidor = txtServidor.Text;
            Properties.Settings.Default.SIGA_database = txtBaseDatos.Text;
            Properties.Settings.Default.SIGA_user = txtUsuario.Text;
            Properties.Settings.Default.SIGA_passwd = txtPasswd.Text;
            Properties.Settings.Default.Save();

            clase_conexion.Servidor = txtServidor.Text;
            clase_conexion.Basedatos = txtBaseDatos.Text;
            clase_conexion.Usuario = txtUsuario.Text;
            clase_conexion.Passwd = txtPasswd.Text;

            MessageBox.Show("Guardado correctamente");
            this.Close();
        }
    }
}
