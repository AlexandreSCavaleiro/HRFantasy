using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRFantasy
{
    class GameManager
    {
        private GameManager()
        {
            Awake();
            Start();
            Play();
        }

        static private GameManager instance;
        static public GameManager Instance => instance ??= new GameManager();

        List<Pergunta> perguntas = new List<Pergunta>();
        Jogador jogador;

        //Lore inicial
        public void Awake()
        {
            Console.WriteLine("""

                    Ao entrar na tenda central do vilarejo, o cheiro de tabaco queimado e couro velho envolve suas narinas. 
                    Um silêncio quase cerimonial domina o ambiente, até que uma voz grave e arrastada quebra a tensão:

                        — Então... você é o próximo?

                """);
            Console.WriteLine("... aperte uma tecla pra continuar.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("""
                    Do fundo da sala, emerge uma figura robusta. Um anão de estatura baixa, mas presença imensa, 
                 caminha lentamente em sua direção. 
                    A barba trançada até o peito ostenta anéis de ferro forjado, cada um marcado com símbolos antigos. 
                    Seus olhos, escondidos sob grossas sobrancelhas e um elmo amassado pelo tempo, observam com julgamento silencioso, 
                 como se pesassem sua alma ali mesmo.
                
                        — Sente-se.     — diz ele, batendo com força em uma cadeira de madeira entalhada, marcada por décadas de outros candidatos.
                        — Esse teste não é sobre o que você sabe. É sobre quem você realmente é... quando ninguém está olhando.
                
                """);
            Console.WriteLine("... aperte uma tecla pra continuar.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("""
                    Ele se senta na cadeira do outro lado da mesa a sua frente, 
                 senta pega uma pena e um pergaminho, e diz:
                        
                        - O teste das guildas consiste em 10 testes.    - diz ele gesticulando para
                 lhe mostrar 10 pergaminhos enrolados na mesa ao lado.
                        - Você será testado para entendermos qual guilda é mais adequada para te encaixar.
                        - Me diga seu nome aventureiro...
                
                """);
            Console.Write("Seu nome: ");
            jogador = new Jogador(Console.ReadLine());
            Console.WriteLine("... aperte uma tecla pra continuar.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("""
                        
                        - Otimo! Vamos Começar logo...
                        
                    O anão escreve eu nome no pergaminho, levanta, pega os pergaminhos na mesa 
                 ao lado e da o primeiro na sua mão.

                        - Leia com atenção, não existe resposta totalmente correta, 
                    nem completamente errada. O teste é pra te alocar em uma das 9 guildas da cidade.

                """);
            Console.WriteLine("... aperte uma tecla pra continuar.");
            Console.ReadLine();
            Console.Clear();



        }

        //Start de todos as perguntas
        public void Start()
        {
            perguntas.Add(new Pergunta("Um goblin faminto te pede um pedaço do seu pão. Você…",
                new Resposta("Dá o pão inteiro, mesmo sabendo que ficará com fome.", 'L', 'G'),
                new Resposta("Dá a metade e ensina ele a pedir de forma educada.", 'N', 'G'),
                new Resposta("Arremessa o pão como se fosse um frisbee e grita “vai buscar!”", 'C', 'G'),
                new Resposta("Come o pão olhando para ele com superioridade e diz “a vida é dura”.", 'N', 'E')
                ));
            perguntas.Add(new Pergunta("Você encontra um anel mágico que deixa qualquer um irresistível. Você…",
                new Resposta("Usa para conseguir melhores acordos nas negociações do reino.", 'L', 'E'),
                new Resposta("Dá ao seu amigo mais feio porque sente que ele precisa.", 'N', 'G'),
                new Resposta("Vende para um ogro em troca de proteção vitalícia.", 'L', 'N'),
                new Resposta("Usa para roubar corações (e bolsas) por onde passa.", 'C', 'E')
                ));

            //ADICIONAR AS OUTRAS PERGUNTAS
        }

        public void Play()
        {
            foreach (Pergunta pergunta in perguntas)
            {
                pergunta.showAll();

                ConsoleKey op = Console.ReadKey(true).Key;

                Console.Clear();
                
                switch (op)
                {
                    //1. inicia mineração
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        pergunta.r1.computaAlinhamento(jogador);

                        break;
                    //2. total de pontos
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2: //total de pontos no inventario
                        pergunta.r2.computaAlinhamento(jogador);

                        break;

                    //3. mostrar inventário
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        pergunta.r3.computaAlinhamento(jogador);

                        break;
                    //4. pickdrop antes da mineração pTESTE somente
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4: //pickdrop pra n ter que ficar minerando enquanto to testando
                        pergunta.r4.computaAlinhamento(jogador);

                        break;

                    case ConsoleKey.Escape: //out
                        Console.WriteLine("""

                            Ok, tudo bem desistir.....

                        """);
                        break;

                    default:
                        Console.WriteLine("""

                                - Não entendi, Diga algo valido! 1, 2, 3 ou 4.....


                        """);
                        break;
                }

            }

            //
        }

    }
}
