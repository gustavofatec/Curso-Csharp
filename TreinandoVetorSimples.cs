using System;
using System.Globalization;

namespace TreinandoVetor2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Iniciando com algumas entradas basicas

            Console.WriteLine("Faça algum prorama de vetor");
            Console.WriteLine("----------");
            Console.WriteLine("----------");
            Console.WriteLine("Qual é seu nome ?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual é o sexo ?");
            string sexo = Console.ReadLine();
            Console.WriteLine("Qual é sua idade ?");
            int idade = int.Parse(Console.ReadLine());            

            // Agora trabalhando um pouco com vetor

            Console.WriteLine("Digite entre espaços, o cargo, salario e sua formação");
            string[] vet = Console.ReadLine().Split(' ');
            string cargo = vet[0];
            double salario = double.Parse(vet[1],CultureInfo.InvariantCulture);
            string formacao = vet[2];
            Console.WriteLine("Digite entre espaços, o carro, ano, modelo, cor e valor");
            string[] vet1 = Console.ReadLine().Split(' ');
            string carro = vet1[0];
            int ano = int.Parse(vet1[1]);
            string modelo = vet1[2];
            string cor = vet1[3];
            double valor = double.Parse(vet1[4],CultureInfo.InvariantCulture);
            Console.WriteLine("Digite entre espaços, o tamanho do terreno, valor," +
                " cidade/estado, localidade, e o que pretende construir ali");
            string[] vet2 = Console.ReadLine().Split(' ');
            string tamanho = vet2[0];
            double valorTerreno = double.Parse(vet2[1],CultureInfo.InvariantCulture);
            string cidadeEstado = vet2[2];
            string local = vet2[3];
            string pretencao = vet2[4];
            Console.WriteLine("Digite entre espaços, ano que começou a faculdade, ano que terminou" +
                ", cidade/estado que estudou");
            string[] vet3 = Console.ReadLine().Split(' ');
            int anoIncio = int.Parse(vet3[0]);
            int anoFinal = int.Parse(vet3[1]);
            string cidadeEstadoFacul = vet3[2];


            Console.WriteLine("-----------");
            Console.WriteLine("Informações pessoais do cliente");
            Console.WriteLine("");
            Console.WriteLine("Nome: "+nome);
            Console.WriteLine("Sexo: "+sexo);
            Console.WriteLine("Idade: "+idade);
            Console.WriteLine("Profissão: "+cargo);
            Console.WriteLine("Salário: "+salario.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Formação: "+formacao);
            Console.WriteLine("");

            Console.WriteLine("Carro do cliente");
            Console.WriteLine("");
            Console.WriteLine("Carro: "+carro);
            Console.WriteLine("Ano: "+ano);
            Console.WriteLine("Modelo: "+modelo);
            Console.WriteLine("Cor: "+cor);
            Console.WriteLine("Valor do carro: "+valor.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("");

            Console.WriteLine("Terreno do cliente");
            Console.WriteLine("");
            Console.WriteLine("Tamanho do terreno: "+tamanho);
            Console.WriteLine("Valor do terreno: "+valorTerreno.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Cidade/Estado: "+cidadeEstado);
            Console.WriteLine("Local: "+local);
            Console.WriteLine("Pretenção de construção: "+pretencao);
            Console.WriteLine("");

            Console.WriteLine("Ficha escolar do cliente");
            Console.WriteLine("");
            Console.WriteLine("Formação: "+formacao);
            Console.WriteLine("Ano inicio da faculdade: "+anoIncio);
            Console.WriteLine("Ano final da faculdade: "+anoFinal);
            Console.WriteLine("Cidade/Estado que cursou: "+cidadeEstadoFacul);
            
            Console.WriteLine("-------------");


        }
    }
}
