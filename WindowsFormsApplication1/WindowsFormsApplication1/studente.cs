using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class studente : persona

    {
        private string _sezione;
        public string sezione { get; set; }

        public studente(string nome, string cognome, int anni, string sezione) : base(nome, cognome, anni)
        {
            this.sezione = sezione;
        }
        public override void describe()
        {
            base.describe();
            Console.WriteLine("sezione" + sezione + System.Environment.NewLine);
        }
    }
}
