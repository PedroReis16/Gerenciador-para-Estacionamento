﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace Estacionamento
{
    internal class Banco
    {
        SqlConnection banco = AbrindoBanco();
        int tempo,modelo,estadia;
        string PlacaCarro,produto;
        Precos valores = new Precos();

        public static SqlConnection AbrindoBanco()
        {
            SqlConnection banco;
            string connection = @"Data Source=DESKTOP-UC14HQT;Initial Catalog=Estacionamento; User ID=sa;Password=123456";
            banco= new SqlConnection(connection);
            return banco;
        }
        public void Adicionando(string Placa,int TipoEstadia,int TipoCarro,DataGridView tabela)
        {
            SqlCommand ticket, veiculo, count, historico;
            string carro, bilhete, numero, registro, comando;

            //Converte para variáveis locais os valores que são enviados quando o método é chamado
            string placa = Placa;
            int estadia = TipoEstadia;
            int modelo = TipoCarro;

            //Comandos que serão utilizados para adicionar o carro
            numero = "select top(1) COD_Registro from Historico_diario Order by COD_Registro desc"; //Gera o id dos tickets e do Historico
            carro = $"insert into Automoveis(Placa_carro,TipoCarro,COD_Estadia,DataEntrada)values(@Placa_carro,@TipoCarro,@COD_estadia,@DataEntrada)"; //Insere dentro da tabela Veiculos
            registro = $"insert into Historico_diario(COD_Registro,Placa_carro,Data_entrada)values(@COD_Registro,@Placa_carro,@Data_entrada)"; //Insere dentro da tabela Historico Diario
            bilhete = $"insert into Bilhete(COD_ticket,COD_Registro,Placa_carro,DataEntrada)values(@COD_ticket,@COD_Registro,@Placa_carro,@DataEntrada)"; //Insere dentre da tabela ticket

            comando = "select * from Bilhete";//Comando que irá atualizar a tabela ao final ao clicar em adicionar

            try
            {
                banco.Open();

                //Gerando o id do bilhete
                count = new SqlCommand(numero, banco);
                Int32 id = (Int32)count.ExecuteScalar();
                
                //Esse comando reconhece que se o número de itens na tabela for igual a 0, ele irá iniciar a contagem do 1, caso contrário a váriavel id terá o valor de origem
                if(id == 0 )
                {
                    id = 1;
                }
                else if(id>0) 
                {
                    id = id;
                }

                //adicionando na tabela veiculos
                veiculo = new SqlCommand(carro, banco);

                veiculo.Parameters.AddWithValue("@Placa_carro", placa);
                veiculo.Parameters.AddWithValue("@TipoCarro", TipoCarro);
                veiculo.Parameters.AddWithValue("@COD_estadia", TipoEstadia);
                veiculo.Parameters.AddWithValue("@DataEntrada", DateTime.Now);
                veiculo.ExecuteNonQuery();

                //adicionando na tabela Historico diario
                historico = new SqlCommand(registro, banco);

                historico.Parameters.AddWithValue("@COD_Registro", id + 1);
                historico.Parameters.AddWithValue("@Placa_carro", placa);
                historico.Parameters.AddWithValue("@Data_entrada", DateTime.Now);
                historico.ExecuteNonQuery();

                //adicionando na tabela ticket
                ticket = new SqlCommand(bilhete, banco);

                ticket.Parameters.AddWithValue("@COD_ticket", id + 1);
                ticket.Parameters.AddWithValue("@COD_Registro", id + 1);
                ticket.Parameters.AddWithValue("@Placa_carro", placa);
                ticket.Parameters.AddWithValue("@DataEntrada", DateTime.Now);
                ticket.ExecuteNonQuery();

                banco.Close();

                //Chama o método que atualiza a tabela de estacionados
                TabelaEstacionados(tabela);

                MessageBox.Show("Carro adicionado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void TabelaEstacionados(DataGridView tabela)
        {
            //Atualiza o datagridview dos carros estacionados no momento
            
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            DataGridView dataGridView1 = tabela;
            string comando = "select * from bilhete";


            try
            {
                banco.Open();

                adapter = new SqlDataAdapter(comando, banco);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                banco.Close();
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
        private int NumeroVagas()
        {
            //Esse método tem como função pega a quantidade de carros que estão estacionados no momento
            //Dependendo da quantidade, habilita ou não o para adicionar um novo veiculo

            SqlCommand bike, car, furgao, bus, truck;

            string moto, carro, van, onibus, caminhao;
            int[] total = new int[1];
            int ocupadas;

            //Quantidade de motos
            moto = "select count(Tipo_carro) from Veiculos where Tipo_carro = 1";

            //Quantidade carro
            carro = "select count(Tipo_carro) from Veiculos where Tipo_carro = 2";

            //Quantidade van
            van = "select count(Tipo_carro) from Veiculos where Tipo_carro = 3";

            //Quantidade ônibus
            onibus = "select count(Tipo_carro) from Veiculos where Tipo_carro = 4";

            //Quantidade caminhão
            caminhao = "select count(Tipo_carro) from Veiculos where Tipo_carro = 5";

            banco.Open();

            //numero de motos
            bike = new SqlCommand(moto, banco);
            Int32 motocicleta = (Int32)bike.ExecuteScalar();

            //numero de carro
            car = new SqlCommand(carro, banco);
            Int32 coche = (Int32)car.ExecuteScalar();

            //numero de van
            furgao = new SqlCommand(van, banco);
            Int32 camioneta = (Int32)furgao.ExecuteScalar();

            //numero de ônibus
            bus = new SqlCommand(onibus, banco);
            Int32 buseta = (Int32)bus.ExecuteScalar();

            //numero de caminhão
            truck = new SqlCommand(caminhao, banco);
            Int32 carga = (Int32)truck.ExecuteScalar();

            banco.Close();

            //Parte matematica

            total[0] = 60;
            total[0] = total[0] - (1 * motocicleta) - (1 * coche) - (2 * camioneta) - (3 * buseta) - (4 * carga);

            ocupadas = total[0];

            return ocupadas;
        }
        public void RemovendoCarro(int ticket,DataGridView tabela)
        {
            SqlCommand comando;
            SqlDataAdapter adapter= new SqlDataAdapter();
            SqlDataAdapter automoveis=new SqlDataAdapter();
            SqlDataReader minutos,tipo,servico,Placacarro;
            string Hsaida, Testadia,Cestadia,Cplaca,Ctipo, Cremover,AutomoveisSaida,pagamento;
            string placa;
            double valorfinal;
            string horas;

            //Comando para o SQL
            Hsaida = @"update Historico_diario set Data_saida = @Saida where COD_Registro=@COD_Registro";//Comando que registra o horário de saida do carro a partir de um update
            AutomoveisSaida = @"update Automoveis set DataSaida=@Saida where Placa_carro = (select Placa_carro from Historico_diario where COD_Registro = @COD_Registro)";//Comando resposavel por adicionar na tabela de automoveis a hora de saida do carro
            Testadia = @"select DATEDIFF(minute,(select Data_entrada from Historico_diario where COD_Registro = @COD_Registro),@Data_saida) from Historico_diario where COD_Registro = @COD_Registro";//Comando que calcula o tempo total de estadia do carro;
            Ctipo = @"select TipoCarro from Automoveis where Placa_carro = (select Placa_carro from Historico_diario where COD_Registro = @COD_Registro)";//Comando responsável por retornar o tipo do carro que esta sendo removido a partir da placa
            Cestadia = @"select COD_Estadia from Automoveis where Placa_carro = (select Placa_carro from Historico_diario where COD_Registro = @COD_Registro)";//Comando responsável por retornar o tipo de estadia que o carro entrou a partir da placa
            Cplaca = @"select Placa_carro from Historico_diario where COD_Registro = @COD_Registro"; //Comando que retorna a placa do carro que esta sendo retirado
            Cremover = @"delete Bilhete where COD_Registro=@COD_Registro";//Comando que remove o carro da tabela bilhete
            pagamento = @"update Historico_diario set ValorPago = @Valor where COD_Registro=@COD_Registro"; //Comando que atualiza na tabela de histórico o valor que o carro que esta saindo o valor pago


            try
            {
                banco.Open();

                //Comandos que atualizam o horário de saída
                try
                {
                    comando = new SqlCommand(Hsaida, banco);

                    adapter.UpdateCommand = new SqlCommand(Hsaida, banco);

                    adapter.UpdateCommand.Parameters.AddWithValue("@Saida", DateTime.Now);
                    adapter.UpdateCommand.Parameters.AddWithValue("@COD_Registro", ticket);
                    adapter.UpdateCommand.ExecuteNonQuery();

                    comando.Dispose();
                }
                catch(Exception horario)
                {
                    Console.WriteLine("Horario ERRO: {0}",horario.Message);
                }

                //comando que atualiza na tabela automoveis a saida
                try
                {
                    comando = new SqlCommand(AutomoveisSaida, banco);
                    automoveis.UpdateCommand = new SqlCommand(AutomoveisSaida, banco);

                    automoveis.UpdateCommand.Parameters.AddWithValue("@Saida", DateTime.Now);
                    automoveis.UpdateCommand.Parameters.AddWithValue("@COD_Registro", ticket);
                    automoveis.UpdateCommand.ExecuteNonQuery();

                    comando.Dispose();
                }
                catch(Exception saidaAutomoveis)
                {
                    Console.WriteLine("Saida Automoveis ERRO: {0}", saidaAutomoveis.Message);
                }

                //Comando para remover da Tabela Bilhete
                try
                {
                    comando = new SqlCommand(Cremover, banco);

                    adapter.DeleteCommand = new SqlCommand(Cremover, banco);

                    adapter.DeleteCommand.Parameters.AddWithValue("@COD_Registro", ticket);
                    adapter.DeleteCommand.ExecuteNonQuery();

                    comando.Dispose();
                }
                catch(Exception BilheteRemover)
                {
                    Console.WriteLine("Bilhete remover ERRO: {0}", BilheteRemover.Message);
                }

                //Comando que calcula do tempo de estadia do carro
                try
                {
                    comando = new SqlCommand(Testadia, banco);

                    comando.Parameters.AddWithValue("@COD_Registro", ticket);
                    comando.Parameters.AddWithValue("@Data_saida", DateTime.Now);

                    minutos = comando.ExecuteReader();
                    if (minutos.Read())
                    {
                        tempo = minutos.GetInt32(0);
                    }

                    comando.Dispose();
                    minutos.Dispose();

                }
                catch (Exception CalculoTempo)
                { 
                    Console.WriteLine("Calculo Tempo ERRO: {0}", CalculoTempo.Message);
                }

                //comando que retorna o tipo do carro
                try 
                {
                    comando = new SqlCommand(Ctipo, banco);

                    comando.Parameters.AddWithValue("@COD_Registro", ticket);

                    tipo = comando.ExecuteReader();

                    while (tipo.Read())
                    {
                        modelo = tipo.GetInt32(0);
                    }

                    tipo.Close();
                    comando.Dispose();

                }
                catch(Exception CarroTipo)
                {
                    Console.WriteLine("Carro Tipo ERRO: {0}", CarroTipo.Message);
                }

                //Comando que retorna o código de estadia
                try
                {
                    comando = new SqlCommand(Cestadia, banco);

                    comando.Parameters.AddWithValue("@COD_Registro", ticket);

                    servico = comando.ExecuteReader();

                    while (servico.Read())
                    {
                        estadia = servico.GetInt32(0);
                    }

                    servico.Close();
                    comando.Dispose();
                }
                catch(Exception CarroEstadia) 
                {
                    Console.WriteLine("Carro Estadia ERRO: {0}", CarroEstadia.Message);
                }

                //Comando que retorna a placa do carro
                try
                {
                    comando = new SqlCommand(Cplaca,banco);

                    comando.Parameters.AddWithValue("@COD_Registro", ticket);

                    Placacarro= comando.ExecuteReader();

                    while(Placacarro.Read())
                    {
                        placa = Placacarro.GetString(0);
                        PlacaCarro = placa;
                    }
                    comando.Dispose();
                    Placacarro.Close();
                }
                catch(Exception placadocarro)
                {
                    Console.WriteLine("Placa do Carro ERRO:{0}", placadocarro.Message);
                }

                valorfinal = valores.Precificando(estadia,modelo,tempo,PlacaCarro);//Variável que recebe o preço que o carro pagou

                //Comando que atualiza a coluna de Valor Pago no Histórico Diario
                try
                {
                    comando = new SqlCommand(pagamento, banco);

                    adapter.UpdateCommand = new SqlCommand(pagamento,banco);

                    adapter.UpdateCommand.Parameters.AddWithValue("@Valor", valorfinal);
                    adapter.UpdateCommand.Parameters.AddWithValue("@COD_Registro", ticket);

                    adapter.UpdateCommand.ExecuteNonQuery();
                    
                    adapter.Dispose();
                    comando.Dispose();
                }
                catch(Exception AtualizandoPagamento) 
                { 
                    Console.WriteLine("Valor Pago ERRO: {0}",AtualizandoPagamento.Message);
                }

                banco.Close();

                if(estadia == 2)
                {
                    produto = "Diaria";
                }
                else if(estadia == 3)
                {
                    produto = "Diária com lavagem";
                }


                //Verificar o preço que esta saindo
                MessageBox.Show($"Valor total: R${valorfinal:0.00}");

                //metodo que atualiza a tabela de estacionados
                TabelaEstacionados(tabela);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Comandos Banco ERRO: {0}", ex.Message);
            }
        }
        public void TabelaHistorico(DataGridView tabela)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            DataGridView dataGridView1 = tabela;
            string comando = "select * from Historico_diario";

            try
            {
                banco.Open();

                adapter = new SqlDataAdapter(comando, banco);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                banco.Close();
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
        
    }
}
