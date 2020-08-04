using System;

namespace condicionais
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Trabalhando com condicionais");
      bool noExit = true;
      string validation = "";
      bool exit = true;
      do {
        Console.WriteLine("Digite uma idade");
        int idade = Int32.Parse(Console.ReadLine());
        if(idade < 18)
          Console.WriteLine("Sorry meu parça");
        else
          Console.WriteLine("Ae Brodi");
        do {
          Console.WriteLine("Deseja sair? S = SIM | N = NAO ");
          validation = Console.ReadLine().ToUpper();
          switch(validation) {
            case "S":
              noExit = false;
              exit = false;
              break;
            case "N":
              noExit = true;
              exit = false;
              break;
          }
        } while (exit);
        if(true)
          Console.WriteLine("\n");
      } while (noExit);
    }
  }
}
