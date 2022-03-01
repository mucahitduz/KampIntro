using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerCheckService _customerCheckService;
        public CustomerManager(ICustomerCheckService customerCheckService) 
        {
            _customerCheckService = customerCheckService;
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Kullanıcı silindi: " + customer.FirstName + " " + customer.LastName);
        }

        public void SignUp(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Kullanıcı kaydedildi: " + customer.FirstName + " " + customer.LastName);
            }
            else
            {
                throw new Exception("Kullanıcı doğrulanamadı");
            }
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Kullanıcı güncellendi: " + customer.FirstName + " " + customer.LastName);
        }
    }
}
