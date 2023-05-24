using Univali.Api.Entities;

namespace Univali.Api
{
    //Classe sem parametro
    public class Data 
    {

        private static Data instance;
        public List<Customer> Customers {get; set;}
        private Data() {
            Customers = new List<Customer>(){
                new Customer
                {
                    Id = 1,
                    Name = "Linus Torvalds",
                    Cpf = "73473943096"
                },
                new Customer
                {
                    Id = 2,
                    Name = "Elon Musk",
                    Cpf = "95395994076"
                }
            };
        }

        public static Data getInstance () {
            if(instance == null) {
                instance = new Data();
            }
            return instance;
        }
    }
}