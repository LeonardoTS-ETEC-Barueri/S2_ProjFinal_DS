using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_ProjFinalDS;
using DTOL_ProjFinalDS;

namespace BLL_ProjFinalDS
{
    public class BLL_Contato
    {

        public string validarAddNewContato(DTO_Contato obj_dtoContato)
        {
            obj_dtoContato.nomeContato.Trim();
            obj_dtoContato.email.Trim();
            obj_dtoContato.empresa.Trim();
            obj_dtoContato.cargo.Trim();

            if (String.IsNullOrEmpty(obj_dtoContato.nomeContato))
            {
                return ("O nome do contato não pode ser vazio.");
            }
            if (obj_dtoContato.nomeContato.Length > 100)
            {
                return ("O nome do contato pode ter no máximo 100 caracteres.");
            }
            if (String.IsNullOrEmpty(obj_dtoContato.telefone))
            {
                return ("O telefone do contato está vazio!");
            }
            if (obj_dtoContato.telefone.Any(char.IsLetter))
            {
                return ("Telefone inválido, digite apenas números!");
            }
            if (obj_dtoContato.telefone.Length > 20 || obj_dtoContato.telefone.Length < 11)
            {
                return ("Número de telefone inválido!");
            }
            if (!String.IsNullOrEmpty(obj_dtoContato.email) && (obj_dtoContato.email.Length > 200 || !obj_dtoContato.email.Contains("@")))
            {
                return ("E-mail inválido!");
            }
            if (obj_dtoContato.empresa.Length > 100)
            {
                return ("O nome da empresa pode possuir no máximo 100 caracteres.");
            }
            if (obj_dtoContato.cargo.Length > 100)
            {
                return ("O nome do cargo pode possuir no máximo 100 caracteres.");
            }
            if (String.IsNullOrEmpty(obj_dtoContato.email))
            {
                obj_dtoContato.email = null;
            }
            if (String.IsNullOrEmpty(obj_dtoContato.empresa))
            {
                obj_dtoContato.empresa = null;
            }
            if (String.IsNullOrEmpty(obj_dtoContato.cargo))
            {
                obj_dtoContato.cargo = null;
            }

            // return: "Contato adicionado com sucesso.";
            return DAL_Contato.addNewContato(obj_dtoContato);

        }

        public string validarRmvContato(DTO_Contato obj_dtoContato)
        {
            if (String.IsNullOrEmpty(obj_dtoContato.nomeContato))
            {
                return ("Contato não selecionado!");
            }

            // return: "Contato removido com sucesso.";
            return DAL_Contato.rmvContato(obj_dtoContato);
        }

    }
}
