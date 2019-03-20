using System;

namespace Solid.LSP
{
    public abstract class Veiculo
    {
        public virtual void LigarMotor()
        {
            Console.WriteLine("Ligou o motor (PAI)");
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelerou (PAI)");
        }
    }
}
