using FluentValidator;
using FluentValidator.Validation;

namespace DapperShop.Domain.StoreContext.ValueObjects
{
    public class Email : Notifiable
    {
        public string Address { get; private set; }

        public Email(string address)
        {
            Address = address;

            AddNotifications(new ValidationContract()
                .Requires()
                .IsEmail(Address, "Address", "Email inválido")
            );
        }

        public override string ToString()
        {
            return Address;
        }
    }
}