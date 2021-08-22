using System;

namespace CShrap_Calcula_Triplo
{
    class Program
    {
        static void Main(string[] args)
        {
           //declaração das variáveis do programa
           double Num, Triplo;

           //comando "LimpaTela" limpa a tela do monitor de vídeo
           Console.Clear();

            // {Entrada dos dados}
            //mensagem para que o usuári saiba o que deve fazer
            Console.Write("Digite um número: ");

           //leitura do número para a memória
           Num = double.Parse(Console.ReadLine());

           //{Processamento}
           //calcula o triplo e armazena o resultado na variável Triplo
           Triplo = Num * 3;

           // {Saída da informação}
           //apenas salta uma linha na tela do monitor de vídeo
           Console.WriteLine();

           //exibe o resultado
            Console.WriteLine($"O Triplo de {Num}  é  {Triplo}");
        }
    }
}
