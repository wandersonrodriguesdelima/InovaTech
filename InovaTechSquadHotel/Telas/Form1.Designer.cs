﻿namespace InovaTechSquadHotel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTxt = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.LblSenha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.LblSenha);
            this.groupBox1.Controls.Add(this.BtnSair);
            this.groupBox1.Controls.Add(this.BtnEntrar);
            this.groupBox1.Controls.Add(this.LblLogin);
            this.groupBox1.Controls.Add(this.LblTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LblTxt
            // 
            this.LblTxt.AutoSize = true;
            this.LblTxt.Location = new System.Drawing.Point(196, 24);
            this.LblTxt.Name = "LblTxt";
            this.LblTxt.Size = new System.Drawing.Size(208, 24);
            this.LblTxt.TabIndex = 0;
            this.LblTxt.Text = "Acesso Golden Hotel";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(56, 134);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(62, 24);
            this.LblLogin.TabIndex = 1;
            this.LblLogin.Text = "Login";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(113, 297);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(123, 33);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Location = new System.Drawing.Point(371, 297);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(123, 33);
            this.BtnEntrar.TabIndex = 2;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Location = new System.Drawing.Point(56, 203);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(70, 24);
            this.LblSenha.TabIndex = 4;
            this.LblSenha.Text = "Senha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 29);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 29);
            this.textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 403);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tela Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblTxt;
    }
}

