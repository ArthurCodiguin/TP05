using MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC.Controller
    {
        
        
        internal class UsuarioModel
        {
            private List<Usuario> usuarios = new List<Usuario>();

            public void AdicionarUsuario(string login, string senha )
            {
                usuarios.Add(new Usuario(login, senha));
            }
            public Usuario BuscarUsuario(string login)
            {
                return usuarios.FirstOrDefault(u => u.Login == login);
            }
            public void ListarUsuarios()
            {
                foreach (var usuario in usuarios)
                {
                    MessageBox.Show($"Login: {usuario.Login}, SenhaHash: {usuario.SenhaHash}");
                }
            }
            
        }
    }
