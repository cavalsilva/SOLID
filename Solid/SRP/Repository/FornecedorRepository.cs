using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Repository
{
    //DEMO Only
    public class FornecedorRepository : IFornecedorRepository
    {
        public void Salvar(Fornecedor fornecedor)
        {
            Console.Write("Salvei");
        }
    }
}
