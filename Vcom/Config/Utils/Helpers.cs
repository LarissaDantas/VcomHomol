using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GloboChallenge.Config.Utils
{
    public static class Helpers
    {
        public enum TipoPesquisa
        {
            Nenhum = 0,
            Nome,
            CPF,
            Email,
            //Endereco,
            //Telefone
        }
        public static string AplicarMascaraPorTipo(string nome, TipoPesquisa tipoPesquisa)
        {
            string[] nomeArray;
            string retorno;

            switch (tipoPesquisa)
            {
                case TipoPesquisa.Nome:
                    nomeArray = nome.Split(' ');
                    string valorMascarado ="";
                    if (nomeArray.Length == 2)
                    {
                        var nomemeio = nomeArray.Skip(1);
                        
                        foreach (var item in nomemeio.Take(nomemeio.Count() - 1))
                        {
                         valorMascarado=  string.Format( "{0} {1}", valorMascarado,item);
                        }

                        retorno = string.Concat("{0} {1}", nomeArray.First(), string.Concat(Enumerable.Repeat('#', valorMascarado.Length).ToArray()));
                    }
                    else if (nomeArray.Length > 2)
                    {
                        var nomemeio = nomeArray.Skip(1);

                        foreach (var item in nomemeio.Take(nomemeio.Count() - 1))
                        {
                            valorMascarado = string.Format("{0} {1}", valorMascarado, item).Trim();
                        }
                        retorno = string.Format("{0} {2} {1}", nomeArray.First(), nomeArray.Last(), string.Concat(Enumerable.Repeat('#', valorMascarado.Length).ToArray()));
                    }
                    else
                    {
                        retorno = nomeArray.FirstOrDefault();
                    }
                    break;
                case TipoPesquisa.CPF:
                    if (nome.Length == 11)
                    {
                        retorno = string.Format("{0}{1}", string.Concat(nome.Take(9).ToArray()), string.Concat(Enumerable.Repeat('#', 2).ToArray()));
                    }
                    else
                    {
                        retorno = string.Format("{0}{1}", string.Concat(nome.Take(11).ToArray()), string.Concat(Enumerable.Repeat('#', 3).ToArray()));
                    }
                    break;
                case TipoPesquisa.Email:
                    MailAddress addr = new MailAddress(nome);
                    retorno = string.Concat("{0}@#####", addr.User);
                    break;
                //case TipoPesquisa.Endereco:
                //    retorno ="";
                //    break;
                //case TipoPesquisa.Telefone:
                //    retorno = string.Concat("#####{0}", nome.Substring(5));
                //    break;
                case TipoPesquisa.Nenhum:
                    retorno = nome;
                    break;
                default:
                    retorno = nome;
                    break;

            }
            return retorno;
        }

    }
}
