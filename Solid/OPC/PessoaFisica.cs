using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OPC
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(string name, string CPF)
            : base(name)
        {
            this.CPF = CPF;
        }

        public string CPF { get; set; }
    }
}
