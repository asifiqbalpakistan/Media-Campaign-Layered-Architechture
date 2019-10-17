using Microsoft.AspNetCore.Mvc.Rendering;
using OMG_Annalect_DomainModels.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMG_Annalect_DomainModels
{
    public class CampaignEditModel
    {
        public CampaignEditModel()
        {
            CampaignModel = new CampaignModel();
            DocumentsList = new List<DocumentModel>();
            Document = new DocumentModel();
            AdsCreateModel = new AdvertisementSupplierCreateModel();
        }
        public CampaignModel CampaignModel { get; set; }
        public List<DocumentModel> DocumentsList { get; set; }
        public DocumentModel Document { get; set; }
        public AdvertisementSupplierCreateModel AdsCreateModel { get; set; }
    }
}