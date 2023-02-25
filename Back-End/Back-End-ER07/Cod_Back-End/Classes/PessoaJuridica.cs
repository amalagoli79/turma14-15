using System.Text.RegularExpressions;
using Back_End_ER04.Interfaces;

namespace Back_End_ER04.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }
        public string? razaoSocial { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000 )
            {   
               return rendimento * 0.03f;
                
            } else if (rendimento > 3000 && rendimento <= 6000 )
            {
                return rendimento * 0.05f;

            } else if (rendimento > 6000 && rendimento <= 10000 )
            {
                return rendimento * 0.07f;

            } else 
            {
                return rendimento * 0.09f;
            } 
        }

        public bool ValidarCnpj(string cnpj)

            // 76773415000160 (14)
            // 76.773.415/0001-60 (18)

        {
            //Comparando através da Metodo Regex o valor info. do cnpj com o "padrão regex"
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2}) $");

            if (retornoCnpjValido)
            {
                string subStringCnpj14 = cnpj.Substring(8, 4);

                if (subStringCnpj14 == "0001")
                {
                    return true;
                } else
                
                return false;
    
            }

            string subStringCnpj18 = cnpj.Substring(11, 4);

                if (subStringCnpj18 == "0001")
                {
                    return true;
                }

        return false;
        }
    }
}