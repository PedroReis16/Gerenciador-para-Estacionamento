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

namespace Estacionamento
{
    public partial class Histórico_Diaristas : Form
    {
        Thread voltar,adicionar,mensalista;
        Banco banco=new Banco();
        string dias=""; 
        string estadia;
        string veiculos="";
        public Histórico_Diaristas()
        {
            InitializeComponent();
            banco.TabelaHistorico(dataGridView1);
            dataGridView1.ReadOnly= true;
            dataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            LucroTotal.Text = "";
            QuantidadeVeiculos.Text = "";
            LucroTotal.Text = banco.LucroTotal(dataGridView1);
            QuantidadeVeiculos.Text = banco.QuantidadeVeiculos(dataGridView1);
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            // fecha a guia de histórico e retorna para o menu principal

            this.Close();
            voltar = new Thread(abrirForm1);
            voltar.SetApartmentState(ApartmentState.STA);
            voltar.Start();
        }
        private void abrirForm1(object obj)
        {
            //Roda o comando de voltar
            Application.Run(new Form1());
        }
        private void AdicionarCarro_Click(object sender, EventArgs e)
        {
            //Fecha a guia de histórico e inicia o processo de abertura da guia de cadastro do carro
            this.Close();
            adicionar = new Thread(abrirNovoCarro);
            adicionar.SetApartmentState(ApartmentState.MTA);
            adicionar.Start();
        }
        private void abrirNovoCarro(object obj)
        {
            //roda o comando para adicionar um novo carro
            Application.Run(new NovoCarro());
        }
        
        private void OpcoesMarcadas(object sender, EventArgs e)
        {
            string automoveis = "";

            //check box do espaço de tempo desejado para consulta
            if (Check24Horas.Checked)
            {
                dias = "24";

            }
            if (Check3Dias.Checked)
            {
                dias = "3";

            }
            if (Check7Dias.Checked)
            {
                dias = "7";
            }
            if (Check15Dias.Checked)
            {
                dias = "15";
            }
            if (Check30Dias.Checked)
            {
                dias = "30";
            }
            if (!Check24Horas.Checked && !Check3Dias.Checked && !Check7Dias.Checked && !Check15Dias.Checked && !Check30Dias.Checked)
            {
                dias = "";
            }


            //check box dos serviços
            if (Diaristas.Checked)
            {
                estadia = "2";
            }
            if (Lavagem.Checked)
            {
                estadia = "3";
            }
            if (Lavagem.Checked && Diaristas.Checked || !Lavagem.Checked && !Diaristas.Checked)
            {
                estadia = "";
            }

            //check box dos tipos de veiculos

            if (CheckMoto.Checked)
            {
                automoveis = automoveis.Insert(0, "1");
            }
            if (CheckCarro.Checked)
            {
                automoveis = automoveis.Insert(0, "2");
            }
            if (CheckVan.Checked)
            {
                automoveis = automoveis.Insert(0, "3");
            }
            if (CheckOnibus.Checked)
            {
                automoveis = automoveis.Insert(0, "4");
            }
            if (CheckCaminhao.Checked)
            {
                automoveis = automoveis.Insert(0, "5");
            }

            veiculos = automoveis;
            banco.PuxandoHistorico(dias, estadia, veiculos, dataGridView1);

            
            LucroTotal.Text=banco.LucroTotal(dataGridView1);
            QuantidadeVeiculos.Text = banco.QuantidadeVeiculos(dataGridView1);
        }
    }
}
