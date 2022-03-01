using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface ICustomerService
    {
        void SignUp(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);

    }
}
