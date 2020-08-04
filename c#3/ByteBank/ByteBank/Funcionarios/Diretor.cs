using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Diretor : Funcionario
    {

        public Diretor(string cpf) : base(cpf)
        {

        }
        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }
    }
}
