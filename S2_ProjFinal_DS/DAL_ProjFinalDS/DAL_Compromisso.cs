using DTOL_ProjFinalDS;
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
            // Todo ...
            return "Compromisso Alterado!";

        } // Fim alterarCompromisso();


    } // Fim da classe.
}
