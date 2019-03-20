using System;

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
