namespace Estacionamento
{
    partial class Histórico_Diaristas
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
            this.Pesquisar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Check24Horas = new System.Windows.Forms.CheckBox();
            this.Check7Dias = new System.Windows.Forms.CheckBox();
            this.Check15Dias = new System.Windows.Forms.CheckBox();
            this.Check30Dias = new System.Windows.Forms.CheckBox();
            this.Diaristas = new System.Windows.Forms.CheckBox();
            this.Lavagem = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdicionarCarro = new System.Windows.Forms.Button();
            this.LucroTotal = new System.Windows.Forms.Label();
            this.QuantidadeVeiculos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.placacarroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicodiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.novoEstacionamento = new Estacionamento.NovoEstacionamento();
            this.historico_diarioTableAdapter = new Estacionamento.NovoEstacionamentoTableAdapters.Historico_diarioTableAdapter();
            this.CheckCarro = new System.Windows.Forms.CheckBox();
            this.CheckMoto = new System.Windows.Forms.CheckBox();
            this.CheckVan = new System.Windows.Forms.CheckBox();
            this.CheckOnibus = new System.Windows.Forms.CheckBox();
            this.CheckCaminhao = new System.Windows.Forms.CheckBox();
            this.Check3Dias = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicodiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoEstacionamento)).BeginInit();
            this.SuspendLayout();
            // 
            // Voltar
            // 
            this.Voltar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Voltar.Location = new System.Drawing.Point(1, 1);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 0;
            this.Voltar.Text = "Voltar\r\n";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            this.Voltar.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.Voltar.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // Pesquisar
            // 
            this.Pesquisar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pesquisar.Location = new System.Drawing.Point(352, 54);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(91, 36);
            this.Pesquisar.TabIndex = 1;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            this.Pesquisar.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.Pesquisar.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 36);
            this.textBox1.TabIndex = 2;
            // 
            // Check24Horas
            // 
            this.Check24Horas.AutoSize = true;
            this.Check24Horas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Check24Horas.Location = new System.Drawing.Point(502, 54);
            this.Check24Horas.Name = "Check24Horas";
            this.Check24Horas.Size = new System.Drawing.Size(104, 17);
            this.Check24Horas.TabIndex = 5;
            this.Check24Horas.Text = "Últimas 24 horas";
            this.Check24Horas.UseVisualStyleBackColor = true;
            this.Check24Horas.CheckedChanged += new System.EventHandler(this.OpcoesMarcadas);
            this.Check24Horas.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.Check24Horas.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // Check7Dias
            // 
            this.Check7Dias.AutoSize = true;
            this.Check7Dias.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Check7Dias.Location = new System.Drawing.Point(502, 100);
            this.Check7Dias.Name = "Check7Dias";
            this.Check7Dias.Size = new System.Drawing.Size(91, 17);
            this.Check7Dias.TabIndex = 6;
            this.Check7Dias.Text = "Últimos 7 dias";
            this.Check7Dias.UseVisualStyleBackColor = true;
            this.Check7Dias.CheckedChanged += new System.EventHandler(this.OpcoesMarcadas);
            this.Check7Dias.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.Check7Dias.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // Check15Dias
            // 
            this.Check15Dias.AutoSize = true;
            this.Check15Dias.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Check15Dias.Location = new System.Drawing.Point(502, 123);
            this.Check15Dias.Name = "Check15Dias";
            this.Check15Dias.Size = new System.Drawing.Size(97, 17);
            this.Check15Dias.TabIndex = 7;
            this.Check15Dias.Text = "Últimos 15 dias";
            this.Check15Dias.UseVisualStyleBackColor = true;
            this.Check15Dias.CheckedChanged += new System.EventHandler(this.OpcoesMarcadas);
            this.Check15Dias.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.Check15Dias.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // Check30Dias
            // 
            this.Check30Dias.AutoSize = true;
            this.Check30Dias.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Check30Dias.Location = new System.Drawing.Point(502, 146);
            this.Check30Dias.Name = "Check30Dias";
            this.Check30Dias.Size = new System.Drawing.Size(97, 17);
            this.Check30Dias.TabIndex = 8;
            this.Check30Dias.Text = "Últimos 30 dias";
            this.Check30Dias.UseVisualStyleBackColor = true;
            this.Check30Dias.CheckedChanged += new System.EventHandler(this.OpcoesMarcadas);
            this.Check30Dias.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.Check30Dias.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // Diaristas
            // 
            this.Diaristas.AutoSize = true;
            this.Diaristas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Diaristas.Location = new System.Drawing.Point(502, 169);
            this.Diaristas.Name = "Diaristas";
            this.Diaristas.Size = new System.Drawing.Size(66, 17);
            this.Diaristas.TabIndex = 9;
            this.Diaristas.Text = "Diaristas";
            this.Diaristas.UseVisualStyleBackColor = true;
            this.Diaristas.CheckedChanged += new System.EventHandler(this.OpcoesMarcadas);
            this.Diaristas.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.Diaristas.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // Lavagem
            // 
            this.Lavagem.AutoSize = true;
            this.Lavagem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Lavagem.Location = new System.Drawing.Point(652, 54);
            this.Lavagem.Name = "Lavagem";
            this.Lavagem.Size = new System.Drawing.Size(122, 17);
            this.Lavagem.TabIndex = 13;
            this.Lavagem.Text = "Diaristas + Lavagem";
            this.Lavagem.UseVisualStyleBackColor = true;
            this.Lavagem.CheckedChanged += new System.EventHandler(this.OpcoesMarcadas);
            this.Lavagem.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.Lavagem.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lucro total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Quantidade de veículos:";
            // 
            // AdicionarCarro
            // 
            this.AdicionarCarro.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AdicionarCarro.Location = new System.Drawing.Point(502, 380);
            this.AdicionarCarro.Name = "AdicionarCarro";
            this.AdicionarCarro.Size = new System.Drawing.Size(256, 41);
            this.AdicionarCarro.TabIndex = 18;
            this.AdicionarCarro.Text = "+ Veículo";
            this.AdicionarCarro.UseVisualStyleBackColor = true;
            this.AdicionarCarro.Click += new System.EventHandler(this.AdicionarCarro_Click);
            this.AdicionarCarro.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.AdicionarCarro.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // LucroTotal
            // 
            this.LucroTotal.AutoSize = true;
            this.LucroTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LucroTotal.Location = new System.Drawing.Point(603, 230);
            this.LucroTotal.Name = "LucroTotal";
            this.LucroTotal.Size = new System.Drawing.Size(0, 31);
            this.LucroTotal.TabIndex = 22;
            // 
            // QuantidadeVeiculos
            // 
            this.QuantidadeVeiculos.AutoSize = true;
            this.QuantidadeVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantidadeVeiculos.Location = new System.Drawing.Point(702, 295);
            this.QuantidadeVeiculos.Name = "QuantidadeVeiculos";
            this.QuantidadeVeiculos.Size = new System.Drawing.Size(0, 31);
            this.QuantidadeVeiculos.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placacarroDataGridViewTextBoxColumn,
            this.dataentradaDataGridViewTextBoxColumn,
            this.datasaidaDataGridViewTextBoxColumn,
            this.valorPagoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.historicodiarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 342);
            this.dataGridView1.TabIndex = 24;
            // 
            // placacarroDataGridViewTextBoxColumn
            // 
            this.placacarroDataGridViewTextBoxColumn.DataPropertyName = "Placa_carro";
            this.placacarroDataGridViewTextBoxColumn.HeaderText = "Placa_carro";
            this.placacarroDataGridViewTextBoxColumn.Name = "placacarroDataGridViewTextBoxColumn";
            // 
            // dataentradaDataGridViewTextBoxColumn
            // 
            this.dataentradaDataGridViewTextBoxColumn.DataPropertyName = "Data_entrada";
            this.dataentradaDataGridViewTextBoxColumn.HeaderText = "Data_entrada";
            this.dataentradaDataGridViewTextBoxColumn.Name = "dataentradaDataGridViewTextBoxColumn";
            // 
            // datasaidaDataGridViewTextBoxColumn
            // 
            this.datasaidaDataGridViewTextBoxColumn.DataPropertyName = "Data_saida";
            this.datasaidaDataGridViewTextBoxColumn.HeaderText = "Data_saida";
            this.datasaidaDataGridViewTextBoxColumn.Name = "datasaidaDataGridViewTextBoxColumn";
            // 
            // valorPagoDataGridViewTextBoxColumn
            // 
            this.valorPagoDataGridViewTextBoxColumn.DataPropertyName = "ValorPago";
            this.valorPagoDataGridViewTextBoxColumn.HeaderText = "ValorPago";
            this.valorPagoDataGridViewTextBoxColumn.Name = "valorPagoDataGridViewTextBoxColumn";
            // 
            // historicodiarioBindingSource
            // 
            this.historicodiarioBindingSource.DataMember = "Historico_diario";
            this.historicodiarioBindingSource.DataSource = this.novoEstacionamento;
            // 
            // novoEstacionamento
            // 
            this.novoEstacionamento.DataSetName = "NovoEstacionamento";
            this.novoEstacionamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historico_diarioTableAdapter
            // 
            this.historico_diarioTableAdapter.ClearBeforeFill = true;
            // 
            // CheckCarro
            // 
            this.CheckCarro.AutoSize = true;
            this.CheckCarro.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CheckCarro.Location = new System.Drawing.Point(652, 77);
            this.CheckCarro.Name = "CheckCarro";
            this.CheckCarro.Size = new System.Drawing.Size(51, 17);
            this.CheckCarro.TabIndex = 25;
            this.CheckCarro.Text = "Carro";
            this.CheckCarro.UseVisualStyleBackColor = true;
            this.CheckCarro.CheckedChanged += new System.EventHandler(this.OpcoesMarcadas);
            this.CheckCarro.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.CheckCarro.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // CheckMoto
            // 
            this.CheckMoto.AutoSize = true;
            this.CheckMoto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CheckMoto.Location = new System.Drawing.Point(652, 100);
            this.CheckMoto.Name = "CheckMoto";
            this.CheckMoto.Size = new System.Drawing.Size(50, 17);
            this.CheckMoto.TabIndex = 26;
            this.CheckMoto.Text = "Moto";
            this.CheckMoto.UseVisualStyleBackColor = true;
            this.CheckMoto.CheckedChanged += new System.EventHandler(this.OpcoesMarcadas);
            this.CheckMoto.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.CheckMoto.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // CheckVan
            // 
            this.CheckVan.AutoSize = true;
            this.CheckVan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CheckVan.Location = new System.Drawing.Point(652, 123);
            this.CheckVan.Name = "CheckVan";
            this.CheckVan.Size = new System.Drawing.Size(45, 17);
            this.CheckVan.TabIndex = 27;
            this.CheckVan.Text = "Van";
            this.CheckVan.UseVisualStyleBackColor = true;
            this.CheckVan.CheckedChanged += new System.EventHandler(this.OpcoesMarcadas);
            this.CheckVan.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.CheckVan.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // CheckOnibus
            // 
            this.CheckOnibus.AutoSize = true;
            this.CheckOnibus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CheckOnibus.Location = new System.Drawing.Point(652, 146);
            this.CheckOnibus.Name = "CheckOnibus";
            this.CheckOnibus.Size = new System.Drawing.Size(59, 17);
            this.CheckOnibus.TabIndex = 28;
            this.CheckOnibus.Text = "Ônibus";
            this.CheckOnibus.UseVisualStyleBackColor = true;
            this.CheckOnibus.CheckedChanged += new System.EventHandler(this.OpcoesMarcadas);
            this.CheckOnibus.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.CheckOnibus.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // CheckCaminhao
            // 
            this.CheckCaminhao.AutoSize = true;
            this.CheckCaminhao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CheckCaminhao.Location = new System.Drawing.Point(652, 169);
            this.CheckCaminhao.Name = "CheckCaminhao";
            this.CheckCaminhao.Size = new System.Drawing.Size(73, 17);
            this.CheckCaminhao.TabIndex = 29;
            this.CheckCaminhao.Text = "Caminhão";
            this.CheckCaminhao.UseVisualStyleBackColor = true;
            this.CheckCaminhao.CheckedChanged += new System.EventHandler(this.OpcoesMarcadas);
            this.CheckCaminhao.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.CheckCaminhao.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // Check3Dias
            // 
            this.Check3Dias.AutoSize = true;
            this.Check3Dias.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Check3Dias.Location = new System.Drawing.Point(502, 77);
            this.Check3Dias.Name = "Check3Dias";
            this.Check3Dias.Size = new System.Drawing.Size(91, 17);
            this.Check3Dias.TabIndex = 30;
            this.Check3Dias.Text = "Últimos 3 dias";
            this.Check3Dias.UseVisualStyleBackColor = true;
            this.Check3Dias.CheckedChanged += new System.EventHandler(this.OpcoesMarcadas);
            this.Check3Dias.MouseEnter += new System.EventHandler(this.PassandoSobre);
            this.Check3Dias.MouseLeave += new System.EventHandler(this.TirandooMouse);
            // 
            // Histórico_Diaristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Check3Dias);
            this.Controls.Add(this.CheckCaminhao);
            this.Controls.Add(this.CheckOnibus);
            this.Controls.Add(this.CheckVan);
            this.Controls.Add(this.CheckMoto);
            this.Controls.Add(this.CheckCarro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.QuantidadeVeiculos);
            this.Controls.Add(this.LucroTotal);
            this.Controls.Add(this.AdicionarCarro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lavagem);
            this.Controls.Add(this.Diaristas);
            this.Controls.Add(this.Check30Dias);
            this.Controls.Add(this.Check15Dias);
            this.Controls.Add(this.Check7Dias);
            this.Controls.Add(this.Check24Horas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.Voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Histórico_Diaristas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico_Diaristas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicodiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoEstacionamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox Check24Horas;
        private System.Windows.Forms.CheckBox Check7Dias;
        private System.Windows.Forms.CheckBox Check15Dias;
        private System.Windows.Forms.CheckBox Check30Dias;
        private System.Windows.Forms.CheckBox Diaristas;
        private System.Windows.Forms.CheckBox Lavagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AdicionarCarro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NovoEstacionamento novoEstacionamento;
        private System.Windows.Forms.BindingSource historicodiarioBindingSource;
        private NovoEstacionamentoTableAdapters.Historico_diarioTableAdapter historico_diarioTableAdapter;
        private System.Windows.Forms.CheckBox CheckCarro;
        private System.Windows.Forms.CheckBox CheckMoto;
        private System.Windows.Forms.CheckBox CheckVan;
        private System.Windows.Forms.CheckBox CheckOnibus;
        private System.Windows.Forms.CheckBox CheckCaminhao;
        private System.Windows.Forms.CheckBox Check3Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn placacarroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPagoDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label LucroTotal;
        public System.Windows.Forms.Label QuantidadeVeiculos;
    }
}