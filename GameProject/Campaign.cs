using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class Campaign
    {
        public int CampaignRate { get; set; }
        public string CampaignName { get; set; }

        public static decimal CampaignResult(Campaign campaign,Game game)
        {

            var rate=campaign.CampaignRate;
            var price = game.UnitPrice;
            var result=price-(rate*price/100);
            return result;
        }


    }
}
