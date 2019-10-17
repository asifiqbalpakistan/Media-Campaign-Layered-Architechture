using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMG_Annalect_DAL_Core.Models
{
    [Table("tblAdvertisementSupplier")]
    public class AdvertisementSupplier : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string SupplierName { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double Budget { get; set; }

        public long SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }

        public long ChannelId { get; set; }
        [ForeignKey("ChannelId")]
        public virtual Channel Channel { get; set; }

        public long CampaignId { get; set; }
        [ForeignKey("CampaignId")]
        public virtual Campaign Campaign { get; set; }
    }
}
