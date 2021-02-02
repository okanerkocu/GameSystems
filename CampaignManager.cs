using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignServices
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+" adlı kampanyanız sisteme tanımlandı.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " adlı kampanyanız sistemden silindi.");
        }

        public void Edit(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " adlı kampanyanız düzenlendi.");
        }
    }
}
