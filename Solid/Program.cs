using Solid.SRP;
using Solid.SRP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SRP
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.ChangeName("Ricardo");

            IFornecedorRepository rep = new FornecedorRepository();
            rep.Salvar(fornecedor);
            #endregion

        }
    }
}
