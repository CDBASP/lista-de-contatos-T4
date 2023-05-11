using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_simples
{
    internal class Contato
    {
        //variaveis internas da classe do contato 
        //a palavra-chave "private" inidca que somente o classe "contato" tem acesso 
        private string primeiroNome;
        private string Sobrenome;
        private string telefone;

        //propriedades (GET e SET)
        public string PrimeiroNome
        {
        get { return PrimeiroNome; }
        set { primeiroNome = value; }
        }

        public string sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Telefone
        {
            get { return Telefone; }
            set
            {
                if(value.Length == 11)
                    telefone= value;
                else 
                    Telefone = "00-00000-0000";
            }
        }
        //metodo construtor da classe :)
        public Contato()
        {
            primeiroNome= "José";
            sobrenome = "Da Silva";
            telefone = "11-99078-0976";
        }
        //sobrecarga do metodo :)
        public Contato(string primeiroNome, string sobrenome,string telefone)
        {
            PrimeiroNome= primeiroNome; 
            Sobrenome= sobrenome;
            Telefone= telefone;
        }
        public override string ToString()
        {
            string saida = string.Empty;
            saida += string.Format("{0}, {1}", PrimeiroNome, Sobrenome);
            saida += string.Format("{0}-{1}-{2}", 
            Telefone.Substring(0,1),
            Telefone.Substring(2,4),
            Telefone.Substring(7,3));
            return saida;
        }
    }
}
