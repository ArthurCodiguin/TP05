using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MVC.Model
{
    internal class Usuario
    {
        public string Login { get; set; }
        public string SenhaHash { get; set; }

        public Usuario(string login, string senha)
        {
            Login = login;
            SenhaHash = senha;
        }
        private string GerarHash(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hash = sha256.ComputeHash(bytes);

                string hashString = Convert.ToBase64String(hash);

                MessageBox.Show($"Senha Hash Gerada: {hashString}");
                return hashString;
            }
        }
        public bool VerificarSenha(string senhaDigitada)
        {
            string senhaDigitadaHash = GerarHash(senhaDigitada);
            return SenhaHash == senhaDigitadaHash;
        }
    }
}
