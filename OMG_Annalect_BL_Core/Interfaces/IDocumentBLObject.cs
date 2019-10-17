using System.Collections.Generic;
using OMG_Annalect_DomainModels;

namespace OMG_Annalect_BL_Core.BusinessObject
{
    public interface IDocumentBLObject
    {
        List<DocumentModel> GetDocsByCampaignId(long campaignId);
        DocumentModel Insert(DocumentModel entity);
        bool DeleteByID(long id);
        DocumentModel GetDocumentById(long id);
    }
}