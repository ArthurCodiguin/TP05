using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC.Controller;
using MVC.Model;


namespace SistemaDeLogin
{
    public partial class Form1 : Form
    {
        UsuarioModel model = new UsuarioModel();
        private UsuarioController controller = new UsuarioController();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller.SalvarUsuario("Arthur", "1234");
            controller.SalvarUsuario("Igor", "4567");

            model.ListarUsuarios();

            MessageBox.Show("Bem vindo ao sistema de login!");
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            string login = txt_Login.Text;
            string senha = txt_Senha.Text;

            
            string mensagem = controller.SalvarUsuario(login, senha);
            MessageBox.Show(mensagem);
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            string login = txt_Login.Text;
            string senha = txt_Senha.Text;

            if (!controller.AutenticarUsuario(login, senha))
            {
                MessageBox.Show("Login bem-sucedido!");
            }
            else
            {
                MessageBox.Show("Login ou senha estão errados.");
            }
        }
    }
}
