using System;
using System.Globalization;

namespace Exercicios_Estruturas_Condicionais {
    class Program {
        static void Main(string[] args) {

            // Exercicio 1

            // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não. 

            Console.WriteLine("Exercicio 1");
            Console.WriteLine("");
            Console.WriteLine("Digite um numero inteiro");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 < 0) {
                Console.WriteLine("Este numero é negativo !!");
            }
            else {
                Console.WriteLine("Este numero não é negativo !!");
            }
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("--------");
            Console.WriteLine("");

            // Exercicio 2

            // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

            Console.WriteLine("Exercicio 2");
            Console.WriteLine("");
            Console.WriteLine("Digite um numero inteiro");
            int n2 = int.Parse(Console.ReadLine());

            if (n2 % 2 == 0) {
                Console.WriteLine("Este numero é par !!");
            }
            else {
                Console.WriteLine("Este numero é impar !!");
            }
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("--------");
            Console.WriteLine("");

            // Exercicio 3

            /* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
               Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
               ordem crescente ou decrescente. */

            Console.WriteLine("Exercicio 3");
            Console.WriteLine("");
            Console.WriteLine("Digite os valores A e B");
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Os valores são multiplos");
            }
            else {
                Console.WriteLine("Os valores não são multiplos");
            }
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("--------");
            Console.WriteLine("");


            // Exercicio 3

            /*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
              começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas. */

            Console.WriteLine("Exercicio 4");
            Console.WriteLine("");
            Console.WriteLine("Digite o horario incial e final do jogo");
            string[] vet2 = Console.ReadLine().Split(' ');
            int inicial = int.Parse(vet2[0]);
            int final = int.Parse(vet2[1]);
            int duracao;
            Console.WriteLine("Os horarios inicais são " + inicial + " e " + final);
            // Se o horario inicial for menor, é só fazer a diferença do final com o inicial
            if (inicial < final) {
                duracao = final - inicial;
            }
            else { /* Se o horario inicial for maior, você pega a quantidade de horario do dia, que são 24horas 
                      subtrai do inicial e soma com o final */
                duracao = 24 - inicial + final;
            }
            Console.WriteLine("O Jogo teve uma duração de : " + duracao + " horas !!");
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("--------");
            Console.WriteLine("");

            // Exercicio 5 

            /* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
               seguir, calcule e mostre o valor da conta a pagar. */

            /* ------------------------TABELA-----------------------------
             * -----------------------------------------------------------
             * CÓDIGO ||    ESPECIFICAÇÃO   || PREÇO
             * 1      ||   Cachorro Quente  || R$ 4.00
             * 2      ||   X-Salada         || R$ 4.50
             * 3      ||   X-Bacon          || R$ 5.00
             * 4      ||   Torrada Simples  || R$ 2.00
             * 5      ||   Refrigerante     || R$ 1.50
             */

            Console.WriteLine("Exercicio 5");
            Console.WriteLine("");
            Console.WriteLine("Digite o código entre 1 a 5 do produto e a quantidade desejada ");
            string[] vet3 = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet3[0]);
            int quantidade = int.Parse(vet3[1], CultureInfo.InvariantCulture);
            double preco;

            if (codigo == 1) {
                preco = 4.00 * quantidade;
                Console.WriteLine("O Cachorro Quente ficou " + preco.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
            }
            else if (codigo == 2) {
                preco = 4.50 * quantidade;
                Console.WriteLine("O X-Salada ficou " + preco.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
            }
            else if (codigo == 3) {
                preco = 5.00 * quantidade;
                Console.WriteLine("O X-Bacon ficou " + preco.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
            }
            else if (codigo == 4) {
                preco = 2.00 * quantidade;
                Console.WriteLine("A Torrada Simples ficou " + preco.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
            }
            else {
                preco = 1.50 * quantidade;
                Console.WriteLine("O refrigerante ficou " + preco.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
            }
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("--------");
            Console.WriteLine("");

            // Exercicio 6

            /* Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
              seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
              nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”. */

            Console.WriteLine("Exercicio 6");
            Console.WriteLine("");
            Console.WriteLine("Digite um valor qualquer");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >= 0 && valor <= 25) {
                Console.WriteLine("Valor se encontra entre o intervalo de 0 a 25");
            }
            else if (valor > 25 && valor <= 50) {
                Console.WriteLine("Valor se encontra entre o intervalo de 25 a 50");
            }
            else if (valor > 50 && valor <= 75) {
                Console.WriteLine("Valor se encontra entre o intervalo de 50 a 75");
            }
            else if (valor > 75 && valor <= 100) {
                Console.WriteLine("Valor se encontra entre o intervalo de 75 a 100");
            }
            else {
                Console.WriteLine("Valor não se encontra no intervalo");
            }
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("--------");
            Console.WriteLine("");

            // Exercicio 7

            /* Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
               de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
               ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

               Se o ponto estiver na origem, escreva a mensagem “Origem”.

               Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
               situação.
               
               Quadrante 1 = +X +Y
               Quadrante 2 = -X +Y
               Quadrante 3 = -X -Y
               Quadrante 4 = +X -Y
             */
            Console.WriteLine("Exercicio 7");
            Console.WriteLine("");
            Console.WriteLine("Digite as coordenadas X e Y");
            string[] vet4 = Console.ReadLine().Split(' ');
            double x = double.Parse(vet4[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet4[1], CultureInfo.InvariantCulture);
            Console.WriteLine("As coordenadas digitadas foram");
            Console.WriteLine("X --> " + x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Y --> " + y.ToString("F2", CultureInfo.InvariantCulture));

            if (x > 0 && y > 0) { // Quadrante 1 = +X + Y
                Console.WriteLine("As  coordenadas X e Y estão no quadrante 1");
            }
            else if (x < 0 && y > 0) { // Quadrante 2 = -X +Y
                Console.WriteLine("As  coordenadas X e Y estão no quadrante 2");
            }
            else if (x < 0 && y < 0) { // Quadrante 3 = -X -Y
                Console.WriteLine("As  coordenadas X e Y estão no quadrante 3");
            }
            else if (x > 0 && y < 0) { // Quadrante 4 = +X -Y
                Console.WriteLine("As  coordenadas X e Y estão no quadrante 4");
            }
            else {
                Console.WriteLine("Origem");
            }
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("--------");
            Console.WriteLine("");


            // Exercicio 8

            /* Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
               mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

               RENDA                    ||  IMPOSTO DE RENDA
              R$ 0.00 a R$ 2000.00      || ISENTO
              R$ 2000.01 a R$ 3000.00   || 8%
              R$ 3000.01 a R$ 4500.00   || 18%
              Acima de R$ 4500.00       || 28%               
           */

            Console.WriteLine("Exercicio 8");
            Console.WriteLine("");
            Console.WriteLine("Digite o salário ");
            double salarioLisboa = double.Parse(Console.ReadLine());
            double imposto = 0.0;
            if (salarioLisboa >=0 && salarioLisboa <=2000) {
                Console.WriteLine("Isento !!");
            }
            else if(salarioLisboa>2000 && salarioLisboa<=3000) {
                imposto = salarioLisboa * 0.08;
                Console.WriteLine("Você pagará 8% de imposto, equivalente a R$ "+imposto.ToString("F2",CultureInfo.InvariantCulture));
            }
            else if (salarioLisboa>3000 && salarioLisboa<=4500) {
                imposto = salarioLisboa * 0.18;
                Console.WriteLine("Você pagará 18% de imposto, equivalente a R$ "+ imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else {
                imposto = salarioLisboa * 0.28;
                Console.WriteLine("Você pagará 28% de imposto, equivalente a R$ "+imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("--------");
            Console.WriteLine("");

        }
    }
}
