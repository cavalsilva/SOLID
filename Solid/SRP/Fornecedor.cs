using Solid.SRP.Services;

namespace Solid.SRP
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void ChangeName(string name)
        {
            this.Name = name;

            //Disparar evento para informar o RH sobre mudança de nome
            NotificationService.Notify("rh@minhaempresa.com");
        }
    }
}
