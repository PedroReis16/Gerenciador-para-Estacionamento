using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    internal class Precos
    {
        int PrecoLavagem, PrecoInicial;
        double ValorFinal;
        public double Precificando(int estadia,int modelo, int minutos,string placa)
        {
            double valorfinal; 

            try
            {
                switch (estadia)
                {
                    case 2://diaria
                        switch (modelo)
                        {
                            case 1:
                                ValorFinal = 2.0 + ((minutos / 60) * 2.5);
                                break;
                            case 2:
                                ValorFinal = 4.0 + ((minutos / 60) * 2.5);
                                break; 
                            case 3:
                                ValorFinal = 8.0 + ((minutos / 60) * 2.5);
                                break; 
                            case 4:
                                ValorFinal = 12.0 + ((minutos / 60) * 2.5);
                                break;
                            case 5:
                                ValorFinal = 16.0 + ((minutos / 60) * 2.5);
                                break;
                        }
                        break;

                    case 3://diaria+lavagem
                        switch (modelo)
                        {
                            case 1:
                                ValorFinal = 2.0 + ((minutos / 60) * 2.5) + 10.0;
                                break;
                            case 2:
                                ValorFinal = 4.0 + ((minutos / 60) * 2.5) + 20.0;
                                break;
                            case 3:
                                ValorFinal = 8.0 + ((minutos / 60) * 2.5) + 30.0;
                                break;
                            case 4:
                                ValorFinal = 12.0 + ((minutos / 60) * 2.5) + 60.0;
                                break;
                            case 5:
                                ValorFinal = 16.0 + ((minutos / 60) * 2.5) + 80.0;
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Precificando ERRO: {0}", ex.Message);
            }
            valorfinal = ValorFinal;

            return valorfinal;
        }
    }
}
