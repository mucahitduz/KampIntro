using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SaleManager
    {
        public void Sale(Game game, Customer customer, Campaign campaign)
        {
            double campaignPrice;
            campaignPrice = game.Price - (game.Price * campaign.Discount / 100);
            Console.WriteLine(customer.FirstName+ " " + game.Name + "oyununu" + " " + campaign.Name + "kampanyasıyla" + " " + game.Price + "TL yerine" + campaignPrice + "Tl ye satın aldı");
        }
    }
}
