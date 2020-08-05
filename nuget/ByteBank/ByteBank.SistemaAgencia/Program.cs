using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPgto = new DateTime(2020, 08, 06);
            DateTime hoje = DateTime.Now;
            TimeSpan dif = dataFimPgto - hoje;
            ContaCorrente conta = new ContaCorrente(123, 4567);
            Console.WriteLine(dif.Days);

            int[] idades = new int[5];
            idades[0] = 1;
            idades[1] = 2;
            idades[2] = 3;
            idades[3] = 4;
            idades[4] = 5;
            Console.WriteLine(idades.Length + " " + idades);
            int acumulador = 0;
            for(int indice = 0; indice <= idades.Length-1; indice++)
            {
                int idade = idades[indice];
                acumulador += idade;
                Console.WriteLine(acumulador + "  " + indice);
            }

            int[] numeros = new int[]
            {
                1,
                2
            };

            //Inicializacao de array

            List<int> lista = new List<int>();
            lista.Add(1);

            Console.ReadLine();
        }
    }
}
