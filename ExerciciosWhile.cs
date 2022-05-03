using System;

namespace ExerciciosWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Exercicio 1
             * 
             * Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
               incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
               impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
             */

            Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha invalida !!");
            }
            Console.WriteLine("Acesso permitido !!");

            Console.WriteLine("");
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");
            Console.WriteLine("");

            /* Exercicio 2
             * 
             * Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
               cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
               menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
             */

            Console.WriteLine("Escreva duas coordenadas X e Y: ");
            string[] coordenadas = Console.ReadLine().Split(' ');
            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }

                coordenadas = Console.ReadLine().Split(' ');

                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
            }

            Console.WriteLine("Nula !");
            Console.WriteLine("");
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");
            Console.WriteLine("");

            /* Exercicio 3
             * 
             * Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
               um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma:
               1.Álcool 
               2.Gasolina
               3.Diesel
               4.Fim). 
               Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
               que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
               mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
               exemplo.
             */

            Console.WriteLine("Qual tipo de combustivel você prefere ?");
            Console.WriteLine("1 - Alcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Nenhuma das opções acima");
            Console.WriteLine("");
            Console.Write("Tipo de combustivel: ");
            int tipo = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else
                {
                    diesel = diesel + 1;
                }
                Console.Write("Tipo de combustivel: ");
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito obrigado !!");
            Console.WriteLine("");
            Console.WriteLine("O numero de quantidades que cada combustivel foi selecionado é de: ");
            Console.WriteLine("");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}

