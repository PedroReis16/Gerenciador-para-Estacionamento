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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdicionarCarro = new System.Windows.Forms.Button();
            this.Apagar_Carro = new System.Windows.Forms.Button();
            this.AdicionarMensalista = new System.Windows.Forms.Button();
            this.LucroTotal = new System.Windows.Forms.Label();
            this.QuantidadeVeiculos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.novoEstacionamento = new Estacionamento.NovoEstacionamento();
            this.historicodiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historico_diarioTableAdapter = new Estacionamento.NovoEstacionamentoTableAdapters.Historico_diarioTableAdapter();
            this.placacarroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoEstacionamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicodiarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(1, 1);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 0;
            this.Voltar.Text = "Voltar\r\n";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(352, 54);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(91, 36);
            this.Pesquisar.TabIndex = 1;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 36);
            this.textBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(502, 54);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Últimas 24 horas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(502, 77);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Últimos 7 dias";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(502, 100);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(97, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Últimos 15 dias";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(502, 123);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(97, 17);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Últimos 30 dias";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(636, 54);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(66, 17);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Diaristas";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(636, 77);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(81, 17);
            this.checkBox6.TabIndex = 10;
            this.checkBox6.Text = "Mensalistas";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(636, 100);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(122, 17);
            this.checkBox9.TabIndex = 13;
            this.checkBox9.Text = "Diaristas + Lavagem";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lucro total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Quantidade de veículos:";
            // 
            // AdicionarCarro
            // 
            this.AdicionarCarro.Location = new System.Drawing.Point(502, 350);
            this.AdicionarCarro.Name = "AdicionarCarro";
            this.AdicionarCarro.Size = new System.Drawing.Size(256, 41);
            this.AdicionarCarro.TabIndex = 18;
            this.AdicionarCarro.Text = "+ Carro";
            this.AdicionarCarro.UseVisualStyleBackColor = true;
            this.AdicionarCarro.Click += new System.EventHandler(this.AdicionarCarro_Click);
            // 
            // Apagar_Carro
            // 
            this.Apagar_Carro.Location = new System.Drawing.Point(502, 303);
            this.Apagar_Carro.Name = "Apagar_Carro";
            this.Apagar_Carro.Size = new System.Drawing.Size(256, 41);
            this.Apagar_Carro.TabIndex = 19;
            this.Apagar_Carro.Text = "Apagar ";
            this.Apagar_Carro.UseVisualStyleBackColor = true;
            // 
            // AdicionarMensalista
            // 
            this.AdicionarMensalista.Location = new System.Drawing.Point(502, 397);
            this.AdicionarMensalista.Name = "AdicionarMensalista";
            this.AdicionarMensalista.Size = new System.Drawing.Size(256, 41);
            this.AdicionarMensalista.TabIndex = 20;
            this.AdicionarMensalista.Text = "+ Mensalista";
            this.AdicionarMensalista.UseVisualStyleBackColor = true;
            this.AdicionarMensalista.Click += new System.EventHandler(this.AdicionarMensalista_Click);
            // 
            // LucroTotal
            // 
            this.LucroTotal.AutoSize = true;
            this.LucroTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LucroTotal.Location = new System.Drawing.Point(507, 186);
            this.LucroTotal.Name = "LucroTotal";
            this.LucroTotal.Size = new System.Drawing.Size(86, 31);
            this.LucroTotal.TabIndex = 22;
            this.LucroTotal.Text = "label3";
            // 
            // QuantidadeVeiculos
            // 
            this.QuantidadeVeiculos.AutoSize = true;
            this.QuantidadeVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantidadeVeiculos.Location = new System.Drawing.Point(507, 250);
            this.QuantidadeVeiculos.Name = "QuantidadeVeiculos";
            this.QuantidadeVeiculos.Size = new System.Drawing.Size(86, 31);
            this.QuantidadeVeiculos.TabIndex = 23;
            this.QuantidadeVeiculos.Text = "label3";
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
            // novoEstacionamento
            // 
            this.novoEstacionamento.DataSetName = "NovoEstacionamento";
            this.novoEstacionamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historicodiarioBindingSource
            // 
            this.historicodiarioBindingSource.DataMember = "Historico_diario";
            this.historicodiarioBindingSource.DataSource = this.novoEstacionamento;
            // 
            // historico_diarioTableAdapter
            // 
            this.historico_diarioTableAdapter.ClearBeforeFill = true;
            // 
            // placacarroDataGridViewTextBoxColumn
            // 
            this.placacarroDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placacarroDataGridViewTextBoxColumn.HeaderText = "Placa_carro";
            this.placacarroDataGridViewTextBoxColumn.Name = "placacarroDataGridViewTextBoxColumn";
            // 
            // dataentradaDataGridViewTextBoxColumn
            // 
            this.dataentradaDataGridViewTextBoxColumn.DataPropertyName = "Data Entrada";
            this.dataentradaDataGridViewTextBoxColumn.HeaderText = "Data_entrada";
            this.dataentradaDataGridViewTextBoxColumn.Name = "dataentradaDataGridViewTextBoxColumn";
            // 
            // datasaidaDataGridViewTextBoxColumn
            // 
            this.datasaidaDataGridViewTextBoxColumn.DataPropertyName = "Data Saída";
            this.datasaidaDataGridViewTextBoxColumn.HeaderText = "Data_saida";
            this.datasaidaDataGridViewTextBoxColumn.Name = "datasaidaDataGridViewTextBoxColumn";
            // 
            // valorPagoDataGridViewTextBoxColumn
            // 
            this.valorPagoDataGridViewTextBoxColumn.DataPropertyName = "Valor Pago";
            this.valorPagoDataGridViewTextBoxColumn.HeaderText = "ValorPago";
            this.valorPagoDataGridViewTextBoxColumn.Name = "valorPagoDataGridViewTextBoxColumn";
            // 
            // Histórico_Diaristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.QuantidadeVeiculos);
            this.Controls.Add(this.LucroTotal);
            this.Controls.Add(this.AdicionarMensalista);
            this.Controls.Add(this.Apagar_Carro);
            this.Controls.Add(this.AdicionarCarro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.Voltar);
            this.Name = "Histórico_Diaristas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico_Diaristas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoEstacionamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicodiarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AdicionarCarro;
        private System.Windows.Forms.Button Apagar_Carro;
        private System.Windows.Forms.Button AdicionarMensalista;
        private System.Windows.Forms.Label LucroTotal;
        private System.Windows.Forms.Label QuantidadeVeiculos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NovoEstacionamento novoEstacionamento;
        private System.Windows.Forms.BindingSource historicodiarioBindingSource;
        private NovoEstacionamentoTableAdapters.Historico_diarioTableAdapter historico_diarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn placacarroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPagoDataGridViewTextBoxColumn;
    }
}