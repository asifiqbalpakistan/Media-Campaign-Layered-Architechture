using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace OMG_Annalect_DAL_Core.Models
{
    [Table("tblCampaign")]
    public class Campaign : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public string Status { get; set; }
        public string Action { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public Double Budget { get; set; }
        public virtual ICollection<CampaignChannel> CampaignChannels { get; set; }
        public virtual ICollection<AdvertisementSupplier> AdvertisementSuppliers { get; set; }
        public virtual ICollection<Documents> Documents { set; get; }

        public long ClientId { get; set; }
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
    }

    
}
