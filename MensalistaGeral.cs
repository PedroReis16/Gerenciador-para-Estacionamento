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
    public partial class MensalistaGeral : Form
    {
        Thread volta,adicionar;
        public MensalistaGeral()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            volta = new Thread(abrirForm1);
            volta.SetApartmentState(ApartmentState.MTA);
            volta.Start();
        }

        private void abrirForm1(object obj)
        {
            Application.Run(new Form1());
        }

        private void Adicionar_Mensalista_Click(object sender, EventArgs e)
        {
            this.Close();
            adicionar = new Thread(abrirMensalista);
            adicionar.SetApartmentState(ApartmentState.MTA);
            adicionar.Start();
        }
        private void abrirMensalista(object obj)
        {
            Application.Run(new Mensalistas());
        }
    }
    
}
