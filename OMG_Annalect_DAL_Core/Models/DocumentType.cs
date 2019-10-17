using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMG_Annalect_DAL_Core.Models
{
    [Table("tblDocumentType")]
    public class DocumentType : BaseEntity
    {
      
        public string DocumentTypeName { get; set; }
     
        public bool IsRequired { get; set; }
    }
}
