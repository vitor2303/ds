
namespace cadastro1
{
    partial class btn_cliente
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
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnentrar = new System.Windows.Forms.Button();
            this.btnesqueciasenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(322, 167);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(325, 183);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(141, 20);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(322, 241);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_senha.TabIndex = 2;
            this.lbl_senha.Text = "Senha";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(325, 257);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(141, 20);
            this.txt_senha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGIN";
            // 
            // btnentrar
            // 
            this.btnentrar.Location = new System.Drawing.Point(356, 314);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(73, 29);
            this.btnentrar.TabIndex = 5;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnesqueciasenha
            // 
            this.btnesqueciasenha.Location = new System.Drawing.Point(334, 366);
            this.btnesqueciasenha.Name = "btnesqueciasenha";
            this.btnesqueciasenha.Size = new System.Drawing.Size(112, 23);
            this.btnesqueciasenha.TabIndex = 6;
            this.btnesqueciasenha.Text = "Esqueci a Senha";
            this.btnesqueciasenha.UseVisualStyleBackColor = true;
            this.btnesqueciasenha.Click += new System.EventHandler(this.btnesqueciasenha_Click);
            // 
            // btn_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btnesqueciasenha);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.Name = "btn_cliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btn_cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Button btnesqueciasenha;
    }
}

