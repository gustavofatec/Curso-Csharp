using System;
using System.Globalization;

namespace ExerciciosSequenciaisDoCurso {
    class Program {
        static void Main(string[] args) {

            // Exercicio 1 - Curso de C#

            /* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa, conforme exemplos. */

            Console.WriteLine("Exercicio 1 ");
            Console.WriteLine("");
            Console.WriteLine("Digite o numero 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero 2");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("A somatória desses dois numeros é igual a");
            int soma = n1 + n2;
            Console.WriteLine(soma);
            Console.WriteLine("");
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Console.WriteLine("");

            // Exercicio 2 - Curso de C#

            /* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
              casas decimais conforme exemplos.
              Fórmula da área: area = π . raio2
              Considere o valor de π = 3.14159 */   
            
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("");
            Console.WriteLine("O valor do raio é igual a ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("O valor da area desse circulo é igual a ");
            double pi = 3.14159;
            double area = pi * (raio*raio);
            Console.WriteLine(area.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("");
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Console.WriteLine("");

            // Exercicio 3 - Curso de C#

            /* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
              de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D) */

            Console.WriteLine("Exercicio 3");
            Console.WriteLine("");
            Console.WriteLine("Valor A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor B");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor C");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor D");
            int D = int.Parse(Console.ReadLine());
            int somaAB = A * B;
            int somaCD = C * D;
            int diferenca = (A * B) - (C * D);
            Console.WriteLine("A diferença entre os produtos de A e B pelo produto de C e D é");
            Console.WriteLine(diferenca);
            Console.WriteLine("");
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Console.WriteLine("");

            // Exercicio 4 -  Curso de C#

            /* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
               hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
               decimais. */

            Console.WriteLine("Exercicio 4");
            Console.WriteLine("");
            Console.WriteLine("QUal é o numero do funcionario ?");
            int numeroFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas esse funcionario trabalhou ?");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto ele recebe por hora trabalhada ?");
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.WriteLine("Então.. Fazendo o seguinte calculo --> Horas Trabalhadas * Valor por hora, o salário dele este mês será dê :");
            double salario = horas * valorPorHora;
            Console.WriteLine(salario.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("");
            Console.WriteLine("Numero do funcionario: "+numeroFuncionario);
            Console.WriteLine("Salário do funcionário: "+salario.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("");
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Console.WriteLine("");

            // Exercicio 5 -  Curso de C#

            /* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
               código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago. */

            Console.WriteLine("Exercicio 5");
            Console.WriteLine("");
            Console.WriteLine("Em uma unica linha, separado por espaços, digite o código do produto, numero de peças e valor unitario");
            Console.WriteLine("");

            Console.WriteLine("PEÇA 1");
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int numeroPeca = int.Parse(vet[1]);
            double valorUnitario = double.Parse(vet[2],CultureInfo.InvariantCulture);
            double total = numeroPeca * valorUnitario;
            Console.WriteLine("O valor a pagar da peça 1 é de: ");
            Console.WriteLine("R$ "+total.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("");

            Console.WriteLine("PEÇA 2");
            string[] vet2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            int numeroPeca2 = int.Parse(vet2[1]);
            double valorUnitario2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);
            double total2 = numeroPeca2 * valorUnitario2;            
            Console.WriteLine("O valor a pagar da peça 2 é de: ");
            Console.WriteLine("R$ "+total2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("");
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Console.WriteLine("");

            // Exercicio 6 - Curso de C#

            /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
               mostre:
               a) a área do triângulo retângulo que tem A por base e C por altura.
               b) a área do círculo de raio C. (pi = 3.14159)
               c) a área do trapézio que tem A e B por bases e C por altura.
               d) a área do quadrado que tem lado B.
               e) a área do retângulo que tem lados A e B. */

            Console.WriteLine("Exercicio 6");
            Console.WriteLine("");
            Console.WriteLine("Digite os valores de A B E C --> Os três valores na mesma linha");
            Console.WriteLine("");
            string[] vet3 = Console.ReadLine().Split(' ');

            double letraA = double.Parse(vet3[0],CultureInfo.InvariantCulture);
            double letraB = double.Parse(vet3[1],CultureInfo.InvariantCulture);
            double letraC = double.Parse(vet3[2],CultureInfo.InvariantCulture);
            double areaTriangulo = (letraA * letraC) / 2;
            double areaCirculo = (letraC*letraC)*3.14159;
            double areaTrapezio = ((letraA + letraB) * letraC) / 2;
            double areaQuadrado = letraB * letraB;
            double areaRetangulo = letraA * letraB;

            Console.WriteLine("");
            Console.WriteLine("A area do triangulo é igual a: "+areaTriangulo.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("A area do círculo é igual a: "+areaCirculo.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("A area do trapezio é igual a: "+areaTrapezio.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("A area do quadrado é igual a: "+areaQuadrado.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("A area do retangulo é igual a: "+areaRetangulo.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("");
            Console.WriteLine("-----------");
            Console.WriteLine("-----------");
            Console.WriteLine("");

            Console.WriteLine("Muito Obrigado :)");
            Console.WriteLine("FIM..");






        }
    }
}

