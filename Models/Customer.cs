using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }


    }

    public class CustomerVm
    {
        IList<Customer> customers = new List<Customer>()
        {
            new Customer()
            {
                Id = 1,
                Address = "Los Angelas",
                FirstName = "jacobs",
                LastName = "Turesa",
                Gender = "male",
                PhoneNumber = "+234802331209"
            },
            new Customer()
            {
                Id = 2,
                Address = "Las vegas",
                FirstName = "Micheal",
                LastName = "Chiris",
                Gender = "male",
                PhoneNumber = "+23480433190"
            },
            new Customer()
            {
                Id = 3,
                Address = "lagos Angelas",
                FirstName = "Fredrick",
                LastName = "Onos",
                Gender = "male",
                PhoneNumber = "+234804331493"
            },
            new Customer()
            {
                Id = 4,
                Address = "Moles Joud",
                FirstName = "Mary",
                LastName = "Turesa",
                Gender = "female",
                PhoneNumber = "+234904331209"
            },

            new Customer()
            {
                Id = 5,
                Address = "Angela Vegal",
                FirstName = "Juliet",
                LastName = "Turesa",
                Gender = "female",
                PhoneNumber = "+234234331209"
            },
        };
        public IList<Customer> CustomerList()
        {
            return customers;
        }

        public Customer Get(int id)
        {
            var customer = customers.Where(a => a.Id == id).SingleOrDefault();
            return customer;
        }

    }

    
}
