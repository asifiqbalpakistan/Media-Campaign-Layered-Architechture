using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMG_Annalect_DomainModels
{
    public class ChannelModel : BaseModel
    {
        public ChannelModel() { }
        public ChannelModel(int campaignId)
        {
            CampaignId = campaignId;
        }
        public long ChannelId { get; set; }
        public int? CampaignId { get; set; }
        public int? SupplierId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; } 
        public int? SelectedChannelId { get; set; }
        public List<SupplierModel> Suppliers { get; set; }
        public List<CampaignChannelModel> CampaignChannels { get; set; }
    }
}
