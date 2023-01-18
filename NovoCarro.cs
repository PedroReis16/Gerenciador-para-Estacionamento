using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class NovoCarro : Form
    {
        Banco comandos = new Banco();
        Thread voltar, mensalista;
        int coluna;

        public NovoCarro()
        {
            InitializeComponent();
            comandos.TabelaEstacionados(dataGridView1);
            dataGridView1.SelectionMode= DataGridViewSelectionMode.FullRowSelect; //Seleciona a linha inteira a partir de qualquer item da tabela
            Remover.Enabled = false;
            dataGridView1.ReadOnly= true;
        }
        
        private void Voltar_Click(object sender, EventArgs e)
        {
            //Botão que direciona para a tela principal
            this.Close();
            voltar = new Thread(abrirForm1);
            voltar.SetApartmentState(ApartmentState.MTA);
            voltar.Start();
        }
        private void abrirForm1(object obj)
        {
            Application.Run(new Form1());
        }
        
        private void Adicionar_Click(object sender, EventArgs e)
        {
            int TipoCarro, TipoEstadia;
            string placa = Placa(Placa_carro);
            TipoEstadia = Estadia(TipoDeEstadia);
            TipoCarro = Carro(TipodeCarro);
            
            try
            {
                comandos.Adicionando(placa, TipoEstadia, TipoCarro, dataGridView1);
                //Limpando todas as escolhas da vez
                Placa_carro.Clear();
                TipoDeEstadia.SelectedIndex = -1;
                TipodeCarro.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private int Estadia(ComboBox a)
        {
            int opa;

            if (a.Text == "Diarista")
            {
                opa = 2;

            }
            else
            {
                opa = 3;

            }
            return opa;
        }
        private int Carro(ComboBox a)
        {
            int carro;

            if (a.Text == "Moto" || a.Text == "moto")
            {
                carro = 1;
            }
            else if (a.Text == "Carro" || a.Text == "carro")
            {
                carro = 2;
            }
            else if (a.Text == "Van" || a.Text == "van")
            {
                carro = 3;
            }
            else if (a.Text == "ônibus" || a.Text == "Ônibus")
            {
                carro = 4;
            }
            else
            {
                carro = 5;
            }

            return carro;
        }
        private string Placa(TextBox a)
        {
            string placa;

            placa = a.Text.ToUpper();

            if (placa.Length == 7)
            {
                placa = placa.Insert(3, "-");
            }
            if (placa.Substring(3, 1) == "-")
            {
                placa.ToUpper();
            }

            return placa;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Esse método ativa o botão de remover o veículo quando uma célula é selecionada

            Int32 selecionados = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);//Recebe o número geral de celulas selecionadas no click
            string col;
            int linha;
            if (selecionados > 0)
            {
                Remover.Enabled = true;

                for(int i = 0; i < 1; i++)
                {
                    linha = dataGridView1.SelectedCells[i].RowIndex;

                    col = dataGridView1.Rows[linha].Cells[0].Value.ToString();

                    coluna = int.Parse(col); //Esta variável é responsável por pegar o valor que foi tirado da coluna ticket que refere ao bilhete e transforma em uma 
                    //variáevl universal da classe, que será usado dentro do método enviado na hora de clicar no botão remover

                }
            }

        }

        private void PassandoMouse(object sender, EventArgs e)
        {
            Voltar.Cursor = Cursors.Hand;
            Pesquisar.Cursor = Cursors.Hand;
            Adicionar.Cursor = Cursors.Hand;
            Remover.Cursor = Cursors.Hand;
            TipodeCarro.Cursor = Cursors.Hand;
            TipoDeEstadia.Cursor = Cursors.Hand;
        }

        private void TirandoMouse(object sender, EventArgs e)
        {
            Voltar.Cursor = Cursors.Default;
            Pesquisar.Cursor = Cursors.Default;
            Adicionar.Cursor = Cursors.Default;
            Remover.Cursor = Cursors.Default;
            TipodeCarro.Cursor = Cursors.Default;
            TipoDeEstadia.Cursor = Cursors.Default;
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            comandos.BarradePesquisa(textBox1.Text, dataGridView1);
            textBox1.Text = "";
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            //clique que chama o método que irá fazer todas as operações
            try
            {
                comandos.RemovendoCarro(coluna,dataGridView1);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        
    }
}
