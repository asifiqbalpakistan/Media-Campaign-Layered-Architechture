using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Web;

namespace OMG_Annalect_DAL_Core.Models
{
    [Table("tblDocuments")]
    public class Documents : BaseEntity
    {
        public Documents()
        {

        }
        public Documents(int campaignId)
        {
            CampaignId = campaignId;
        }
        public Guid guid { get; set; }
        public string DocumentName { get; set; }
        public int DocumentTypeId { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public int? CampaignId { get; set; }
        public virtual Campaign Campaign { get; set; }
        [NotMapped]
        public IFormFile documentFile { get; set; }

    }
}
