namespace AgendaDeUsuarios
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
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.txt_WhatsApp = new System.Windows.Forms.TextBox();
            this.lb_WhatsApp = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.bt_Adicionar = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(12, 9);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(387, 40);
            this.lb_Titulo.TabIndex = 0;
            this.lb_Titulo.Text = "Agenda de Usuários";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(589, 129);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(385, 28);
            this.txt_Nome.TabIndex = 1;
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nome.Location = new System.Drawing.Point(585, 101);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(72, 24);
            this.lb_Nome.TabIndex = 2;
            this.lb_Nome.Text = "Nome:";
            // 
            // txt_WhatsApp
            // 
            this.txt_WhatsApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WhatsApp.Location = new System.Drawing.Point(589, 186);
            this.txt_WhatsApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_WhatsApp.Name = "txt_WhatsApp";
            this.txt_WhatsApp.Size = new System.Drawing.Size(385, 28);
            this.txt_WhatsApp.TabIndex = 3;
            // 
            // lb_WhatsApp
            // 
            this.lb_WhatsApp.AutoSize = true;
            this.lb_WhatsApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_WhatsApp.Location = new System.Drawing.Point(585, 159);
            this.lb_WhatsApp.Name = "lb_WhatsApp";
            this.lb_WhatsApp.Size = new System.Drawing.Size(111, 24);
            this.lb_WhatsApp.TabIndex = 2;
            this.lb_WhatsApp.Text = "WhatsApp:";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(589, 243);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(385, 28);
            this.txt_Email.TabIndex = 3;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(585, 216);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(75, 24);
            this.lb_Email.TabIndex = 2;
            this.lb_Email.Text = "E-mail:";
            // 
            // bt_Adicionar
            // 
            this.bt_Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Adicionar.Location = new System.Drawing.Point(678, 300);
            this.bt_Adicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Adicionar.Name = "bt_Adicionar";
            this.bt_Adicionar.Size = new System.Drawing.Size(207, 53);
            this.bt_Adicionar.TabIndex = 4;
            this.bt_Adicionar.Text = "Adicionar";
            this.bt_Adicionar.UseVisualStyleBackColor = true;
            this.bt_Adicionar.Click += new System.EventHandler(this.bt_Adicionar_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(0, 0);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_Limpar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(995, 478);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Adicionar);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_WhatsApp);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_WhatsApp);
            this.Controls.Add(this.lb_Nome);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lb_Titulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.TextBox txt_WhatsApp;
        private System.Windows.Forms.Label lb_WhatsApp;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Button bt_Adicionar;
        private System.Windows.Forms.Button bt_Limpar;
    }
}

