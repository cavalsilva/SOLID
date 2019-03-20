using Solid.DIP;
using Solid.DIP.Contracts;
using Solid.ISP;
using Solid.LSP;
using Solid.OPC;
using Solid.SRP;
using Solid.SRP.Repository;
using System;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SRP - Simple Responsibility Principle
            //Fornecedor fornecedor = new Fornecedor();
            //fornecedor.ChangeName("Ricardo");

            //IFornecedorRepository rep = new FornecedorRepository();
            //rep.Salvar(fornecedor);
            #endregion

            #region OCP - Open/Closed Principle
            //var p = new Pessoa("Ricardo");
            //p.ChangeName("Ricardo Silva");

            //var pf = new PessoaFisica("Ricardo", "999.999.999.-99");
            #endregion

            #region LSP - Liskov Substituition Principle
            //var veiculo = new Carro();
            //veiculo.LigarMotor();
            #endregion

            #region ISP - Interface Segregation Principle
            //NotaFiscal nf = new NotaFiscal();
            //nf.RealizarPedido();
            #endregion

            #region DIP - Dependency Inversion Principle
            //var rep = new CustomerRepository();
            //var customerService = new CustomerService(rep);
            #endregion

            Console.ReadKey();
        }
    }
}
