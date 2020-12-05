using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using DTOL_ProjFinalDS;

namespace DAL_ProjFinalDS
{
    public static class DAL_Contato
    {
        public static string addNewContato(DTO_Contato obj_dtoContato)
        {
            DAL_Conexao myDBConnection = new DAL_Conexao();

            try
            {
                string script = "INSERT INTO tbl_contato " +
                                "   (nome_contato, telefone, email, empresa, cargo) " +
                                "VALUES " +
                                "   (@nomeContato, @telefone, @email, @empresa, @cargo);";

                MySqlCommand cmd = new MySqlCommand(script, myDBConnection.conectar());

                cmd.Parameters.AddWithValue("@nomeContato", obj_dtoContato.nomeContato);
                cmd.Parameters.AddWithValue("@telefone", obj_dtoContato.telefone);
                cmd.Parameters.AddWithValue("@email", obj_dtoContato.email);
                cmd.Parameters.AddWithValue("@empresa", obj_dtoContato.empresa);
                cmd.Parameters.AddWithValue("@cargo", obj_dtoContato.cargo);

                cmd.ExecuteNonQuery();

                return "Contato adicionado com sucesso.";
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Duplicate entry"))
                {
                    return "Não é possível adicionar dois contatos com o mesmo nome!";
                } else
                {
                    throw new Exception(ex.Message);
                }
                
            }
            finally
            {
                if (myDBConnection.conectar().State != ConnectionState.Closed)
                {
                    myDBConnection.conectar().Close();
                }
            }
        } // Fim addNewContato();

        public static string rmvContato(DTO_Contato obj_dtoContato)
        {
            DAL_Conexao myDBConnection = new DAL_Conexao();

            try
            {
                string script = "DELETE FROM tbl_contato " +
                                "WHERE nome_contato = @nomeContato;";

                MySqlCommand cmd = new MySqlCommand(script, myDBConnection.conectar());

                cmd.Parameters.AddWithValue("@nomeContato", obj_dtoContato.nomeContato);

                cmd.ExecuteNonQuery();

                return "Contato removido com sucesso!";

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

        } // Fim rmvContato();

    }
}
