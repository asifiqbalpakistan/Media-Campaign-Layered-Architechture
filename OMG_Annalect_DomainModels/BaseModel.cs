using System;
using System.Collections.Generic;
using System.Text;

namespace OMG_Annalect_DomainModels
{
    public class BaseModel
    {
        public string AddedBy { get; set; }
        public DateTime AddedTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
