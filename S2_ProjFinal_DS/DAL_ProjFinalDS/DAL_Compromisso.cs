using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;       // Driver de conexão MySQL x VS Studio 2019.
using DTOL_ProjFinalDS;
using System.Data.SqlClient;
using System.Xml;
using System.Net.NetworkInformation;

namespace DAL_ProjFinalDS
{
    public static class DAL_Compromisso
    {

        public static string removerCompromisso(DTO_Compromisso obj_dtoCompromisso)
        {
            DAL_Conexao myDBConnection = new DAL_Conexao();

            try
            {
                string script = "DELETE FROM tbl_compromisso " +
                                "WHERE cod_compromisso = @codCompromisso;";

                MySqlCommand cmd = new MySqlCommand(script, myDBConnection.conectar());

                cmd.Parameters.AddWithValue("@codCompromisso", obj_dtoCompromisso.codCompromisso);

                cmd.ExecuteNonQuery();

                return "Compromisso removido com sucesso!";

            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (myDBConnection.conectar().State != ConnectionState.Closed)
                {
                    myDBConnection.conectar().Close();
                }
            }


        }   // Fim removerCompromisso();

        public static List<DTO_Convidado> listarConvidados(DTO_Compromisso obj_dtoCompromisso)
        {

            var lista = new List<DTO_Convidado>();

            DAL_Conexao myDBConnection = new DAL_Conexao();

            try
            {
                string script = "SELECT * FROM tbl_convidado_compromisso " +
                                "WHERE cod_compromisso = @codCompromisso;";

                MySqlCommand cmd = new MySqlCommand(script, myDBConnection.conectar());

                cmd.Parameters.AddWithValue("@codCompromisso", obj_dtoCompromisso.codCompromisso);

                MySqlDataReader dados = cmd.ExecuteReader();

                //Console.WriteLine(cmd.CommandText + "\n" + obj_dtoCompromisso.codCompromisso);

                while (dados.Read())
                {
                    if (dados.HasRows)
                    {
                        lista.Add(new DTO_Convidado()
                        {
                            nomeContato = dados["nome_contato"].ToString(),
                            codCompromisso = int.Parse(dados["cod_compromisso"].ToString()),
                            estaConfirmado = bool.Parse(dados["estaConfirmado"].ToString())
                        });
                    }
                }

                return lista;

            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (myDBConnection.conectar().State != ConnectionState.Closed)
                {
                    myDBConnection.conectar().Close();
                }
            }
            

        } // Fim listarConvidados();

        public static string alterarCompromisso(DTO_Compromisso obj_dtoCompromisso)
        {
            DAL_Conexao myDBConnection = new DAL_Conexao();

            try
            {
                string script = "UPDATE tbl_compromisso " +
                                "SET assunto = @assunto, " +
                                "    data_compromisso = @dataCompromisso, " +
                                "    horario = @horario, " +
                                "    descricao = @descricao, " +
                                "    estaAtivo = @estaAtivo " +
                                "WHERE cod_compromisso = @codCompromisso;";

                MySqlCommand cmd = new MySqlCommand(script, myDBConnection.conectar());

                cmd.Parameters.AddWithValue("@assunto", obj_dtoCompromisso.assunto);
                cmd.Parameters.AddWithValue("@dataCompromisso", obj_dtoCompromisso.dataCompromisso);
                cmd.Parameters.AddWithValue("@horario", obj_dtoCompromisso.horario);
                cmd.Parameters.AddWithValue("@descricao", obj_dtoCompromisso.descricao);
                cmd.Parameters.AddWithValue("@estaAtivo", obj_dtoCompromisso.estaAtivo);
                cmd.Parameters.AddWithValue("@codCompromisso", obj_dtoCompromisso.codCompromisso);

                cmd.ExecuteNonQuery();

                return "Compromisso Alterado!";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (myDBConnection.conectar().State != ConnectionState.Closed)
                {
                    myDBConnection.conectar().Close();
                }
            }


        } // Fim alterarCompromisso();

        public static string addNewConvidado(DTO_Convidado obj_dtoConvidado)
        {
            DAL_Conexao myDBConnection = new DAL_Conexao();

            try
            {
                string script = "INSERT INTO tbl_convidado_compromisso " +
                                "(nome_contato, cod_compromisso, estaConfirmado) " +
                                "VALUES " +
                                "(@nomeContato, @codCompromisso, DEFAULT);";

                MySqlCommand cmd = new MySqlCommand(script, myDBConnection.conectar());

                cmd.Parameters.AddWithValue("@nomeContato", obj_dtoConvidado.nomeContato);
                cmd.Parameters.AddWithValue("@codCompromisso", obj_dtoConvidado.codCompromisso);

                cmd.ExecuteNonQuery();

                return "Convidado adicionado à lista.";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (myDBConnection.conectar().State != ConnectionState.Closed)
                {
                    myDBConnection.conectar().Close();
                }
            }

        } // Fim addNewConvidado();

        public static string rmvConvidado(DTO_Convidado obj_dtoConvidado)
        {
            DAL_Conexao myDBConnection = new DAL_Conexao();

            try
            {
                string script;

                if (String.IsNullOrEmpty(obj_dtoConvidado.nomeContato))
                {
                    script = "DELETE FROM tbl_convidado_compromisso " +
                             "WHERE nome_contato = ' ' OR nome_contato IS NULL AND cod_compromisso = @codCompromisso;";
                } else
                {
                    script = "DELETE FROM tbl_convidado_compromisso " +
                             "WHERE nome_contato = @nomeContato AND cod_compromisso = @codCompromisso;";
                }

                MySqlCommand cmd = new MySqlCommand(script, myDBConnection.conectar());
                
                cmd.Parameters.AddWithValue("@nomeContato", obj_dtoConvidado.nomeContato);
                cmd.Parameters.AddWithValue("@codCompromisso", obj_dtoConvidado.codCompromisso);

                cmd.ExecuteNonQuery();

                return "Convidado removido da lista.";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (myDBConnection.conectar().State != ConnectionState.Closed)
                {
                    myDBConnection.conectar().Close();
                }
            }

        } // Fim rmvConvidado();

        public static string addNewCompromisso(DTO_Compromisso obj_dtoCompromisso)
        {
            DAL_Conexao myDBConnection = new DAL_Conexao();

            try
            {
                string script = "INSERT INTO tbl_compromisso " +
                                "   (cod_compromisso, assunto, data_compromisso, horario, descricao, estaAtivo) " +
                                "VALUES " +
                                "   (DEFAULT, @assunto, @dataCompromisso, @horario, @descricao, @estaAtivo);";

                MySqlCommand cmd = new MySqlCommand(script, myDBConnection.conectar());

                cmd.Parameters.AddWithValue("@assunto", obj_dtoCompromisso.assunto);
                cmd.Parameters.AddWithValue("@dataCompromisso", obj_dtoCompromisso.dataCompromisso);
                cmd.Parameters.AddWithValue("@horario", obj_dtoCompromisso.horario);
                cmd.Parameters.AddWithValue("@descricao", obj_dtoCompromisso.descricao);
                cmd.Parameters.AddWithValue("@estaAtivo", obj_dtoCompromisso.estaAtivo);

                cmd.ExecuteNonQuery();

                return "Compromisso criado com sucesso.";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (myDBConnection.conectar().State != ConnectionState.Closed)
                {
                    myDBConnection.conectar().Close();
                }
            }

        }

    } // Fim da classe.
}
