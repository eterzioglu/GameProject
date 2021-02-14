using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class ChristmasCampaign : ICampaingManager
    {
        public void Add()
        {
            Console.WriteLine("Christmas Campaign Added");
        }



        public void Delete()
        {
            Console.WriteLine("Christmas Campaign Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Christmas Campaign Updated");
        }

        public string CampaignName()
        {
            return "Christmas Campaign";
        }
    }
}
