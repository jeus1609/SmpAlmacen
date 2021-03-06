﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloAlmacen.Formularios
{
    public partial class login : Form
    {
        private static login datos;
        public static login Instancia()
        {
            if (datos == null)
            {
                datos = new login();
            }
            return datos;
        }

        DataSets.dsLoginTableAdapters.QueriesTableAdapter adapLogin = new DataSets.dsLoginTableAdapters.QueriesTableAdapter();        

        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string)adapLogin.ConsultarPassword(txtUsuario.Text) == txtPassword.Text)
            {
                Formularios.Configs.Conexion conexion = Configs.Conexion.Instancia();
                conexion.Servidor = Properties.Settings.Default.SIGA_servidor;
                conexion.Basedatos = Properties.Settings.Default.SIGA_database;
                conexion.Usuario = Properties.Settings.Default.SIGA_user;
                conexion.Passwd = Properties.Settings.Default.SIGA_passwd;

                //DataSets.dsALMACENTableAdapters.spConsultarSiExiste adapConsulta = new DataSets.dsALMACENTableAdapters.spConsultarSiExiste();

                new Principal().Show();
                this.Hide();
            }
            else
                MessageBox.Show("Contraseña y/o usuario incorrecto","",MessageBoxButtons.OK,MessageBoxIcon.Information);            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
