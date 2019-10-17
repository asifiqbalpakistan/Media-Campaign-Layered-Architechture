using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMG_Annalect_DAL_Core.Models
{
    [Table("tblCampaignChannel")]
    public class CampaignChannel : BaseEntity
    {
        public long ChannelId { get; set; }
        public long CampaignId { get; set; }
        [ForeignKey("ChannelId")]
        public virtual Channel Channel { get; set; }
        [ForeignKey("CampaignId")]
        public virtual Campaign Campaign { get; set; }
        
    }
}
