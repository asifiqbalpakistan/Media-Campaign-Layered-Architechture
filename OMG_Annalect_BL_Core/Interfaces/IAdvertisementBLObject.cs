using OMG_Annalect_DomainModels.DomainModel;
using System.Collections.Generic;

namespace OMG_Annalect_BL_Core.BusinessObject
{
    public interface IAdvertisementBLObject
    {
        AdvertisementSupplierCreateModel Insert(AdvertisementSupplierCreateModel entity);
        List<AdvertisementSupplierCreateModel> GetAdvertisementsByCampaignId(long CampaignId);
        bool DeleteByID(long id);
    }
}