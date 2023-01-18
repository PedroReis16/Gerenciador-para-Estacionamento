namespace Estacionamento
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
            this.components = new System.ComponentModel.Container();
            this.Botao_Pesquisar = new System.Windows.Forms.Button();
            this.Botao_Adicionar_Carro = new System.Windows.Forms.Button();
            this.Botao_remover_carro = new System.Windows.Forms.Button();
            this.Botao_Historico = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.estacionamentoDataSet = new Estacionamento.EstacionamentoDataSet();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new Estacionamento.EstacionamentoDataSetTableAdapters.TicketTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placacarroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilheteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.novoEstacionamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.novoEstacionamento = new Estacionamento.NovoEstacionamento();
            this.bilheteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilheteTableAdapter = new Estacionamento.NovoEstacionamentoTableAdapters.BilheteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilheteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoEstacionamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoEstacionamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilheteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Botao_Pesquisar
            // 
            this.Botao_Pesquisar.Location = new System.Drawing.Point(389, 31);
            this.Botao_Pesquisar.Name = "Botao_Pesquisar";
            this.Botao_Pesquisar.Size = new System.Drawing.Size(66, 37);
            this.Botao_Pesquisar.TabIndex = 0;
            this.Botao_Pesquisar.Text = "Pesquisar";
            this.Botao_Pesquisar.UseVisualStyleBackColor = true;
            this.Botao_Pesquisar.Click += new System.EventHandler(this.Botao_Pesquisar_Click);
            this.Botao_Pesquisar.MouseEnter += new System.EventHandler(this.PassandoMouse);
            this.Botao_Pesquisar.MouseLeave += new System.EventHandler(this.TirandoMouse);
            // 
            // Botao_Adicionar_Carro
            // 
            this.Botao_Adicionar_Carro.Location = new System.Drawing.Point(521, 74);
            this.Botao_Adicionar_Carro.Name = "Botao_Adicionar_Carro";
            this.Botao_Adicionar_Carro.Size = new System.Drawing.Size(222, 45);
            this.Botao_Adicionar_Carro.TabIndex = 1;
            this.Botao_Adicionar_Carro.Text = "+ Carro";
            this.Botao_Adicionar_Carro.UseVisualStyleBackColor = true;
            this.Botao_Adicionar_Carro.Click += new System.EventHandler(this.Botao_Adicionar_Carro_Click);
            this.Botao_Adicionar_Carro.MouseEnter += new System.EventHandler(this.PassandoMouse);
            this.Botao_Adicionar_Carro.MouseLeave += new System.EventHandler(this.TirandoMouse);
            // 
            // Botao_remover_carro
            // 
            this.Botao_remover_carro.Location = new System.Drawing.Point(521, 136);
            this.Botao_remover_carro.Name = "Botao_remover_carro";
            this.Botao_remover_carro.Size = new System.Drawing.Size(222, 45);
            this.Botao_remover_carro.TabIndex = 3;
            this.Botao_remover_carro.Text = "- Carro";
            this.Botao_remover_carro.UseVisualStyleBackColor = true;
            this.Botao_remover_carro.Click += new System.EventHandler(this.Botao_remover_carro_Click);
            this.Botao_remover_carro.MouseEnter += new System.EventHandler(this.PassandoMouse);
            this.Botao_remover_carro.MouseLeave += new System.EventHandler(this.TirandoMouse);
            // 
            // Botao_Historico
            // 
            this.Botao_Historico.Location = new System.Drawing.Point(521, 359);
            this.Botao_Historico.Name = "Botao_Historico";
            this.Botao_Historico.Size = new System.Drawing.Size(222, 45);
            this.Botao_Historico.TabIndex = 5;
            this.Botao_Historico.Text = "Histórico";
            this.Botao_Historico.UseVisualStyleBackColor = true;
            this.Botao_Historico.Click += new System.EventHandler(this.Botao_Historico_Click);
            this.Botao_Historico.MouseEnter += new System.EventHandler(this.PassandoMouse);
            this.Botao_Historico.MouseLeave += new System.EventHandler(this.TirandoMouse);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 37);
            this.textBox1.TabIndex = 7;
            // 
            // estacionamentoDataSet
            // 
            this.estacionamentoDataSet.DataSetName = "EstacionamentoDataSet";
            this.estacionamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.estacionamentoDataSet;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(405, 355);
            this.listBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODTicketDataGridViewTextBoxColumn,
            this.placacarroDataGridViewTextBoxColumn,
            this.dataEntradaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bilheteBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 367);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cODTicketDataGridViewTextBoxColumn
            // 
            this.cODTicketDataGridViewTextBoxColumn.DataPropertyName = "COD_Ticket";
            this.cODTicketDataGridViewTextBoxColumn.HeaderText = "Ticket";
            this.cODTicketDataGridViewTextBoxColumn.Name = "cODTicketDataGridViewTextBoxColumn";
            // 
            // placacarroDataGridViewTextBoxColumn
            // 
            this.placacarroDataGridViewTextBoxColumn.DataPropertyName = "Placa_carro";
            this.placacarroDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placacarroDataGridViewTextBoxColumn.Name = "placacarroDataGridViewTextBoxColumn";
            // 
            // dataEntradaDataGridViewTextBoxColumn
            // 
            this.dataEntradaDataGridViewTextBoxColumn.DataPropertyName = "DataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.HeaderText = "Data/Hora Entrada";
            this.dataEntradaDataGridViewTextBoxColumn.Name = "dataEntradaDataGridViewTextBoxColumn";
            this.dataEntradaDataGridViewTextBoxColumn.Width = 200;
            // 
            // bilheteBindingSource1
            // 
            this.bilheteBindingSource1.DataMember = "Bilhete";
            this.bilheteBindingSource1.DataSource = this.novoEstacionamentoBindingSource;
            // 
            // novoEstacionamentoBindingSource
            // 
            this.novoEstacionamentoBindingSource.DataSource = this.novoEstacionamento;
            this.novoEstacionamentoBindingSource.Position = 0;
            // 
            // novoEstacionamento
            // 
            this.novoEstacionamento.DataSetName = "NovoEstacionamento";
            this.novoEstacionamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilheteBindingSource
            // 
            this.bilheteBindingSource.DataMember = "Bilhete";
            this.bilheteBindingSource.DataSource = this.novoEstacionamento;
            // 
            // bilheteTableAdapter
            // 
            this.bilheteTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Botao_Historico);
            this.Controls.Add(this.Botao_remover_carro);
            this.Controls.Add(this.Botao_Adicionar_Carro);
            this.Controls.Add(this.Botao_Pesquisar);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilheteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoEstacionamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoEstacionamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilheteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Botao_Pesquisar;
        private System.Windows.Forms.Button Botao_Adicionar_Carro;
        private System.Windows.Forms.Button Botao_remover_carro;
        private System.Windows.Forms.Button Botao_Historico;
        private System.Windows.Forms.TextBox textBox1;
        private EstacionamentoDataSet estacionamentoDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private EstacionamentoDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NovoEstacionamento novoEstacionamento;
        private System.Windows.Forms.BindingSource bilheteBindingSource;
        private NovoEstacionamentoTableAdapters.BilheteTableAdapter bilheteTableAdapter;
        private System.Windows.Forms.BindingSource bilheteBindingSource1;
        private System.Windows.Forms.BindingSource novoEstacionamentoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placacarroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaDataGridViewTextBoxColumn;
    }
}

