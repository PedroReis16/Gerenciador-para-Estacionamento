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

        public Histórico_Diaristas()
        {
            InitializeComponent();
            banco.TabelaHistorico(dataGridView1);
            dataGridView1.ReadOnly= true;
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
        private void AdicionarMensalista_Click(object sender, EventArgs e)
        {
            //Fecha a guia de histórico e inicia o processo de abertura da guia de cadastro de Mensalista
            this.Close();
            mensalista = new Thread(abrirMensalista);
            mensalista.SetApartmentState(ApartmentState.STA);
            mensalista.Start();
        }
        private void abrirMensalista(object obj)
        {
            //Roda o comando que direciona para a guia de mensalistas
            Application.Run(new Mensalistas());
        }

    }
}
