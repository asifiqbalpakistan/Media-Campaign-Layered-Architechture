using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMG_Annalect_DAL_Core.Models
{
    [Table("tblChannel")]
    public class Channel : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }

     
        public virtual ICollection<AdvertisementSupplier> AdvertisementSuppliers { get; set; }
        public virtual ICollection<CampaignChannel> CampaignChannels { get; set; }
    }
}
