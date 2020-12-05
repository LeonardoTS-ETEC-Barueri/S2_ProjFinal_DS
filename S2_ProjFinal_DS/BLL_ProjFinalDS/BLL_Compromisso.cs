using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using DAL_ProjFinalDS;
using DTOL_ProjFinalDS;

namespace BLL_ProjFinalDS
{
    public class BLL_Compromisso
    {
        public string validarRmvCompromisso(DTO_Compromisso obj_dtoCompromisso)
        {
            if (String.IsNullOrEmpty(obj_dtoCompromisso.codCompromisso.ToString()))
            {
                return ("Compromisso não selecionado");
            }

            // return: "Compromisso removido com sucesso";
            return DAL_Compromisso.removerCompromisso(obj_dtoCompromisso);

        }

        public static List<DTO_Convidado> verificarListaCompromisso(DTO_Compromisso obj_dtoCompromisso)
        {
            // return: Lista de convidados da base de dados relacionada ao compromisso.
            return DAL_Compromisso.listarConvidados(obj_dtoCompromisso);
        }

        public string validarAltCompromisso(DTO_Compromisso obj_dtoCompromisso)
        {
            string[] horario = obj_dtoCompromisso.horario.Split(':');
            int hora = int.Parse(horario[0]);
            int minuto = int.Parse(horario[1]);
            int segundo = int.Parse(horario[2]);

            obj_dtoCompromisso.assunto.Trim();
            obj_dtoCompromisso.descricao.Trim();

            if (obj_dtoCompromisso.codCompromisso == 0)
            {
                return "Compromisso não definido, algo está errado! Avise o administrador.";
            }
            if (obj_dtoCompromisso.assunto.Length > 50)
            {
                return "O assunto pode possuir no máximo 50 caracteres.";
            }
            if (String.IsNullOrEmpty(obj_dtoCompromisso.assunto))
            {
                return "O assunto não pode ficar vazio.";
            }
            if (String.IsNullOrEmpty(obj_dtoCompromisso.dataCompromisso))
            {
                return "Por favor, selecione uma data para o seu compromisso.";
            }
            if (String.IsNullOrEmpty(obj_dtoCompromisso.horario))
            {
                return "O horário não foi definido, por favor digite o horário.";
            }
            if (hora > 23 || hora < 0)
            {
                return "Hora inválida, corrija por favor.";
            }
            if (minuto > 59 || minuto < 0)
            {
                return "Minuto inválido, corrija por favor.";
            }
            if (segundo > 59 || segundo < 0)
            {
                return "Segundos inválidos, corrija por favor.";
            }
            if (obj_dtoCompromisso.descricao.Length > 255)
            {
                return "A descrição do compromisso pode possuir no máximo 255 caracteres.";
            }

            // return: "Compromisso Alterado!";
            return DAL_Compromisso.alterarCompromisso(obj_dtoCompromisso);
        }

        public static string validarNewConvidado(DTO_Convidado obj_dtoConvidado)
        {
            // return: "Convidado adicionado à lista.";
            return DAL_Compromisso.addNewConvidado(obj_dtoConvidado);
        }

        public static string validarRmvConvidado(DTO_Convidado obj_dtoConvidado)
        {
            if (String.IsNullOrEmpty(obj_dtoConvidado.nomeContato))
            {
                obj_dtoConvidado.nomeContato = null;
            }
            // return: "Contato removido da lista.";
            return DAL_Compromisso.rmvConvidado(obj_dtoConvidado);
        }

        public string validarNewCompromisso(DTO_Compromisso obj_dtoCompromisso)
        {
            
            string[] horario = obj_dtoCompromisso.horario.Split(':');
            int hora = int.Parse(horario[0]);
            int minuto = int.Parse(horario[1]);
            int segundo = int.Parse(horario[2]);

            obj_dtoCompromisso.assunto.Trim();
            obj_dtoCompromisso.descricao.Trim();

            if (obj_dtoCompromisso.codCompromisso == 0)
            {
                return "Compromisso não definido, algo está errado! Avise o administrador.";
            }
            if (obj_dtoCompromisso.assunto.Length > 50)
            {
                return "O assunto pode possuir no máximo 50 caracteres.";
            }
            if (String.IsNullOrEmpty(obj_dtoCompromisso.assunto))
            {
                return "O assunto não pode ficar vazio.";
            }
            if (String.IsNullOrEmpty(obj_dtoCompromisso.dataCompromisso))
            {
                return "Por favor, selecione uma data para o seu compromisso.";
            }
            if (String.IsNullOrEmpty(obj_dtoCompromisso.horario))
            {
                return "O horário não foi definido, por favor digite o horário.";
            }
            if (hora > 23 || hora < 0)
            {
                return "Hora inválida, corrija por favor.";
            }
            if (minuto > 59 || minuto < 0)
            {
                return "Minuto inválido, corrija por favor.";
            }
            if (segundo > 59 || segundo < 0)
            {
                return "Segundos inválidos, corrija por favor.";
            }
            if (obj_dtoCompromisso.descricao.Length > 255)
            {
                return "A descrição do compromisso pode possuir no máximo 255 caracteres.";
            }

            // return: "Compromisso criado com sucesso.";
            return DAL_Compromisso.addNewCompromisso(obj_dtoCompromisso);
        }

    }

}
