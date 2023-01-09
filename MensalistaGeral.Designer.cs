namespace Estacionamento
{
    partial class MensalistaGeral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.Adicionar_Mensalista = new System.Windows.Forms.Button();
            this.Remover_Mensalista = new System.Windows.Forms.Button();
            this.Ver_Todos = new System.Windows.Forms.Button();
            this.Histórico_geral = new System.Windows.Forms.Button();
            this.Alterar_Cadastro = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(410, 316);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 40);
            this.textBox1.TabIndex = 1;
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(336, 72);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(86, 40);
            this.Pesquisar.TabIndex = 2;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            // 
            // Adicionar_Mensalista
            // 
            this.Adicionar_Mensalista.Location = new System.Drawing.Point(538, 72);
            this.Adicionar_Mensalista.Name = "Adicionar_Mensalista";
            this.Adicionar_Mensalista.Size = new System.Drawing.Size(150, 54);
            this.Adicionar_Mensalista.TabIndex = 3;
            this.Adicionar_Mensalista.Text = "+ Mensalista";
            this.Adicionar_Mensalista.UseVisualStyleBackColor = true;
            this.Adicionar_Mensalista.Click += new System.EventHandler(this.Adicionar_Mensalista_Click);
            // 
            // Remover_Mensalista
            // 
            this.Remover_Mensalista.Location = new System.Drawing.Point(538, 252);
            this.Remover_Mensalista.Name = "Remover_Mensalista";
            this.Remover_Mensalista.Size = new System.Drawing.Size(150, 54);
            this.Remover_Mensalista.TabIndex = 4;
            this.Remover_Mensalista.Text = "- Remover";
            this.Remover_Mensalista.UseVisualStyleBackColor = true;
            // 
            // Ver_Todos
            // 
            this.Ver_Todos.Location = new System.Drawing.Point(538, 192);
            this.Ver_Todos.Name = "Ver_Todos";
            this.Ver_Todos.Size = new System.Drawing.Size(150, 54);
            this.Ver_Todos.TabIndex = 5;
            this.Ver_Todos.Text = "Ver todos";
            this.Ver_Todos.UseVisualStyleBackColor = true;
            // 
            // Histórico_geral
            // 
            this.Histórico_geral.Location = new System.Drawing.Point(538, 132);
            this.Histórico_geral.Name = "Histórico_geral";
            this.Histórico_geral.Size = new System.Drawing.Size(150, 54);
            this.Histórico_geral.TabIndex = 6;
            this.Histórico_geral.Text = "Histórico";
            this.Histórico_geral.UseVisualStyleBackColor = true;
            // 
            // Alterar_Cadastro
            // 
            this.Alterar_Cadastro.Location = new System.Drawing.Point(538, 312);
            this.Alterar_Cadastro.Name = "Alterar_Cadastro";
            this.Alterar_Cadastro.Size = new System.Drawing.Size(150, 54);
            this.Alterar_Cadastro.TabIndex = 7;
            this.Alterar_Cadastro.Text = "Alterar Cadastro";
            this.Alterar_Cadastro.UseVisualStyleBackColor = true;
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(0, 0);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(80, 25);
            this.Voltar.TabIndex = 8;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // MensalistaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Alterar_Cadastro);
            this.Controls.Add(this.Histórico_geral);
            this.Controls.Add(this.Ver_Todos);
            this.Controls.Add(this.Remover_Mensalista);
            this.Controls.Add(this.Adicionar_Mensalista);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "MensalistaGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MensalistaGeral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.Button Adicionar_Mensalista;
        private System.Windows.Forms.Button Remover_Mensalista;
        private System.Windows.Forms.Button Ver_Todos;
        private System.Windows.Forms.Button Histórico_geral;
        private System.Windows.Forms.Button Alterar_Cadastro;
        private System.Windows.Forms.Button Voltar;
    }
}