using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC.Controller;
using MVC.Model;

namespace SistemaDeLogin
{
    internal class UsuarioController
    {
        private UsuarioModel model = new UsuarioModel();

        public string SalvarUsuario(string login, string senha)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
                return "Login ou senha não podem estar vazios.";
            }

            var usuarioExiste = model.BuscarUsuario(login);
            if (usuarioExiste != null)
            {
                MessageBox.Show("Usuario ja existe!");
                return "Usuário já existe!";
            }
            model.AdicionarUsuario(login, senha);
            MessageBox.Show($"Usuário salvo: {login}, Senha armazenada: {senha}");

            return "Usuário cadastrado!";
        }

        public bool AutenticarUsuario(string login, string senha)
        {
            var usuario = model.BuscarUsuario(login);
            if (usuario == null)
            {
                MessageBox.Show("Usuario nao encontrado.");
                return false;
            }
            bool senhaCorreta = usuario.VerificarSenha(senha);
            if (!senhaCorreta)
            {
                MessageBox.Show($"Senha correta! \nSenha digitada: {senha} \nSenha armazenada: {usuario.SenhaHash}");
            }
            
            return senhaCorreta;
        }


    }
}
