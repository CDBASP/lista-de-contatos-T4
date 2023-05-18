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
        private string email;

        //propriedades (GET e SET)
        public string PrimeiroNome
        {
        get { return primeiroNome; }
        set { primeiroNome = value; }
        }

        public string sobrenome
        {
            get { return sobrenome; }
            set {
                sobrenome = value;
                //alteração:)
                // var array = this.sobrenome.Split(new char[]
            }
            


        }
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if(value.Length == 11)
                    telefone= value;
                else 
                    telefone = "00000000000";
            }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        //metodo construtor da classe :)
        public Contato()
        {
            primeiroNome= "Enzo";
            sobrenome = "Ancesque";
            telefone = "11-99440-0976";
            email = "enzoancesque@gmail.com";
        }
        //sobrecarga do metodo :)
        public Contato(string primeiroNome, string sobrenome,string telefone, string email)
        {
            PrimeiroNome= primeiroNome; 
            Sobrenome= sobrenome;
            Telefone= telefone;
            Email= email;
        }
        public override string ToString()
        {
            string saida = string.Empty;
            saida += string.Format("{0}, {1}", PrimeiroNome, Sobrenome);
            saida += string.Format("{0}-{1}-{2}", 
            Telefone.Substring(0,1),
            Telefone.Substring(2,4),
            Telefone.Substring(7,3));
            saida += string.Format(email);
            return saida;
            
        }
    }
}
