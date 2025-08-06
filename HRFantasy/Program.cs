
using HRFantasy;

namespace HrFantasy
{
    class Program
    {
        public static void Main()
        {
            List<Pergunta> perguntas = new List<Pergunta>();

            perguntas.Add(new Pergunta("Um goblin faminto te pede um pedaço do seu pão. Você…",
                new Resposta("Dá o pão inteiro, mesmo sabendo que ficará com fome.", 'L', 'G'),
                new Resposta("Dá a metade e ensina ele a pedir de forma educada.", 'N', 'G'),
                new Resposta("Arremessa o pão como se fosse um frisbee e grita “vai buscar!”", 'C', 'G'),
                new Resposta("Come o pão olhando para ele com superioridade e diz “a vida é dura”.", 'N', 'E')
                ));


        }
    }
}