using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Classes
{
    class Conexao
    {
        string path = "Server=127.0.0.1;DATABASE=partynerdb;UID=root;PWD=;convert zero datetime=True;Character Set=utf8";
        private MySqlConnection conexao;
        private MySqlCommand comandoSql;

        //Login------------------------------------------------------------
        public DataTable ShowUsuarios() 
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("Select * from Usuario", conexao);
                conexao.Open();
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public bool IsAdmin(string usuario, string senha)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("select admin_usuario from usuario where senha = @senha and id_usuario = @usuario", conexao);
                comandoSql.Parameters.AddWithValue("@senha", senha);
                comandoSql.Parameters.AddWithValue("@usuario", usuario);
                conexao.Open();
                bool isAdmin = (bool)comandoSql.ExecuteScalar();

                return isAdmin;
            }
            catch (Exception error) 
            {
                throw error;
            }
        }

        public int FazerLogin(string usuario, string senha)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("select * from usuario where senha = @senha and id_usuario = @usuario", conexao);
                comandoSql.Parameters.AddWithValue("@senha", senha);
                comandoSql.Parameters.AddWithValue("@usuario", usuario);
                conexao.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);
                int row = dt.Rows.Count;

                return row;
            }
            catch (Exception error)
            {

                throw error;
            }
        }

        //Evento------------------------------------------------------------

        public DataTable ShowLucros() 
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("select data_evento, valor_total - custos as 'valor total' from eventos order by data_evento", conexao);
                conexao.Open();
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);
                int qtdRows = dt.Rows.Count;

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public bool CadEventos(Evento evento) 
        {
            double valorTotal;
            try
            {
                conexao = new MySqlConnection(path);
                //Inserindo Evento no banco de Dados
                comandoSql = new MySqlCommand("call cad_eve(@dta_Evento , @descricao , 0 , 0 , @nmc, @idCli, @idtipo)", conexao);
                comandoSql.Parameters.AddWithValue("@dta_Evento", evento.DataEvento);
                comandoSql.Parameters.AddWithValue("@descricao", evento.Descricao);
                comandoSql.Parameters.AddWithValue("@idCli", evento.IdCliente);
                comandoSql.Parameters.AddWithValue("@idTipo", evento.IdTipo);
                comandoSql.Parameters.AddWithValue("@nmc", evento.NMC);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                conexao.Close();
                //Buscando o ultimo evento registrado no Banco de Dados
                comandoSql = new MySqlCommand("select * from eventos e join tipo t on e.id_tipo_fk = t.id_tipo order by id_evento desc limit 1", conexao);
                DataTable dt = new DataTable();
                conexao.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);
                string idEvento = dt.Rows[0]["id_evento"].ToString();//Esta variavel recebe o id do último evento registrado;
                decimal preco = (decimal)dt.Rows[0]["preco"];//Esta variável receve o valor do preço do tipo do evento (evento join tipo);
                valorTotal = double.Parse(preco.ToString()) * evento.NMC;//Calculando Preço total que o cliente terá que pagar

                conexao.Close();
                comandoSql = new MySqlCommand("update eventos set valor_Total = @valorTotal where id_evento = @idEvento", conexao);
                comandoSql.Parameters.AddWithValue("@valorTotal", valorTotal);
                comandoSql.Parameters.AddWithValue("@idEvento", idEvento);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception error)
            {
                throw error;
                return false;
            }
        }

        public bool UpEventos(Evento evento)
        {
            double preco = 0, Adicionais = 0;
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("update eventos set data_evento = @dta_Evento, descricao = @descricao, id_Cliente_fk = @idCliente, id_tipo_fk = @idTipo,num_conv = @nmc where id_evento = @idEvento", conexao);
                comandoSql.Parameters.AddWithValue("@dta_Evento", evento.DataEvento);
                comandoSql.Parameters.AddWithValue("@descricao", evento.Descricao);
                comandoSql.Parameters.AddWithValue("@idCliente", evento.IdCliente);
                comandoSql.Parameters.AddWithValue("@nmc", evento.NMC);
                comandoSql.Parameters.AddWithValue("@idTipo", evento.IdTipo);
                comandoSql.Parameters.AddWithValue("@idEvento", evento.Id_evento);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                conexao.Close();
                comandoSql = new MySqlCommand("select * from eventos e join ad_evento ae join Adicionais p on e.id_evento = ae.id_evento_fk and ae.id_adicionais_fk = p.id_adicional where id_evento = @evento", conexao);
                comandoSql.Parameters.AddWithValue("@evento", evento.Id_evento);
                DataTable dt = new DataTable();
                conexao.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Adicionais += double.Parse(dt.Rows[i]["preco"].ToString());
                }

                conexao.Close();
                comandoSql = new MySqlCommand("select * from eventos e join tipo t on e.id_tipo_fk = t.id_tipo where id_evento = @evento", conexao);
                comandoSql.Parameters.AddWithValue("@evento", evento.Id_evento);
                dt = new DataTable();
                conexao.Open();
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);
                preco += double.Parse(dt.Rows[0]["preco"].ToString());
                double valorTotal = (double.Parse(preco.ToString()) * evento.NMC) + Adicionais;

                conexao.Close();
                comandoSql = new MySqlCommand("update eventos set valor_Total = @valorTotal where id_evento = @idEvento", conexao);
                comandoSql.Parameters.AddWithValue("@valorTotal", valorTotal);
                comandoSql.Parameters.AddWithValue("@idEvento", evento.Id_evento);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }

        public bool DelEventos(string idEvento) 
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("delete from eventos where id_evento = @idEvento",conexao);
                comandoSql.Parameters.AddWithValue("@idEvento", idEvento);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception) 
            {
                return false;
            }
        }

        public void CalcularLucro(int idEvento) 
        {
            try
            {
                double custos = 0;
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("select * from eventos e join Funcionario_Evento fe join funcionarios f on e.id_evento = fe.id_evento_fk and fe.id_funcionario_fk = f.id_funcionario where id_evento = @Evento", conexao);
                comandoSql.Parameters.AddWithValue("@Evento", idEvento);
                conexao.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    custos += double.Parse(dt.Rows[i]["pagamento"].ToString());//Recebe o valor de pagamento de todos os funcionários, realizando  uma somatória na variável custos
                }

                conexao.Close();
                comandoSql = new MySqlCommand("select * from eventos e join produto_evento pe join Produtos p on e.id_evento = pe.id_evento_fk and pe.id_produto_fk = p.id_produto where id_evento = @Evento", conexao);
                comandoSql.Parameters.AddWithValue("@Evento", idEvento);
                conexao.Open();
                dt = new DataTable();
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int qtd = int.Parse(dt.Rows[i]["qtd"].ToString());//Recebendo a quantidade de cada produto e multiplicando pelo seu preço para gerar o preço total em custos
                    custos += double.Parse(dt.Rows[i]["preco"].ToString()) * qtd;
                }

                conexao.Close();
                comandoSql = new MySqlCommand("update eventos set custos = @custos where id_evento = @idEvento", conexao);
                comandoSql.Parameters.AddWithValue("@custos", custos);
                comandoSql.Parameters.AddWithValue("@idEvento", idEvento);
                conexao.Open();
                comandoSql.ExecuteNonQuery();
            }
            catch (Exception error) 
            {
                throw error;
            }
        }

        public bool CadEventosAdicionais(string idEvento, string idAdicionais)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("insert into ad_evento values(null,@idAdicionais,@idEvento)");
                comandoSql.Parameters.AddWithValue("@idAdicionais", idAdicionais);
                comandoSql.Parameters.AddWithValue("@idEvento", idEvento);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable ShowEvento() 
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("Select id_evento as 'Id', descricao as 'Descrição',data_evento as 'Data do Evento', valor_Total as 'Valor total', num_conv as 'Qtd de convidados',e.id_Cliente_fk as 'IdCliente', c.nome as 'Cliente', t.nome as 'Tipo do evento', t.id_tipo from Eventos e join Tipo t join Clientes c on e.id_Tipo_fk = t.id_Tipo and c.id_cliente = e.id_cliente_fk", conexao);
                conexao.Open();
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);
                
                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DataTable PesquisaEvento(int tipo, string pesquisa)
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                switch (tipo)
                {
                    case 0:
                        comandoSql = new MySqlCommand("Select id_evento as 'Id', concat(descricao,'; ',date_format(data_evento, '%d/%m/%Y')) as 'Descrição',data_evento as 'Data do Evento', valor_Total as 'Valor total', num_conv as 'Qtd de convidados',e.id_Cliente_fk as 'IdCliente', c.nome as 'Cliente', t.nome as 'Tipo do evento', t.id_tipo from Eventos e join Tipo t join Clientes c on e.id_Tipo_fk = t.id_Tipo and c.id_cliente = e.id_cliente_fk where descricao like @pesquisa", conexao);
                        comandoSql.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");
                        break;
                    case 1:
                        double valor;
                        if (double.TryParse(pesquisa, out valor))
                        {
                            comandoSql = new MySqlCommand("Select id_evento as 'Id', concat(descricao,'; ',date_format(data_evento, '%d/%m/%Y')) as 'Descrição',data_evento as 'Data do Evento', valor_Total as 'Valor total', num_conv as 'Qtd de convidados',e.id_Cliente_fk as 'IdCliente', c.nome as 'Cliente', t.nome as 'Tipo do evento', t.id_tipo from Eventos e join Tipo t join Clientes c on e.id_Tipo_fk = t.id_Tipo and c.id_cliente = e.id_cliente_fk where valor_total like @pesquisa", conexao);
                            comandoSql.Parameters.AddWithValue("@pesquisa", valor + "%");
                        }
                        else 
                        {
                            comandoSql = new MySqlCommand("Select id_evento as 'Id', concat(descricao,'; ',date_format(data_evento, '%d/%m/%Y)) as 'Descrição',data_evento as 'Data do Evento', valor_Total as 'Valor total', num_conv as 'Qtd de convidados',e.id_Cliente_fk as 'IdCliente', c.nome as 'Cliente', t.nome as 'Tipo do evento', t.id_tipo from Eventos e join Tipo t join Clientes c on e.id_Tipo_fk = t.id_Tipo and c.id_cliente = e.id_cliente_fk", conexao);
                        }
                        break;
                    case 2:
                        comandoSql = new MySqlCommand("Select id_evento as 'Id', concat(descricao,'; ',date_format(data_evento, '%d/%m/%Y')) as 'Descrição',data_evento as 'Data do Evento', valor_Total as 'Valor total', num_conv as 'Qtd de convidados',e.id_Cliente_fk as 'IdCliente', c.nome as 'Cliente', t.nome as 'Tipo do evento', t.id_tipo from Eventos e join Tipo t join Clientes c on e.id_Tipo_fk = t.id_Tipo and c.id_cliente = e.id_cliente_fk where c.nome like @pesquisa", conexao);
                        comandoSql.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");
                        break;
                    default:
                        comandoSql = new MySqlCommand("Select id_evento as 'Id', concat(descricao,'; ',date_format(data_evento, '%d/%m/%Y')) as 'Descrição',data_evento as 'Data do Evento', valor_Total as 'Valor total', num_conv as 'Qtd de convidados',e.id_Cliente_fk as 'IdCliente', c.nome as 'Cliente', t.nome as 'Tipo do evento', t.id_tipo from Eventos e join Tipo t join Clientes c on e.id_Tipo_fk = t.id_Tipo and c.id_cliente = e.id_cliente_fk", conexao);
                        break;
                }
                conexao.Open();
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        //Convidado---------------------------------------------------------
        public DataTable ShowConvidados()
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("Select id_convidado as Id,nome, e.id_evento, e.descricao as 'descrição' from Convidados c join eventos e on idEvento_fk = id_evento", conexao);
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DataTable PesquisaConvidados(string pesquisa)
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("Select * from Convidados where nome like @pesquisa", conexao);
                comandoSql.Parameters.AddWithValue("@pesquisa", pesquisa + "%");
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DataTable ListConvidados(string evento)
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("Select id_convidado, nome from Convidados where idEvento_fk = @evento and presenca = false", conexao);
                comandoSql.Parameters.AddWithValue("@evento", evento);
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DataTable ListConvidadosPresentes(string evento)
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("Select id_convidado, nome from Convidados where idEvento_fk = @evento and presenca = true", conexao);
                comandoSql.Parameters.AddWithValue("@evento", evento);
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DataTable ListConvidadosPesquisa(string evento, string pesquisa)
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("Select id_convidado, nome from Convidados where idEvento_fk = @evento and presenca = false and nome like @nome", conexao);
                comandoSql.Parameters.AddWithValue("@evento", evento);
                comandoSql.Parameters.AddWithValue("@nome", "%"+pesquisa+"%");
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DataTable ListConvidadosPresentesPesquisa(string evento, string pesquisa)
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("Select id_convidado, nome from Convidados where idEvento_fk = @evento and presenca = true and nome like @nome", conexao);
                comandoSql.Parameters.AddWithValue("@evento", evento);
                comandoSql.Parameters.AddWithValue("@nome", "%"+pesquisa+"%");
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public bool CadConvidados(Convidado conv) 
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("call cadConvidado(@nome,@idEvento,false)", conexao);
                comandoSql.Parameters.AddWithValue("@nome", conv.Nome);
                comandoSql.Parameters.AddWithValue("@idEvento", conv.IdEvento);
                conexao.Open();
                comandoSql.ExecuteNonQuery();
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpConvidados(Convidado conv)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("update convidados set nome = @nome, idEvento_fk = @idEvento where id_Convidado = @idConvidado", conexao);
                comandoSql.Parameters.AddWithValue("@nome", conv.Nome);
                comandoSql.Parameters.AddWithValue("@idEvento", conv.IdEvento);
                comandoSql.Parameters.AddWithValue("@idConvidado", conv.IdConvidado);

                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DelConvidados(Convidado conv)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("delete from convidados where id_Convidado = @idConvidado", conexao);
                comandoSql.Parameters.AddWithValue("@idConvidado", conv.IdConvidado);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void RegistrarPresenca(string id) 
        {
            conexao = new MySqlConnection(path);
            comandoSql = new MySqlCommand("update convidados set presenca = true where id_Convidado = @idConvidado", conexao);
            comandoSql.Parameters.AddWithValue("@idConvidado", id);
            conexao.Open();
            comandoSql.ExecuteNonQuery();
        }

        public void DesfazerPresenca(string id) 
        {
            conexao = new MySqlConnection(path);
            comandoSql = new MySqlCommand("update convidados set presenca = false where id_Convidado = @idConvidado", conexao);
            comandoSql.Parameters.AddWithValue("@idConvidado", id);
            conexao.Open();
            comandoSql.ExecuteNonQuery();
        }
        //Produtos-------------------------------------------------------------

        public bool CadProdEventos(string produto, string evento, int qtd)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("insert into Produto_evento values(null,@qtd,@evento,@Produto)", conexao);
                comandoSql.Parameters.AddWithValue("@evento", evento);
                comandoSql.Parameters.AddWithValue("@Produto", produto);
                comandoSql.Parameters.AddWithValue("@qtd", qtd);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable ShowProdEventos(string evento)
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("select pe.id_etp as 'Id',p.nome, qtd, preco as 'preço por unidade' from produto_evento pe join produtos p on pe.id_produto_fk = p.id_produto where id_evento_fk = @evento", conexao);
                comandoSql.Parameters.AddWithValue("@evento", evento);
                conexao.Open();
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public bool CadProdutos(Produtos prod)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("insert into Produtos values(null,@nome,@categoria,@preco)", conexao);
                comandoSql.Parameters.AddWithValue("@nome", prod.Nome);
                comandoSql.Parameters.AddWithValue("@categoria", prod.Categoria);
                comandoSql.Parameters.AddWithValue("@preco", prod.Preco);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpProdutos(Produtos prod)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("update produtos set nome = @nome, categoria = @categoria, preco = @preco where id_produto = @idProduto", conexao);
                comandoSql.Parameters.AddWithValue("@nome", prod.Nome);
                comandoSql.Parameters.AddWithValue("@categoria", prod.Categoria);
                comandoSql.Parameters.AddWithValue("@preco", prod.Preco);
                comandoSql.Parameters.AddWithValue("@idProduto", prod.IdProdutos);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DelProdutos(string idProduto)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("delete from produtos where id_produto = @idProduto", conexao);
                comandoSql.Parameters.AddWithValue("@idProduto", idProduto);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable ShowProdutos()
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("Select * from produtos", conexao);
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {

                throw error;
            }
        }

        public bool DelProdEvento(string id) 
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("delete from produto_evento where id_etp = @idProduto", conexao);
                comandoSql.Parameters.AddWithValue("@idProduto", id);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception error)
            {
                throw error;
                return false;
            }
        }
        //Clientes-------------------------------------------------------------

        public bool CadCliente(Cliente Cli)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("call cad_cli(@nomeCli,@cpf)", conexao);
                comandoSql.Parameters.AddWithValue("@nomeCli", Cli.Nome);
                comandoSql.Parameters.AddWithValue("@cpf", Cli.CPF);
                conexao.Open();

                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable ShowClientes() 
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("select id_Cliente as id, nome, cpf from Clientes", conexao);
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public bool UpCliente(Cliente Cli) 
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("call up_cli(@idCli,@nomeCli,@cpf)", conexao);
                comandoSql.Parameters.AddWithValue("@nomeCli", Cli.Nome);
                comandoSql.Parameters.AddWithValue("@cpf", Cli.CPF);

                comandoSql.Parameters.AddWithValue("@idCli", Cli.IdCliente);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DelCliente(Cliente cli) 
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("delete from clientes where id_Cliente = @idCliente", conexao);
                comandoSql.Parameters.AddWithValue("@idCliente", cli.IdCliente);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable pesquisaCliente(string pesquisa, int tipo) 
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                switch (tipo) 
                {
                    case 0:
                        comandoSql = new MySqlCommand("select id_Cliente as id, nome, cpf from Clientes where nome like @pesquisa", conexao);
                        comandoSql.Parameters.AddWithValue("@pesquisa", "%"+pesquisa+"%");
                        break;
                    case 1:
                        comandoSql = new MySqlCommand("select id_Cliente as id, nome, cpf from Clientes where cpf like @pesquisa", conexao);
                        comandoSql.Parameters.AddWithValue("@pesquisa", "%"+pesquisa+"%");
                        break;
                    default:
                        ShowClientes();
                        break;
                }
                
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        //Tipo---------------------------------------------------------------
        public bool CadTipos(Tipo tipo)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("insert into tipo values(null,@nome,@preco)", conexao);
                comandoSql.Parameters.AddWithValue("@nome", tipo.Nome);
                comandoSql.Parameters.AddWithValue("@preco", tipo.Preco);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public bool UpTipos(Tipo tipo)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("Update tipo set nome = @nome, preco = @preco where id_tipo = @idTipo", conexao);
                comandoSql.Parameters.AddWithValue("@nome", tipo.Nome);
                comandoSql.Parameters.AddWithValue("@preco", tipo.Preco);
                comandoSql.Parameters.AddWithValue("@idTipo", tipo.Id_tipo);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public bool DelTipos(string idTipo)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("Delete from tipo where id_tipo = @idtipo", conexao);
                comandoSql.Parameters.AddWithValue("idTipo", idTipo);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DataTable PesquisaTipos(string pesquisa, int tipo)
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                switch (tipo)
                {
                    case 0:
                        comandoSql = new MySqlCommand("Select * from tipo where nome like @pesquisa", conexao);
                        comandoSql.Parameters.AddWithValue("@pesquisa", "%"+pesquisa + "%");
                        break;
                    case 1:
                        double valor;
                        if (double.TryParse(pesquisa, out valor))
                        {
                            comandoSql = new MySqlCommand("Select * from tipo where preco like @pesquisa", conexao);
                            comandoSql.Parameters.AddWithValue("@pesquisa", valor + "%");
                        }
                        else
                        {
                            comandoSql = new MySqlCommand("Select * from tipo", conexao);
                        }
                        break;
                    default:
                        comandoSql = new MySqlCommand("Select * from tipo", conexao);
                        break;
                }
                conexao.Open();
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DataTable ShowTipos() 
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("select * from tipo", conexao);
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        //Adicionais---------------------------------------------------------

        public bool CadAdEvento(string adicional, string evento) 
        {
            double preco = 0;
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("insert into ad_evento values(null,@adicional,@evento)", conexao);
                comandoSql.Parameters.AddWithValue("@adicional", adicional);
                comandoSql.Parameters.AddWithValue("@evento", evento);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                conexao.Close();
                //Selecionando o último adicional registrado na tabela para somar o preço do adicional com o valor_total de eventos
                comandoSql = new MySqlCommand("select * from adicionais a join ad_evento ae join eventos e on a.id_adicional = ae.id_adicionais_fk and ae.id_evento_fk = e.id_evento order by id_eta desc limit 1", conexao);
                comandoSql.Parameters.AddWithValue("@evento", evento);
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                preco += double.Parse(dt.Rows[0]["preco"].ToString());//Recebendo preço de adicional

                double valorTotal = double.Parse(dt.Rows[0]["Valor_total"].ToString());
                valorTotal += double.Parse(preco.ToString());

                conexao.Close();
                comandoSql = new MySqlCommand("update eventos set valor_total = @valorTotal where id_evento = @evento", conexao);
                comandoSql.Parameters.AddWithValue("@valorTotal", valorTotal);
                comandoSql.Parameters.AddWithValue("@evento", evento);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }

        public bool DelAdEvento(string eta, string evento) 
        {
            try
            {
                double preco = 0;
                comandoSql = new MySqlCommand("select * from adicionais a join ad_evento ae join eventos e on a.id_adicional = ae.id_adicionais_fk and ae.id_evento_fk = e.id_evento where id_eta = @AdEvento", conexao);
                comandoSql.Parameters.AddWithValue("@adEvento", eta);
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);
                preco += double.Parse(dt.Rows[0]["preco"].ToString());//Recebendo preço de adicional

                double valorTotal = double.Parse(dt.Rows[0]["Valor_total"].ToString());
                valorTotal -= double.Parse(preco.ToString());//Subtraindo do valor total o preço do adicional registrado

                conexao.Close();
                comandoSql = new MySqlCommand("update eventos set valor_total = @valorTotal where id_evento = @evento", conexao);
                comandoSql.Parameters.AddWithValue("@valorTotal", valorTotal);
                comandoSql.Parameters.AddWithValue("@evento", evento);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                conexao.Close();
                comandoSql = new MySqlCommand("delete from ad_evento where id_eta = @eta", conexao);
                comandoSql.Parameters.AddWithValue("@eta", eta);
                conexao.Open();
                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception error)
            {
                throw error;
                return false;
            }
        }

        public DataTable ShowAdEvento(string evento)
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("select id_eta as 'Id',Nome, preco as 'Preço' from Adicionais a join ad_evento ae join eventos e on a.id_adicional = ae.id_adicionais_fk and ae.id_evento_fk = e.id_evento where e.id_evento = @evento", conexao);
                comandoSql.Parameters.AddWithValue("@evento", evento);
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public bool CadAdicionais(Adicionais adicionais)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("insert into Adicionais values(null,@nome,@preco)", conexao);
                comandoSql.Parameters.AddWithValue("@nome", adicionais.Nome);
                comandoSql.Parameters.AddWithValue("@preco", adicionais.Preco);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable ShowAdicionais() 
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("Select * from adicionais", conexao);
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DataTable PesquisaAdicionais(string pesquisa, int tipo)
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                switch (tipo)
                {
                    case 0:
                        comandoSql = new MySqlCommand("Select * from adicionais where nome like @pesquisa", conexao);
                        comandoSql.Parameters.AddWithValue("@pesquisa", "%"+pesquisa+"%");
                        break;
                    case 1:
                        double valor;
                        if (double.TryParse(pesquisa, out valor))
                        {
                            comandoSql = new MySqlCommand("Select * from adicionais where preco like @pesquisa", conexao);
                            comandoSql.Parameters.AddWithValue("@pesquisa", valor + "%");
                        }
                        else 
                        {
                            comandoSql = new MySqlCommand("Select * from adicionais", conexao);
                        }
                        break;
                    default:
                        comandoSql = new MySqlCommand("Select * from adicionais",conexao);
                        break;
                }
                conexao.Open();
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public bool DelAdicionais(string idAdicional) 
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("delete from Adicionais where id_adicional = @adicional", conexao);
                comandoSql.Parameters.AddWithValue("@adicional", idAdicional);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpAdicionais(Adicionais adicionais) 
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("update Adicionais set nome = @nome, preco = @preco where id_Adicional = @adicional", conexao);
                comandoSql.Parameters.AddWithValue("@nome", adicionais.Nome);
                comandoSql.Parameters.AddWithValue("@preco", adicionais.Preco);
                comandoSql.Parameters.AddWithValue("@adicional", adicionais.Id_Adicionais);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }

        //Funcionario-------------------------------------------------------

        public bool CadFuncionario(Funcionario func) 
        {
            try
            {
                conexao = new MySqlConnection(path);

                comandoSql = new MySqlCommand("call cadFuncionario(@nome, @cpf, @rg, @telefone ,@endereco)", conexao);
                comandoSql.Parameters.AddWithValue("@nome", func.Nome);
                comandoSql.Parameters.AddWithValue("@cpf", func.Cpf);
                comandoSql.Parameters.AddWithValue("@rg", func.Rg);
                comandoSql.Parameters.AddWithValue("@telefone", func.Telefone);
                comandoSql.Parameters.AddWithValue("@endereco", func.Endereco);

                conexao.Open();

                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception error)
            {
                throw error;
                return false;
            }
        }

        public bool CadFuncEvento(string funcionario, double Pagamento ,string evento)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("insert into funcionario_evento values (@evento,@funcionario,@pagamento)", conexao);
                comandoSql.Parameters.AddWithValue("@funcionario", funcionario);
                comandoSql.Parameters.AddWithValue("@evento", evento);
                comandoSql.Parameters.AddWithValue("@pagamento", Pagamento);
                conexao.Open();
                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception error)
            {
                //throw error;
                return false;
            }
        }

        public bool DelFuncEvento(string funcionario)
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("Delete from Funcionario_Evento where id_funcionario_fk = @funcionario", conexao);
                comandoSql.Parameters.AddWithValue("@funcionario", funcionario);
                conexao.Open();
                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception error)
            {
                //throw error;
                return false;
            }
        }

        public DataTable ShowFuncEvento(string evento)
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("select id_Funcionario as 'Id',f.nome, pagamento from funcionario_evento fe join funcionarios f join eventos e on fe.id_funcionario_fk = f.id_funcionario and fe.id_evento_fk = e.id_evento where e.id_evento = @evento", conexao);
                comandoSql.Parameters.AddWithValue("@evento", evento);
                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DataTable ShowFuncionario() 
        {
            try
            {
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("select * from Funcionarios", conexao);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {

                throw error;
            }
        }

        public DataTable PesquisaFunc(string pesquisa, int tipo)
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                switch (tipo)
                {
                    case 0:
                        comandoSql = new MySqlCommand("Select * from Funcionarios where nome like @pesquisa", conexao);
                        comandoSql.Parameters.AddWithValue("@pesquisa", pesquisa + "%");
                        break;
                    case 1:
                        comandoSql = new MySqlCommand("Select * from Funcionarios where cpf like @pesquisa", conexao);
                        comandoSql.Parameters.AddWithValue("@pesquisa", pesquisa + "%");
                        break;
                    case 2:
                        comandoSql = new MySqlCommand("Select * from Funcionarios where rg like @pesquisa", conexao);
                        comandoSql.Parameters.AddWithValue("@pesquisa", pesquisa + "%");
                        break;
                    case 3:
                        comandoSql = new MySqlCommand("Select * from Funcionarios where endereco like @pesquisa", conexao);
                        comandoSql.Parameters.AddWithValue("@pesquisa", pesquisa + "%");
                        break;
                    case 4:
                        comandoSql = new MySqlCommand("Select * from Funcionarios where telefone like @pesquisa", conexao);
                        comandoSql.Parameters.AddWithValue("@pesquisa", pesquisa + "%");
                        break;
                    default:
                        ShowFuncionario();
                        break;
                }

                adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public bool UpFuncionario(Funcionario func) 
        {
            try
            {
                conexao = new MySqlConnection(path);

                comandoSql = new MySqlCommand("call up_fun(@idFunc,@nome,@cpf,@rg,@telefone,@endereco)", conexao);
                comandoSql.Parameters.AddWithValue("@nome", func.Nome);
                comandoSql.Parameters.AddWithValue("@cpf", func.Cpf);
                comandoSql.Parameters.AddWithValue("@rg", func.Rg);
                comandoSql.Parameters.AddWithValue("@telefone", func.Telefone);
                comandoSql.Parameters.AddWithValue("@endereco", func.Endereco);
                comandoSql.Parameters.AddWithValue("@idFunc", func.Id_Funcionario);
                conexao.Open();

                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception error)
            {
                throw error;
                return false;
            }
        }

        public bool DelFuncionario(Funcionario func) 
        {
            try
            {
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("call d_fun(@id_func)",conexao);
                comandoSql.Parameters.AddWithValue("@id_func", func.Id_Funcionario);
                conexao.Open();
                comandoSql.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        
        }

        public DataTable showcont()
        {
            try
            {
                DataTable dt = new DataTable();
                conexao = new MySqlConnection(path);
                comandoSql = new MySqlCommand("SELECT descricao,c.nome as 'Cliente' ,valor_Total, num_conv, t.nome as 'Tipo do Evento', data_evento as 'Data do Evento'from  Eventos e join tipo t join Clientes c on e.id_Tipo_fk = t.id_tipo and c.id_cliente = e.id_cliente_fk ", conexao);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSql);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception error)
            {
                throw error;
            }


        }
    }
}
