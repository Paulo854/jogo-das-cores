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
             int credit = 25, random, continuidade = 0, acao, aposta;
 String corescolhida;
 string[] cores = { "vermelho", "laranja", "amarelo", "verde", "azul", "anil", "violeta", "rosa", "branco", "preto"};



 Console.WriteLine("Seja bem vindo ao perdendo dinheiro");
 Console.WriteLine("Seu saldo inicial é de  R$" + credit + ",00");
 Console.WriteLine("Selecione uma Opção:\n1- Ver cores possiveis\n2- Iniciar Jogo!");
 Console.Write("Selecione a Opção:");
 acao = int.Parse(Console.ReadLine());
 if (acao == 1) {
     Console.WriteLine("As cores possívels são essas:\nvermelho\nlaranja\namarelo\nverde\nazul\nanil\nvioleta\nrosa\nbranco\npreto");
 }

 while (continuidade != 2)
 {
     if (acao == 2)
     {
         Console.Write("Qual será o valor da Aposta? ");
         aposta = int.Parse(Console.ReadLine());
         if (credit >= aposta)
         {
             credit = credit - aposta;
             Console.WriteLine("Seu crédito foi atualizado para R$" + credit + ",00");
             Console.Write("Em qual cor você aposta: ");
             corescolhida = Console.ReadLine();
             random = new Random().Next(0, cores.Length);
             String resultado = cores[random];
             if (corescolhida.ToLower() == resultado)
             {
                 Console.WriteLine("Parabéns você acertou!");
                 credit = aposta * 2;
                 Console.WriteLine("Já atualizamos seu saldo para R$" + credit + ",00");
                 Console.WriteLine("Você deseja apostar de novo? 1- Sim ou 2 - Não");
                 Console.Write("Escolha uma opção: ");
                 continuidade = int.Parse(Console.ReadLine());
             }
             else
             {
                 Console.WriteLine("A cor sorteada foi: " + resultado);
                 Console.WriteLine("Poxa não foi desta vez");
                 Console.WriteLine("Você deseja apostar de novo? 1- Sim ou 2 - Não");
                 Console.Write("Escolha uma opção: ");
                 continuidade = int.Parse(Console.ReadLine());
             }
         }
         else
         {
             Console.WriteLine("Você não tem esse saldo");
             Console.WriteLine("Você deseja apostar? 1- Sim ou 2 - Não");
             Console.Write("Escolha uma opção: ");
             continuidade = int.Parse(Console.ReadLine());
         }
     }
     if (acao >= 3)
     {
         Console.WriteLine("Opção não encontrada");
         continuidade = 2;
     }
 }
            }


     }
}