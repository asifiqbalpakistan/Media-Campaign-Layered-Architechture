using System;
using System.Collections.Generic;
using System.Text;

namespace OMG_Annalect_DomainModels
{
   public class CampaignChannelModel
    {
        public long ChannelId { get; set; }
        public long CampaignId { get; set; }
      
        public ChannelModel Channel { get; set; }
      
        public CampaignModel Campaign { get; set; }

    }
}
