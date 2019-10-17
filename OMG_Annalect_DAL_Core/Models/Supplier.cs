using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMG_Annalect_DAL_Core.Models
{
    [Table("tblSupplier")]
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public long ChannelId { get; set; }
        
        public virtual ICollection<AdvertisementSupplier> AdvertisementSuppliers { get; set; }
    }
}
