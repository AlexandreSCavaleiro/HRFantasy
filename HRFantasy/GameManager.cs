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
            perguntas.Add(new Pergunta(". Um comerciante acidentalmente te dá uma moeda a mais. Você…",
                new Resposta("Devolve imediatamente, é o certo a se fazer.", 'L', 'G'),
                new Resposta("Fica com a moeda, afinal o erro foi dele.", 'N', 'E'),
                new Resposta("Devolve com uma piada sobre como ele precisa contar melhor.", 'C', 'G'),
                new Resposta("Só percebe horas depois e decide manter — destino quis assim.", 'T', 'N')
                ));
            perguntas.Add(new Pergunta("Um mago te oferece poder absoluto por uma pequena trapaça no tribunal.Você… ",
                new Resposta("Recusa e denuncia o mago. Justiça vem antes de poder.", 'L', 'G'),
                new Resposta("Aceita, mas só usa o poder para ajudar órfãos e cozinhar melhor.", 'C', 'G'),
                new Resposta("Aceita, mas usa só o suficiente pra ganhar vantagens pessoais. ", 'L', 'E'),
                new Resposta("Nem ouve a proposta inteira, já está fazendo a trapaça.", 'C', 'E')
                ));
            perguntas.Add(new Pergunta("Um rei cruel te contrata para capturar fugitivos inocentes. Você… ",
                new Resposta("A) Recusa, mesmo que isso custe sua vida.", 'L', 'G'),
                new Resposta("B) Aceita, mas liberta os fugitivos em segredo. ", 'N', 'G'),
                new Resposta("C) Finge aceitar e depois expõe o rei publicamente. ", 'C', 'G'),
                new Resposta("D) Aceita e cobra em dobro, afinal são dois trabalhos: capturar e calar.", 'L', 'E')
                ));

            perguntas.Add(new Pergunta("Você encontra uma espada lendária fincada em pedra com a placa “Não toque”. Você…",
                new Resposta("A) Pede autorização às autoridades locais.", 'L', 'N'),
                new Resposta("B) Arranca a espada e grita “é minha agora!” ", 'C', 'N'),
                new Resposta("C) Observa, tira uma selfie, posta com #ProibidoÉMaisGostoso", 'C', 'G'),
                new Resposta("D) Arranca e usa pra intimidar pessoas aleatórias na rua.", 'C', 'E')
                ));
            perguntas.Add(new Pergunta("Uma vila está sendo atacada por bandidos. Você…",
                new Resposta("A) Organiza a defesa e protege os aldeões com estratégia militar.", 'L', 'G'),
                new Resposta("B) Corre para o combate berrando e improvisando armas.", 'C', 'G'),
                new Resposta("C) Aproveita o caos para pegar algumas coisas “desprotegidas”. ", 'N', 'E'),
                new Resposta("D) Assiste de longe e só age se alguém pedir com educação.", 'T', 'N')
                ));
            perguntas.Add(new Pergunta("Um velho inimigo te implora por perdão. Você…",
                new Resposta("A) Perdoa porque acredita na redenção.", 'N', 'G'),
                new Resposta("B) Finge perdoar, mas planeja vingança fria.", 'L', 'E'),
                new Resposta("C) Dá um abraço e uma rasteira ao mesmo tempo. ", 'C', 'N'),
                new Resposta("D) Nem responde. Apenas sorri enquanto caminha em direção a ele com uma tocha. ", 'C', 'E')
                ));
            perguntas.Add(new Pergunta("Um lacaio te pergunta: “Qual é o nosso objetivo, mestre?” Você responde…",
                new Resposta("A) “Restaurar a ordem e proteger os inocentes.” ", 'L', 'G'),
                new Resposta("B) “Espalhar o medo, mas com elegância.” ", 'L', 'E'),
                new Resposta("C) “Fazer o que der na telha, oras!” ", 'C', 'N'),
                new Resposta("D) “Sobreviver. Só isso importa.” ", 'N', 'N')
                ));
             perguntas.Add(new Pergunta("Você se vê dividido entre salvar um vilarejo ou seguir seu plano original de encontrar um tesouro. Você…  ",
                new Resposta("A) Salva o vilarejo, planos podem esperar. ", 'L ', 'G'),
                new Resposta("B) Vai atrás do tesouro. A vila vai se virar. ", 'N', 'E'),
                new Resposta("C) Tenta fazer os dois ao mesmo tempo, ainda que malucos. ", 'C', 'G'),
                new Resposta("D) Salva parte da vila, pega parte do tesouro. Diplomacia interna. ", 'L', 'N')
                ));

            //ADICIONAR AS OUTRAS PERGUNTAS
        }

        public void Play()
        {
            foreach (Pergunta pergunta in perguntas)
            {
                bool valido = false;
                pergunta.showAll();

                while (!valido) {

                    ConsoleKey op = Console.ReadKey(true).Key;
                    switch (op)
                    {

                        case ConsoleKey.NumPad1:
                        case ConsoleKey.D1:
                            valido = true;
                            pergunta.r1.computaAlinhamento(jogador);

                            break;

                        case ConsoleKey.NumPad2:
                        case ConsoleKey.D2: 
                            valido = true;
                            pergunta.r2.computaAlinhamento(jogador);

                            break;

                        case ConsoleKey.NumPad3:
                        case ConsoleKey.D3:
                            valido = true;
                            pergunta.r3.computaAlinhamento(jogador);

                            break;

                        case ConsoleKey.NumPad4:
                        case ConsoleKey.D4:
                            valido = true;
                            pergunta.r4.computaAlinhamento(jogador);

                            break;

                        default:
                            Console.WriteLine("""

                                        - Não entendi, Diga algo valido! 1, 2, 3 ou 4.....

                                """);
                            valido = false;
                            break;
                    }
                } //while

                Console.Clear();
            }//foreach

            //TODO
            Console.WriteLine($"""

                    Você termina de responder a ultima pergunta, nesse momento o anão e diz: 
                        
                        - Pois bem, pelos meus calculos aqui seu alinhamento ta mais para {jogador.getAlinhamento()}
                        - Perfeito para a guilda... 

                """);
            Console.WriteLine("... aperte uma tecla pra continuar.");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
