using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignServices
    {
        void Add(Campaign campaign);
        void Edit(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
