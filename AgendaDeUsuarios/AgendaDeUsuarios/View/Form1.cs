using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC.Controller;
using MVC.Model;


namespace AgendaDeUsuarios
{
    public partial class Form1 : Form
    {
        List<Usuario> usuarios = new List<Usuario>();
        private UsuarioController controller = new UsuarioController();
        private UsuarioModel model = new UsuarioModel();
        private bool renderizado = false;
        private DataGridView dgv_Usuario;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            renderizar();
        }
        private Button bt_Gerar;
        private void renderizar()
        {
            if (!renderizado)
            {
                dgv_Usuario = new DataGridView
                {
                    Location = new Point(12, 83),
                    Width = 400,
                    Height = 200,
                    ColumnCount = 3,
                    Visible = false,
                };

                dgv_Usuario.Columns[0].Name = "Nome";
                dgv_Usuario.Columns[1].Name = "WhatsApp";
                dgv_Usuario.Columns[2].Name = "Email";

                this.Controls.Add(dgv_Usuario);


                bt_Gerar = new Button
                {
                    Name = "lb_Gerar",
                    Text = "Gerar",
                    Location = new Point(512, 300),
                    Font = new Font("Microsoft Sans Serif", 11),
                    Width = 150,
                    Height = 53,
                    Visible = false
                };

                this.Controls.Add(bt_Gerar);
                bt_Gerar.Click += (s, ev) => dgv_Usuario.Visible = true;
                renderizado = true;
            }

        }
        private void atualizarGrid()
        {
            if (dgv_Usuario != null)
            {
                dgv_Usuario.Rows.Clear();
                foreach (var u in usuarios)
                {
                    dgv_Usuario.Rows.Add(u.Nome, u.WhatsApp, u.Email);
                }
            }
        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            String nome = txt_Nome.Text;
            String whatsApp = txt_WhatsApp.Text;
            String email = txt_Email.Text;

            usuarios.Add(new Usuario(nome, whatsApp, email));
            txt_Nome.Clear();
            txt_WhatsApp.Clear();
            txt_Email.Clear();
            MessageBox.Show("Usuário salvo com sucesso!");

            if (renderizado)
            {
                atualizarGrid();
            }

            if (bt_Gerar != null)
            {
                bt_Gerar.Visible = true;
            }
        }
    }
}