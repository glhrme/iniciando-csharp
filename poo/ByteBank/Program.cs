using System;
using ByteBank;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente("Guilherme de Assis dos Santos", 0151, 7990);

            Console.WriteLine(conta.getTitular());
        }
    }
}
