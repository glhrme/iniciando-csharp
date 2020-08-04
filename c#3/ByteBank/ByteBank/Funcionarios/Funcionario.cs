using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Funcionario
    {
        public static int TotalFuncionarios { get; private set; }

        public Funcionario(string cpf)
        {
            this.cpf = cpf;
            TotalFuncionarios++;
        }
        public string cpf { get; private set; }
        private double salario { get; set; }

        public double Salario
        {
            get
            {
                return this.salario;
            }

            set
            {
                this.salario = value;
            }
        }

        public virtual double GetBonificacao()
        {
            return this.Salario * 0.1;
        }
    }
}
