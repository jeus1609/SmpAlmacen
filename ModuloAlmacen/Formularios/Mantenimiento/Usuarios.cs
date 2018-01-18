using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAlmacen.Formularios.Mantenimiento
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void uSUARIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSUARIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsLogin);

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsLogin.USUARIO' Puede moverla o quitarla según sea necesario.
            this.uSUARIOTableAdapter.Fill(this.dsLogin.USUARIO);

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = char.Parse("\0");
            passwordTextBox.Focus();
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = char.Parse("*");
        }
    }
}
