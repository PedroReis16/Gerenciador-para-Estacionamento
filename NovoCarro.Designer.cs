namespace Estacionamento
{
    partial class NovoCarro
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
            this.components = new System.ComponentModel.Container();
            this.Voltar = new System.Windows.Forms.Button();
            this.Remover = new System.Windows.Forms.Button();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bilheteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.novoEstacionamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.novoEstacionamento = new Estacionamento.NovoEstacionamento();
            this.TipoDeEstadia = new System.Windows.Forms.ComboBox();
            this.TipodeCarro = new System.Windows.Forms.ComboBox();
            this.Placa_carro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bilheteTableAdapter = new Estacionamento.NovoEstacionamentoTableAdapters.BilheteTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placacarroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bilheteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoEstacionamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoEstacionamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(1, 2);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(80, 25);
            this.Voltar.TabIndex = 0;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            this.Voltar.MouseEnter += new System.EventHandler(this.PassandoMouse);
            this.Voltar.MouseLeave += new System.EventHandler(this.TirandoMouse);
            // 
            // Remover
            // 
            this.Remover.Location = new System.Drawing.Point(475, 346);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(84, 44);
            this.Remover.TabIndex = 1;
            this.Remover.Text = "Remover";
            this.Remover.UseVisualStyleBackColor = true;
            this.Remover.Click += new System.EventHandler(this.Remover_Click);
            this.Remover.MouseEnter += new System.EventHandler(this.PassandoMouse);
            this.Remover.MouseLeave += new System.EventHandler(this.TirandoMouse);
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(704, 346);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(84, 44);
            this.Adicionar.TabIndex = 3;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            this.Adicionar.MouseEnter += new System.EventHandler(this.PassandoMouse);
            this.Adicionar.MouseLeave += new System.EventHandler(this.TirandoMouse);
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(371, 70);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(84, 37);
            this.Pesquisar.TabIndex = 4;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            this.Pesquisar.MouseEnter += new System.EventHandler(this.PassandoMouse);
            this.Pesquisar.MouseLeave += new System.EventHandler(this.TirandoMouse);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 37);
            this.textBox1.TabIndex = 5;
            // 
            // bilheteBindingSource
            // 
            this.bilheteBindingSource.DataMember = "Bilhete";
            this.bilheteBindingSource.DataSource = this.novoEstacionamentoBindingSource;
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
            // TipoDeEstadia
            // 
            this.TipoDeEstadia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDeEstadia.FormattingEnabled = true;
            this.TipoDeEstadia.Items.AddRange(new object[] {
            "Diarista",
            "Diarista + Lavagem"});
            this.TipoDeEstadia.Location = new System.Drawing.Point(482, 112);
            this.TipoDeEstadia.Name = "TipoDeEstadia";
            this.TipoDeEstadia.Size = new System.Drawing.Size(289, 21);
            this.TipoDeEstadia.TabIndex = 7;
            this.TipoDeEstadia.MouseEnter += new System.EventHandler(this.PassandoMouse);
            this.TipoDeEstadia.MouseLeave += new System.EventHandler(this.TirandoMouse);
            // 
            // TipodeCarro
            // 
            this.TipodeCarro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipodeCarro.FormattingEnabled = true;
            this.TipodeCarro.Items.AddRange(new object[] {
            "Moto",
            "Carro",
            "Van",
            "Ônibus",
            "Caminhão"});
            this.TipodeCarro.Location = new System.Drawing.Point(482, 186);
            this.TipodeCarro.Name = "TipodeCarro";
            this.TipodeCarro.Size = new System.Drawing.Size(289, 21);
            this.TipodeCarro.TabIndex = 8;
            this.TipodeCarro.MouseEnter += new System.EventHandler(this.PassandoMouse);
            this.TipodeCarro.MouseLeave += new System.EventHandler(this.TirandoMouse);
            // 
            // Placa_carro
            // 
            this.Placa_carro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placa_carro.Location = new System.Drawing.Point(482, 268);
            this.Placa_carro.MaxLength = 8;
            this.Placa_carro.Multiline = true;
            this.Placa_carro.Name = "Placa_carro";
            this.Placa_carro.Size = new System.Drawing.Size(289, 54);
            this.Placa_carro.TabIndex = 9;
            this.Placa_carro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo de estadia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo de veículo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Placa";
            // 
            // bilheteTableAdapter
            // 
            this.bilheteTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODTicketDataGridViewTextBoxColumn,
            this.placacarroDataGridViewTextBoxColumn,
            this.dataEntradaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bilheteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 301);
            this.dataGridView1.TabIndex = 6;
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
            this.dataEntradaDataGridViewTextBoxColumn.FillWeight = 200F;
            this.dataEntradaDataGridViewTextBoxColumn.HeaderText = "Data/Hora Entrada";
            this.dataEntradaDataGridViewTextBoxColumn.Name = "dataEntradaDataGridViewTextBoxColumn";
            this.dataEntradaDataGridViewTextBoxColumn.Width = 200;
            // 
            // NovoCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Placa_carro);
            this.Controls.Add(this.TipodeCarro);
            this.Controls.Add(this.TipoDeEstadia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.Remover);
            this.Controls.Add(this.Voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NovoCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Veículo";
            ((System.ComponentModel.ISupportInitialize)(this.bilheteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoEstacionamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoEstacionamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button Remover;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox TipoDeEstadia;
        private System.Windows.Forms.ComboBox TipodeCarro;
        private System.Windows.Forms.TextBox Placa_carro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource novoEstacionamentoBindingSource;
        private NovoEstacionamento novoEstacionamento;
        private System.Windows.Forms.BindingSource bilheteBindingSource;
        private NovoEstacionamentoTableAdapters.BilheteTableAdapter bilheteTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placacarroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaDataGridViewTextBoxColumn;
    }
}