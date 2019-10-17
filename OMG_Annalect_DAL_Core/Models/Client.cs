using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMG_Annalect_DAL_Core.Models
{
    [Table("tblClient")]
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ContactNumber { get; set; }
        public string FaxNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Industry { get; set; }
        public virtual ICollection<Campaign> Campaigns { set; get; }

    }
}
