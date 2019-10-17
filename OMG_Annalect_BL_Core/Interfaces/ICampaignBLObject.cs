using System.Collections.Generic;
using OMG_Annalect_DomainModels;

namespace OMG_Annalect_BL_Core.BusinessObject
{
    public interface ICampaignBLObject
    {
        int Delete(CampaignModel entity);
        CampaignModel GetById(object id);
        List<CampaignModel> GetTable();
        CampaignModel Insert(CampaignModel entity);
        CampaignModel Update(CampaignModel entity);
        bool DeleteByID(long id);
        SupplierModel InsertSupplier(SupplierModel entity);
        ChannelModel InsertChannel(ChannelModel entity);
    }
}