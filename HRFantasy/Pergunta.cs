using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRFantasy
{
    internal class Pergunta
    {
        string pergunta;
        string r1, r2, r3, r4;
        int IDcorreta;
        string item;

        public Pergunta(string pergunta, string r1, string r2, string r3, string r4, int iDcorreta, string item)
        {
            this.pergunta = pergunta;
            this.r1 = r1;
            this.r2 = r2;
            this.r3 = r3;
            this.r4 = r4;
            IDcorreta = iDcorreta;
            this.item = item;
        }

        public void showAll()
        {
            Console.WriteLine($"""
                    Pergunta:
                    {pergunta}
                    
                    1.{r1}
                    2.{r2}
                    3.{r3}
                    4.{r4}

                    Aperte a tecla referente a resposta correta...
                """);
        }

    }
}
