using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    internal class UsuarioModel
    {
        private static List<Usuario> usuarios = new List<Usuario>();
        public void addUsuario(Usuario user)
        {
            usuarios.Add(user);
        }
        public List<Usuario> GetUsuarios()
        {
            return usuarios;
        }
    }
}