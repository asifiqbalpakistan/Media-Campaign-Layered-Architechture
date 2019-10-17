using System;
using System.Collections.Generic;
using System.Text;

namespace OMG_Annalect_DomainModels
{
    public class SupplierModel : BaseModel
    {
        public long SupplierId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ChannelModel Channel { get; set; }
    }
}
