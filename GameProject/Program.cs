using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Mücahit";
            customer1.LastName = "Düz";
            customer1.DateOfBirth = new DateTime(1997, 6, 6);
            customer1.NationalityId = "11111111111";

            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            customerManager.SignUp(customer1);

            Game game = new Game();
            game.Id = 1;
            game.Name = "Elden Ring";
            game.Price = 500;

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.Name = "Winter Sale";
            campaign.Discount = 20;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            
        }
    }
}
