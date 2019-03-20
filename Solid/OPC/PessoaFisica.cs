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
