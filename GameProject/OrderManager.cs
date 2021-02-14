using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderManager
    {
        public void Order(Order order, Gamer gamer)
        {
            Console.WriteLine(order.OrderName + " ordered by " + gamer.Name);
        }

        public void OrderWithCampaign(Order order, Gamer gamer, ICampaingManager campaign)
        {
            Console.WriteLine(order.OrderName + " ordered by " + gamer.Name + " with "  + campaign.CampaignName());
        }
    }
}
