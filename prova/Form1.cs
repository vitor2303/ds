using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro1
{
    public partial class btn_cliente : Form
    {
        public btn_cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "bill" && txt_senha.Text == "portao")
            {
                MessageBox.Show("Bem Vindo");
                Menu telaMenu = new Menu();
                telaMenu.Show();

            }
            else
            {
                MessageBox.Show("Usuário e/ou Senha incorretos");
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cliente_Load(object sender, EventArgs e)
        {

        }

        private void btnesqueciasenha_Click(object sender, EventArgs e)
        {
            redefinirsenha telaredefinirsenha = new redefinirsenha();
            telaredefinirsenha.Show();
        }
    }
}
