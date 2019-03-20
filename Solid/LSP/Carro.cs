using System;

namespace Solid.LSP
{
    public class Carro : Veiculo
    {
        public override void LigarMotor()
        {
            Console.WriteLine("Ligar motor (Filho)");
            base.LigarMotor();
        }
    }
}
