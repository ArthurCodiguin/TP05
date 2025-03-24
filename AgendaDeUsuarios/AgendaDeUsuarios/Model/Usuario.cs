using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string WhatsApp { get; set; }
        public string Email { get; set; }


        public Usuario(string nome, string whatsApp, string email)
        {
            Nome = nome;
            WhatsApp = whatsApp;
            Email = email;

        }
    }
}