using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRFantasy
{
    class Jogador
    {
        string nome = "player";
        int lawful, caotic, good, evil;

        public Jogador(string nome) {

            this.nome = nome;
            int lawful, caotic, good, evil = 0;

        }

        public string getAlinhamento() {

            string alinhamento;

            if (lawful > caotic)
            {
                alinhamento = "Lawful";
            } else if (lawful < caotic)
            {
                alinhamento = "Caotic";
            } 
            else { alinhamento = "Neutral"; }

            if (good > evil)
            {
                alinhamento += " Good";
            }
            else if (good < evil)
            {
                alinhamento += " Caotic";
            }
            else { alinhamento += " Neutral"; }

            if (alinhamento == "Neutral Neutral") alinhamento = "True Neutral";

            return alinhamento;
        }
    }
}
