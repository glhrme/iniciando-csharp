using System;

namespace aula02
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Aula 02 - Trabalhando com Variáveis");
      Console.WriteLine("Digite um inteiro");
      int variavel1 = Convert.ToInt32(Console.ReadLine());
      double variavel2 = 1.2;
      Console.WriteLine(variavel1 + "/" + variavel2);
    }
  }
}
