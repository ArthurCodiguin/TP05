using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Model;



namespace MVC.Controller
{
    internal class UsuarioController
    {
        private UsuarioModel model = new UsuarioModel();

        public string SalvarUsuario(string nome, string whatsApp, string email)
        {
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(whatsApp)
                || string.IsNullOrEmpty(email))
            {
                return "Nome, WhatsApp e Email são obrigatórios!";
            }


            try
            {
                Usuario user = new Usuario(nome, whatsApp, email);
                model.addUsuario(user);
                return "Usuário salvo com sucesso!";
            }
            catch (Exception ex)
            {
                return $"Erro ao salvar usuário: {ex.Message}";
            }


        }



        public List<Usuario> GetUsuarios()
        {
            return model.GetUsuarios();
        }

    }
}