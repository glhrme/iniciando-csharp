using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class AutenticadorHelper
    {
        public static bool CompararSenha(string senhaVerdadeira, string senha)
        {
            return senhaVerdadeira == senha;
        }
    }
}
