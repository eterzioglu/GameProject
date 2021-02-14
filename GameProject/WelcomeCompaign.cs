using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class WelcomeCompaign : ICampaingManager
    {
        public void Add()
        {
            Console.WriteLine("Welcome Campaign Added");
        }

        public void Delete()
        {
            Console.WriteLine("Welcome Campaign Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Welcome Campaign Updated");
        }

        public string CampaignName()
        {
            return "Welcome Campaign";
        }
    }
}
