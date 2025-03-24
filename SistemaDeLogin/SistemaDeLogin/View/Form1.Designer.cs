namespace SistemaDeLogin
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Senha = new System.Windows.Forms.Label();
            this.lb_Login = new System.Windows.Forms.Label();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.bt_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Senha
            // 
            this.lb_Senha.AutoSize = true;
            this.lb_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Senha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Senha.Location = new System.Drawing.Point(315, 243);
            this.lb_Senha.Name = "lb_Senha";
            this.lb_Senha.Size = new System.Drawing.Size(76, 24);
            this.lb_Senha.TabIndex = 14;
            this.lb_Senha.Text = "Senha:";
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Login.Location = new System.Drawing.Point(315, 178);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(68, 24);
            this.lb_Login.TabIndex = 15;
            this.lb_Login.Text = "Login:";
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(319, 310);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(166, 32);
            this.bt_Salvar.TabIndex = 13;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(319, 270);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(166, 22);
            this.txt_Senha.TabIndex = 11;
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(319, 205);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(166, 22);
            this.txt_Login.TabIndex = 12;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lb_Titulo.Location = new System.Drawing.Point(349, 108);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(106, 39);
            this.lb_Titulo.TabIndex = 10;
            this.lb_Titulo.Text = "Login";
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(319, 348);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(166, 35);
            this.bt_Login.TabIndex = 16;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.lb_Senha);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.bt_Salvar);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.lb_Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Senha;
        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Button bt_Login;
    }
}

