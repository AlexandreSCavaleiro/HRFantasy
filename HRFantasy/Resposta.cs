using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRFantasy
{
    class Resposta
    {
        public string texto;    //texto da resposta
        public char LC;     //alinhamento lawful [L] || caotic [C] 
        public char GE;     //alinhamento good [G] || Evil [E]   

        public Resposta(string texto, char LC, char GE)
        {
            this.texto = texto;
            this.LC = LC;
            this.GE = GE;
        }


    }
}
