using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new ValidationManager());

            List<Gamer> gamers = new List<Gamer>();

            #region Gamer
            Gamer gamer = new Gamer() { Id = 1, YearOfBrith = 1997, Name = "Ebru", Surname = "TERZIOGLU", IdentityNumber = "123456987" };
            gamerManager1.Add(gamer,gamers);
            gamerManager1.Update(gamer);
            gamerManager1.Delete(gamer,gamers);
            Console.WriteLine("\n-----------------------\n");
            #endregion

            #region Orders
            Order order1 = new Order() { OrderId = 1, OrderName = "Fortnite", Price = "0" };
            Order order2 = new Order() { OrderId = 2, OrderName = "Pubg", Price = "50" };
            Order order3 = new Order() { OrderId = 3, OrderName = "Cs Go", Price = "100" };
            #endregion

            #region Campaign
            ICampaingManager christmasCampaign = new ChristmasCampaign();
            ICampaingManager welcomeCampaign = new WelcomeCompaign();

            christmasCampaign.Add();
            welcomeCampaign.Add();

            Console.WriteLine("-----------------------");

            christmasCampaign.Update();
            welcomeCampaign.Update();

            Console.WriteLine("-----------------------");

            christmasCampaign.Delete();
            welcomeCampaign.Delete();
            #endregion

            #region OrderManager
            OrderManager orderManager = new OrderManager();
            Console.WriteLine("\n-----------Order without campaign------------");
            orderManager.Order(order1, gamer);

            Console.WriteLine("\n-----------Order with campaign------------");
            orderManager.OrderWithCampaign(order1, gamer, welcomeCampaign);
            #endregion

        }
    }
}
