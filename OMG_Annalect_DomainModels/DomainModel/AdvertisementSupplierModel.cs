using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMG_Annalect_DomainModels.DomainModel
{
    public class AdvertisementSupplierModel : BaseModel
    {
        public long CampaignId { get; set; }
        public SelectList ChannelList { get; set; }
        public string ChannelName { get; set; }
        public long ChannelId { get; set; }
        public SelectList SupplierList { get; set; }
        public string SupplierName { get; set; }
        public long SupplierId { get; set; }
        public long AdvertisementSupplierId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double Budget { get; set; }

    }
}
