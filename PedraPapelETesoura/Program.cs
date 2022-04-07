using System;
using System.Linq;

namespace PedraPapelETesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            bool saida = true;

            while (saida)
            {
                Console.WriteLine("**** Início Programa ****");
                Console.WriteLine("Informe um valor PEDRA, TESOURA OU PAPEL");
                var entrada1 = Console.ReadLine().Trim().ToUpper();
                var entrada2 = Console.ReadLine().Trim().ToUpper();

                if(ValidarEntrada(entrada1) && ValidarEntrada(entrada2))
                {
                    Jogar(entrada1, entrada2);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dados inválidos! Informe um valor Pedra, Papel ou Tesoura não importa se é maiúsculo ou minúsculo");
                    Console.ResetColor();
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Pressione S para sair ou qualquer tecla para continuar ");
                string acao = Console.ReadLine();
                saida = acao.Trim().ToUpper().Equals("S") ? false : true;
                Console.ResetColor();

                if (!saida)
                {
                    Console.WriteLine("**** Final do Programa ****");
                }

            }

        }

        private static void Jogar(string entrada1, string entrada2)
        {
            if (entrada1.Equals("PEDRA") && entrada2.Equals("PAPEL") || entrada1.Equals("PAPEL") && entrada2.Equals("PEDRA"))
            {
                Console.WriteLine("PAPEL VENCE PEDRA!");
            }
            else if (entrada1.Equals("TESOURA") && entrada2.Equals("PAPEL") || entrada1.Equals("PAPEL") && entrada2.Equals("TESOURA"))
            {
                Console.WriteLine("TESOURA VENCE PAPEL!");
            }
            else if (entrada1.Equals("PEDRA") && entrada2.Equals("TESOURA") || entrada1.Equals("TESOURA") && entrada2.Equals("PEDRA"))
            {
                Console.WriteLine("PEDRA VENCE TESOURA!");
            }
            else
            {
                Console.WriteLine("EMPATE!");
            }
        }

        private static bool ValidarEntrada(string entrada)
        {
            var opcoes = new string[3] { "PEDRA", "PAPEL", "TESOURA" };
            return opcoes.Any(x => x.Equals(entrada));
        }
    }
}
