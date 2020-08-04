using System;

namespace irrf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário bruto");
            int salario = Int32.Parse(Console.ReadLine());
            const double isento = 1903.99;
            const double p9 = 2765.66; // 7.5%
            const double p11 = 5531.31; // 7.5 até 27.5%
            const double ali1 = 7.5;
            const double ali2 = 15;
            const double ali3 = 22.5;
            const double ali4 = 27.5;
            const double f1 = 142.80;
            const double f2 = 354.80;
            const double f3 = 636.13;
            const double f4 = 869.36;
            if(salario <= isento) {
              Console.WriteLine("Você é isento do IRRF!");
            } else {
              if(salario <= p9) {
                //caso 9%
                double salarioBase = ((salario * 9) / 100) - salario;
                double irrf = ((salarioBase * ali1) / 100) - f1;
                Console.WriteLine(irrf);
              } else if (salario > p9 && salario <= p11) {
                // caso 11%
                double salarioBase = salario - ((salario * 11) / 100);
                if(salarioBase <= 2826.65) {
                  double irrf = ((salarioBase * ali1) / 100) - f1;
                  Console.WriteLine(irrf);
                } else if (salarioBase > 2826.65 && salarioBase <= 3751.05) {
                  double irrf = ((salarioBase * ali2) / 100) - f2;
                  Console.WriteLine(irrf);
                } else if (salarioBase > 3751.05 && salarioBase <= 4664.68) {
                  double irrf = ((salarioBase * ali3) / 100) - f3;
                  Console.WriteLine(irrf);
                } else {
                  double irrf = ((salarioBase * ali4) / 100) - f4;
                  Console.WriteLine(irrf);
                }
              } else {
                // caso teto
                double salarioBase =  salario - 604.44;
                double irrf = ((salarioBase * ali4) / 100) - f4;
                Console.WriteLine(irrf);
              }
            }
        }
    }
}
