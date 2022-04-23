using System;
using System.Globalization;

namespace LanchoneteGu
{
    class Program
    {
        static void Main(string[] args)
        {

            // CARDÁPIO LANCHONETE 

            /* CÓDIGO DOS PRODUTOS    ||     PRODUTO      ||     PREÇO
             *        1               ||    X-Salada      ||   R$ 5.00                   
             *        2               ||    X-Bacon       ||   R$ 6.00
             *        3               ||    X-Burguer     ||   R$ 8.50
             *        4               ||    Duplo Bacon   ||   R$ 10.00
             *        5               ||    X-Frango      ||   R$ 9.50
             *        6               ||    Refrigerante  ||   R$ 3.50
             *        7               ||    Cerveja       ||   R$ 4.50
             *        8               ||    Suco          ||   R$ 3.00
             *        9               ||    Agua com gás  ||   R$ 2.50
             *        10              ||    Agua sem gás  ||   R$ 1.50  
             */


            Console.WriteLine("Bem vindo a lachonete !!");
            Console.WriteLine("");
            Console.WriteLine("Qual é o seu nome ?");
            string nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(nome + ", dê uma olhada em nosso cárdapio");
            Console.WriteLine("");
            Console.WriteLine("1 - X-Salada -- R$ 5.00");
            Console.WriteLine("2- X-Bacon -- R$ 6.00");
            Console.WriteLine("3 - X-Burguer -- R$ 8.50");
            Console.WriteLine("4 - Duplo Bacon -- R$ 10.00");
            Console.WriteLine("5 - X-Frango -- R$ 9.50");
            Console.WriteLine("6 - Refrigerante -- R$ 3.50");
            Console.WriteLine("7 - Cerveja -- R$ 4.50");
            Console.WriteLine("8 - Suco -- R$ 3.00");
            Console.WriteLine("9 - Agua com gás -- R$ 2.50");
            Console.WriteLine("10 - Agua sem gás -- R$ 1.50");
            Console.WriteLine("");
            Console.WriteLine("Insira o código do produto que deseja ");
            int codigo = int.Parse(Console.ReadLine());
            double preco;

            if (codigo == 1)
            {
                Console.WriteLine("Você escolheu X-Salada");
                Console.WriteLine("");
                Console.WriteLine("Qual a quantidade desejada ?");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 5.00;
                Console.WriteLine("");
                Console.WriteLine("Seu pedido ficou em um total de R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }
            else if (codigo == 2)
            {
                Console.WriteLine("Você escolheu X-Bacon");
                Console.WriteLine("");
                Console.WriteLine("Qual a quantidade desejada ?");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 6.00;
                Console.WriteLine("");
                Console.WriteLine("Seu pedido ficou em um total de R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }
            else if (codigo == 3)
            {
                Console.WriteLine("Você escolheu X-Burguer");
                Console.WriteLine("");
                Console.WriteLine("Qual a quantidade desejada ?");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 8.50;
                Console.WriteLine("");
                Console.WriteLine("Seu pedido ficou em um total de R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }
            else if (codigo == 4)
            {
                Console.WriteLine("Você escolheu Duplo Bacon");
                Console.WriteLine("");
                Console.WriteLine("Qual a quantidade desejada ?");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 10.00;
                Console.WriteLine("");
                Console.WriteLine("Seu pedido ficou em um total de R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }
            else if (codigo == 5)
            {
                Console.WriteLine("Você escolheu X-Frango");
                Console.WriteLine("");
                Console.WriteLine("Qual a quantidade desejada ?");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 9.50;
                Console.WriteLine("");
                Console.WriteLine("Seu pedido ficou em um total de R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }
            else if (codigo == 6)
            {
                Console.WriteLine("Você escolheu Refrigerante");
                Console.WriteLine("");
                Console.WriteLine("Qual a quantidade desejada ?");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 3.50;
                Console.WriteLine("");
                Console.WriteLine("Seu pedido ficou em um total de R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }
            else if (codigo == 7)
            {
                Console.WriteLine("Você escolheu Cerveja");
                Console.WriteLine("");
                Console.WriteLine("Qual a quantidade desejada ?");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 4.50;
                Console.WriteLine("");
                Console.WriteLine("Seu pedido ficou em um total de R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }
            else if (codigo == 8)
            {
                Console.WriteLine("Você escolheu Suco");
                Console.WriteLine("");
                Console.WriteLine("Qual a quantidade desejada ?");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 3.00;
                Console.WriteLine("");
                Console.WriteLine("Seu pedido ficou em um total de R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }
            else if (codigo == 9)
            {
                Console.WriteLine("Você escolheu Agua com gás");
                Console.WriteLine("");
                Console.WriteLine("Qual a quantidade desejada ?");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 2.50;
                Console.WriteLine("");
                Console.WriteLine("Seu pedido ficou em um total de R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }
            else if (codigo == 10)
            {
                Console.WriteLine("Você escolheu Agua sem gás");
                Console.WriteLine("");
                Console.WriteLine("Qual a quantidade desejada ?");
                int quantidade = int.Parse(Console.ReadLine());
                preco = quantidade * 1.50;
                Console.WriteLine("");
                Console.WriteLine("Seu pedido ficou em um total de R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }
           if (codigo == 1 || codigo == 2 || codigo == 3 || codigo == 4 || codigo == 5 || codigo == 6 || codigo == 7 || codigo == 8 || codigo == 9 || codigo == 10 )
            {
                Console.WriteLine("Por favor avalie o nosso atendimento. Em uma escala de 0 a 10, qual nota você atrbui para nós ? ");
                int nota = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Muito obrigado, ficamos agradecidos. Volte sempre :)");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Infelizmente você não escolheu nenhum produto :(");
                Console.WriteLine("Mas ficamos agradecidos pela atenção !! Obrigado :)");
            }
        }
    }
}
