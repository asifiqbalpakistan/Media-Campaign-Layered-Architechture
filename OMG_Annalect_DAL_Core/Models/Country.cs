using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMG_Annalect_DAL_Core.Models
{
    [Table("tblCountry")]
    public class Country: BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Language { get; set; }
        public string Region { get; set; }
        public string TimeZone { get; set; }
    }
}
