using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class persona
    {
        private string _nome;
        public string nome { get; set; }

        private string _cognome;
        public string cognome { get; set; }

        private int _anni;
        public int anni
        {
            set
            {
                if (value <= 0) value = 1;
                _anni = value;
            }

            get { return _anni; }
        }

        private string _codicefiscale;
        public string codicefiscale
        {
            get { return nome + cognome + anni; }
        }

        public persona(string nome, string cognome, int anni)
        {
            this.anni = anni;
            this.nome = nome;
            this.cognome = cognome;

        }

        public virtual void describe()
        {
            Console.WriteLine("Questo è " + nome + "  " + cognome);
            Console.WriteLine("di anni :" + anni);
            Console.WriteLine("codice fiscale:" + codicefiscale);
        }

    }
}

