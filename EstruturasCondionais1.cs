using System;

namespace EstruturasCondicionais {
    class Program {
        static void Main(string[] args) {

            // Estrutura condicional simples

            Console.WriteLine("Digite um numero");
            int a = int.Parse(Console.ReadLine());
            if (a > 7) {
                Console.WriteLine("Você está aprovado !!");
            }
            Console.WriteLine("--------");
            Console.WriteLine("--------");


            // Estrutura condicional composta
            Console.WriteLine("Entre com um numero inteiro");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("O numero " + x + " é par!!");
            }
            else {
                Console.WriteLine("O numero " + x + " é impar!!");
            }
            Console.WriteLine("--------");
            Console.WriteLine("--------");

            // Estrutura de encadeamento

            Console.WriteLine("Que horas são ? ");
            int horas = int.Parse(Console.ReadLine());

            if (horas>=6 && horas <12) {
                Console.WriteLine("Bom dia !!");
            }
            else if (horas>=12 && horas <=18){
                Console.WriteLine("Boa tarde !!");
            }
            else {
                Console.WriteLine("Boa noite !!");
            }

        }
    }
}
