using Solid.OPC;
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
            #region SRP - Simple Responsibility Principle
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.ChangeName("Ricardo");

            IFornecedorRepository rep = new FornecedorRepository();
            rep.Salvar(fornecedor);
            #endregion

            #region OCP - Open/Closed Principle
            var p = new Pessoa("Ricardo");
            p.ChangeName("Ricardo Silva");

            var pf = new PessoaFisica("Ricardo", "999.999.999.-99");
            #endregion

            #region LSP - Liskov Substituition Principle

            #endregion

            #region ISP - Interface Segregation Principle

            #endregion

            #region DIP - Dependency Inversion Principle
            
            #endregion

        }
    }
}
