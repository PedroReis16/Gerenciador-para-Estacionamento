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
    public partial class Mensalistas : Form
    {
        Thread t2,visao;
        public Mensalistas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(abrirForm2);
            t2.SetApartmentState(ApartmentState.MTA);
            t2.Start();
        }
        private void abrirForm2(Object obj)
        {
            Application.Run(new NovoCarro());
        }

        private void Visao_geral_Click(object sender, EventArgs e)
        {
            this.Close();
            visao = new Thread(abrirForm5);
            visao.SetApartmentState(ApartmentState.MTA);
            visao.Start();
        }
        private void abrirForm5(object obj)
        {
            Application.Run(new MensalistaGeral());
        }
    }
}
