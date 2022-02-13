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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin f = new();

            while (CadastroUsuarios.UsuarioLogado == null)
            {
                //se nao estiver logado
                Visible = false;
                f.ShowDialog();

                //se clicar no botão cancelar
                if (FormLogin.Cancelar == true)
                {
                    Application.Exit();
                    return;
                }
            }

            // se login for verdadeiro
            label_BoasVindas.Text = $"Bem vindo(a) \n {CadastroUsuarios.UsuarioLogado.Nome}";
            Visible = true;
        }
    }
}