using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;
            if (CadastroUsuarios.Login(nome, senha))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Acesso Negado");
                txtSenha.Text = "";
                txtUsuario.Text = "";
                txtUsuario.Focus();
                Close();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}