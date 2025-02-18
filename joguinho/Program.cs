using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int credit = 25, random, cor = 0, acao, aposta;
            String corescolhida;

            Console.WriteLine("Seja bem vindo ao perdendo dinheiro");
            Console.WriteLine("Seu saldo inicial é de  R$"+ credit+",00");
            Console.WriteLine("Selecione uma Opção:\n1- Ver cores possiveis\n2- Iniciar Jogo!");
            Console.Write("Selecione a Opção:");
            acao = int.Parse(Console.ReadLine());
            if (acao == 1)
            {
                Console.WriteLine("As cores possiveis são essas: ");
                Console.WriteLine("Vermelho\nLaranja\nAmarelo\nVerde\nAzul\nRoxo\nRosa\nPreto\nBranco\nCinza\nMarrom\nBege\nDourado\nPrateado\nCobre\nBordô\nCarmim\nEscarlate\nMagenta\nVioleta\nTurquesa\nCian\nOliva\nÂmbar\nSafira\nEsmeralda\nAmetista\nRubi\nPérola\nCoral\nPêssego\nDamasco\nLavanda\nLilás\nSalmão\nPistache\nCaqui\nMostarda\nVinho\nChocolate\nCafé\nCaramelo\nMel\nTelha\nTijolo\nAreia\nCreme\nMarfim\nPlatina\nChumbo");
            }
            else if (acao == 2)
            {
                while (cor != 2)
                {
                    Console.WriteLine("Qual será o valor da aposta: ");
                    aposta = int.Parse(Console.ReadLine());
                    if (credit >= aposta)
                    {
                        credit = credit - aposta;
                        Console.WriteLine("O valor apostado foi de R$" + aposta + ",00");
                        Console.Write("Escolha uma cor: ");
                        corescolhida = Console.ReadLine();
                        random = new Random().Next(1, 51);

                        switch (random)
                        {
                            case 1:
                                Console.WriteLine("Vermelho");
                                if (corescolhida.ToLower() == "vermelho")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                    Console.WriteLine("Desja continuar?1- Sim ou 2- Não");
                                    cor = int.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                    Console.WriteLine("Desja continuar?1- Sim ou 2- Não");
                                    cor = int.Parse(Console.ReadLine());
                                }
                                break;

                            case 2:
                                Console.WriteLine("Laranja");
                                if (corescolhida.ToLower() == "laranja")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                    Console.WriteLine("Desja continuar?1- Sim ou 2- Não");
                                    cor = int.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                    Console.WriteLine("Desja continuar?1- Sim ou 2- Não");
                                    cor = int.Parse(Console.ReadLine());
                                }
                                break;

                            case 3:
                                Console.WriteLine("Amarelo");
                                if (corescolhida.ToLower() == "amarelo")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                    Console.WriteLine("Desja continuar?1- Sim ou 2- Não");
                                    cor = int.Parse(Console.ReadLine());

                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                    Console.WriteLine("Desja continuar?1- Sim ou 2- Não");
                                    cor = int.Parse(Console.ReadLine());
                                }
                                break;

                            case 4:
                                Console.WriteLine("Verde");
                                if (corescolhida.ToLower() == "verde")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                    Console.WriteLine("Desja continuar?1- Sim ou 2- Não");
                                    cor = int.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                    Console.WriteLine("Desja continuar?1- Sim ou 2- Não");
                                    cor = int.Parse(Console.ReadLine());
                                }
                                break;

                            case 5:
                                Console.WriteLine("Azul");
                                if (corescolhida.ToLower() == "azul")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                    Console.WriteLine("Desja continuar?1- Sim ou 2- Não");
                                    cor = int.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                    Console.WriteLine("Desja continuar?1- Sim ou 2- Não");
                                    cor = int.Parse(Console.ReadLine());
                                }
                                break;

                            case 6:
                                    Console.WriteLine("Roxo");
                                    if (corescolhida.ToLower() == "roxo")
                                    {
                                        Console.WriteLine("Parabéns você acertou!!!");
                                        credit = aposta * 2;
                                        Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                        Console.WriteLine("Desja continuar?1- Sim ou 2- Não");
                                        cor = int.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        Console.WriteLine("Poxa não foi desta vez");
                                        Console.WriteLine("Desja continuar?1- Sim ou 2- Não");
                                        cor = int.Parse(Console.ReadLine());
                                    }
                                    break;

                            case 7:
                                Console.WriteLine("Rosa");
                                if (corescolhida.ToLower() == "rosa")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    cor = int.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                    Console.WriteLine("Desja continuar?1- Sim ou 2- Não");
                                    cor = int.Parse(Console.ReadLine());
                                }
                                break;

                            case 8:
                                Console.WriteLine("Preto");
                                if (corescolhida.ToLower() == "preto")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 9:
                                Console.WriteLine("Branco");
                                if (corescolhida.ToLower() == "branco")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 10:
                                Console.WriteLine("Cinza");
                                if (corescolhida.ToLower() == "cinza")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 11:
                                Console.WriteLine("Marrom");
                                if (corescolhida.ToLower() == "marrom")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 12:
                                Console.WriteLine("Bege");
                                if (corescolhida.ToLower() == "bege")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 13:
                                Console.WriteLine("Dourado");
                                if (corescolhida.ToLower() == "dourado")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 14:
                                Console.WriteLine("Prateado");
                                if (corescolhida.ToLower() == "prateado")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 15:
                                Console.WriteLine("Cobre");
                                if (corescolhida.ToLower() == "cobre")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 16:
                                Console.WriteLine("Bordô");
                                if (corescolhida.ToLower() == "bordô")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 17:
                                Console.WriteLine("Carmim");
                                if (corescolhida.ToLower() == "carmim")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 18:
                                Console.WriteLine("Escarlate");
                                if (corescolhida.ToLower() == "escarlate")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 19:
                                Console.WriteLine("Magenta");
                                if (corescolhida.ToLower() == "magenta")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 20:
                                Console.WriteLine("Violeta");
                                if (corescolhida.ToLower() == "violeta")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 21:
                                Console.WriteLine("Turquesa");
                                if (corescolhida.ToLower() == "turquesa")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 22:
                                Console.WriteLine("Cian");
                                if (corescolhida.ToLower() == "cian")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 23:
                                Console.WriteLine("Oliva");
                                if (corescolhida.ToLower() == "oliva")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 24:
                                Console.WriteLine("Âmbar");
                                if (corescolhida.ToLower() == "âmbar")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 25:
                                Console.WriteLine("Safira");
                                if (corescolhida.ToLower() == "safira")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 26:
                                Console.WriteLine("Esmeralda");
                                if (corescolhida.ToLower() == "esmeralda")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 27:
                                Console.WriteLine("Ametista");
                                if (corescolhida.ToLower() == "ametista")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 28:
                                Console.WriteLine("Rubi");
                                if (corescolhida.ToLower() == "rubi")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 29:
                                Console.WriteLine("Pérola");
                                if (corescolhida.ToLower() == "pérola")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 30:
                                Console.WriteLine("Coral");
                                if (corescolhida.ToLower() == "coral")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 31:
                                Console.WriteLine("Pêssego");
                                if (corescolhida.ToLower() == "pêssego")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 32:
                                Console.WriteLine("Damasco");
                                if (corescolhida.ToLower() == "damasco")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 33:
                                Console.WriteLine("Lavanda");
                                if (corescolhida.ToLower() == "lavanda")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 34:
                                Console.WriteLine("Lilás");
                                if (corescolhida.ToLower() == "lilás")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 35:
                                Console.WriteLine("Salmão");
                                if (corescolhida.ToLower() == "salmão")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 36:
                                Console.WriteLine("Pistache");
                                if (corescolhida.ToLower() == "pistache")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 37:
                                Console.WriteLine("Caqui");
                                if (corescolhida.ToLower() == "caqui")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 38:
                                Console.WriteLine("Mostarda");
                                if (corescolhida.ToLower() == "mostarda")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 39:
                                Console.WriteLine("Vinho");
                                if (corescolhida.ToLower() == "vinho")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 40:
                                Console.WriteLine("Chocolate");
                                if (corescolhida.ToLower() == "chocolate")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 41:
                                Console.WriteLine("Café");
                                if (corescolhida.ToLower() == "café")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 42:
                                Console.WriteLine("Caramelo");
                                if (corescolhida.ToLower() == "caramelo")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 43:
                                Console.WriteLine("Mel");
                                if (corescolhida.ToLower() == "mel")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 44:
                                Console.WriteLine("Telha");
                                if (corescolhida.ToLower() == "telha")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 45:
                                Console.WriteLine("Tijolo");
                                if (corescolhida.ToLower() == "tijolo")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 46:
                                Console.WriteLine("Areia");
                                if (corescolhida.ToLower() == "areia")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 47:
                                Console.WriteLine("Creme");
                                if (corescolhida.ToLower() == "creme")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 48:
                                Console.WriteLine("Marfim");
                                if (corescolhida.ToLower() == "marfim")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 49:
                                Console.WriteLine("Platina");
                                if (corescolhida.ToLower() == "platina")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;

                            case 50:
                                Console.WriteLine("Chumbo");
                                if (corescolhida.ToLower() == "chumbo")
                                {
                                    Console.WriteLine("Parabéns você acertou!!!");
                                    credit = aposta * 2;
                                    Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00 seu ganho foi de: R$" + aposta * 2);
                                }
                                else
                                {
                                    Console.WriteLine("Poxa não foi desta vez");
                                }
                                break;
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("Você não tem todo este saldo!");
            }
            }


     }
}