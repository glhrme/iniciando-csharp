using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario guilherme = new Funcionario("999.999.999-00");
            Diretor brenda = new Diretor("000.000.000-99");
            guilherme.Salario = 1000;
            brenda.Salario = 1000;
            Console.WriteLine(guilherme.GetBonificacao());
            Console.WriteLine(brenda.GetBonificacao());
            Console.WriteLine(Funcionario.TotalFuncionarios);
            Console.WriteLine(Funcionario.TotalFuncionarios);
            Console.ReadLine();
        }
    }
}
