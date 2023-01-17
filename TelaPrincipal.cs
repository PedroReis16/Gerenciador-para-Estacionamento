using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.LinkLabel;

namespace Estacionamento
{
    public partial class Form1 : Form
    {
        Banco comandos = new Banco();
        Thread t1,visao,historico;
        int coluna;
        public Form1()
        {
            InitializeComponent();
            comandos.TabelaEstacionados(dataGridView1);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly= true;
            Botao_remover_carro.Enabled=false;
        }

        private void Botao_Adicionar_Carro_Click(object sender, EventArgs e)
        {
            this.Close();

            t1 = new Thread(abrirForm2);
            t1.SetApartmentState(ApartmentState.MTA);
            t1.Start();
            
        }

        private void abrirForm2(object obj)
        {
            Application.Run(new NovoCarro());
        }

        private void Botao_mensalista_Click(object sender, EventArgs e)
        {
            this.Close();
            visao = new Thread(abrirForm4);
            visao.SetApartmentState(ApartmentState.STA);
            visao.Start();
        }
        private void abrirForm4(object obj)
        {
            Application.Run(new MensalistaGeral());
        }

        private void Botao_Historico_Click(object sender, EventArgs e)
        {
            this.Close();
            historico = new Thread(abrirHistorico);
            historico.SetApartmentState(ApartmentState.STA);
            historico.Start();
        }

        private void abrirHistorico(object obj)
        {
            Application.Run(new Histórico_Diaristas());
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selecionados = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);//Recebe o número geral de celulas selecionadas no click
            int linha;
            string col;

            if (selecionados > 0)
            {
                Botao_remover_carro.Enabled = true;

                for (int i = 0; i < 1; i++)
                {
                    linha = dataGridView1.SelectedCells[i].RowIndex;

                    col = dataGridView1.Rows[linha].Cells[0].Value.ToString();

                    coluna = int.Parse(col);
                }
            }
        }
        private void Botao_remover_carro_Click(object sender, EventArgs e)
        {
            try
            {
                comandos.RemovendoCarro(coluna, dataGridView1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
