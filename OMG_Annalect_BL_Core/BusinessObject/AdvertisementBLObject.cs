using OMG_Annalect_DAL_Core.Interface;
using OMG_Annalect_DAL_Core.Models;
using OMG_Annalect_DomainModels.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OMG_Annalect_BL_Core.BusinessObject
{
    public class AdvertisementBLObject : BaseBL, IAdvertisementBLObject
    {
        private readonly IGenericRepository<AdvertisementSupplier> _adsRepository;
        private readonly IGenericRepository<CampaignChannel> _campaignChannelRepository;
        public AdvertisementBLObject()
        {
            _adsRepository = UnitOfWork.GenericRepository<AdvertisementSupplier>();
            _campaignChannelRepository = UnitOfWork.GenericRepository<CampaignChannel>();
        }

        public AdvertisementSupplierCreateModel Insert(AdvertisementSupplierCreateModel entity)
        {
            using (UnitOfWork.BeginTransasction())
            {
                try
                {
                    var adv = new AdvertisementSupplier();
                    adv.StartDateTime = entity.StartDateTime;
                    adv.EndDateTime = entity.EndDateTime;
                    adv.Budget = entity.Budget;
                    adv.Name = entity.Name;
                    adv.ChannelId = entity.ChannelId;
                    adv.SupplierId = entity.SuppplierId;
                    adv.CampaignId = entity.CampaignId;
                    var obj = _adsRepository.Insert(adv);

                    long nextId = 0;
                    var records = _campaignChannelRepository.GetTable().OrderByDescending(t => t.Id);
                    if (records.Count() > 0)
                    {
                        nextId = records.FirstOrDefault().Id + 1;
                    }
                    _campaignChannelRepository.Insert(new CampaignChannel()
                    {
                        ChannelId = entity.ChannelId,
                        CampaignId = entity.CampaignId,
                        AddedBy = entity.AddedBy,
                        Id = nextId
                    });


                    UnitOfWork.Commit();
                    return entity;
                }
                catch (Exception ex)
                {
                    UnitOfWork.Rollback();
                    return entity;
                }
            }
        }

        public List<AdvertisementSupplierCreateModel> GetAdvertisementsByCampaignId(long CampaignId)
        {
            var Adds = new List<AdvertisementSupplierCreateModel>();

            try
            {

                var entity = _adsRepository.GetTable().Where(t => t.CampaignId == CampaignId);
                foreach (var add in entity)
                {
                    AdvertisementSupplierCreateModel model = new AdvertisementSupplierCreateModel
                    {
                     Budget = add.Budget,
                     StartDateTime = add.StartDateTime,
                     EndDateTime = add.EndDateTime
                    };
                    Adds.Add(model);
                }
                return Adds;
            }
            catch (Exception ex)
            {

                return Adds;
            }

        }

        public bool DeleteByID(long id)
        {
            try
            {
                return _adsRepository.DeleteByID(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
                
        }

    }
}
