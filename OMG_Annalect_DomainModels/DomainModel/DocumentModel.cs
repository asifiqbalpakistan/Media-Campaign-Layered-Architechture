

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using OMG_Annalect_DomainModels.DomainModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace OMG_Annalect_DomainModels
{
    public  class DocumentModel:BaseModel
    {
        public DocumentModel()
        {

        }
        public DocumentModel(int campaignId)
        {
            CampaignId = campaignId;
        }
        [Required]
        public long DocumentId { get; set; }
       
        public string DocumentName { get; set; }
        public string DocumentTypeName { get; set; }
        public int DocumentTypeId { get; set; }
        public DocumentTypeModel DocumentType { get; set; }

        public SelectList DocumentTypes { get; set; }
        public int? CampaignId { get; set; }
        public virtual CampaignModel Campaign { get; set; }

        public Guid guid { get; set; }

        public IFormFile documentFile { get; set; }
    }
}
