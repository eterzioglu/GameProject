using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IOrderManager
    {
        void Order(Order order, Gamer gamer);
        void OrderWithCampaign(Order order, Gamer gamer, ICampaingManager campaign);
    }
}
