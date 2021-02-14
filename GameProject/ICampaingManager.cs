using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaingManager
    {
        void Add();
        void Update();
        void Delete();
        string CampaignName();
    }
}
