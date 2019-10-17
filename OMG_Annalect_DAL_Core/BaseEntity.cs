using System;
using System.ComponentModel.DataAnnotations;

namespace OMG_Annalect_DAL_Core
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
