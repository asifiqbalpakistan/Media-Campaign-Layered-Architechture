using Microsoft.AspNetCore.Mvc.Rendering;
using OMG_Annalect_DAL_Core.Interface;
using OMG_Annalect_DAL_Core.Models;
using OMG_Annalect_DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace OMG_Annalect_BL_Core.BusinessObject
{
    public class CampaignBLObject : BaseBL, ICampaignBLObject
    {
        private readonly IGenericRepository<AdvertisementSupplier> _suppRepository;
        private readonly IGenericRepository<Campaign> _campaignRepository;
        private readonly IGenericRepository<Channel> _channelRepository;
        private readonly IGenericRepository<Supplier> _supplierRepository;
        private readonly IDropDownBLObject dropDownBLObject;
        public CampaignBLObject(IDropDownBLObject DropDownBLObject)
        {
            _campaignRepository = UnitOfWork.GenericRepository<Campaign>();
            _suppRepository = UnitOfWork.GenericRepository<AdvertisementSupplier>();
            _channelRepository = UnitOfWork.GenericRepository<Channel>();
            _supplierRepository = UnitOfWork.GenericRepository<Supplier>();
            dropDownBLObject = DropDownBLObject;
        }


        public CampaignModel GetById(object id)
        {
            var campaign = _campaignRepository.GetById(id);
            if (campaign != null)
            {
                campaign.AdvertisementSuppliers = _suppRepository.GetTable().Where(t => t.CampaignId == campaign.Id).ToList();
            }
            var model = new CampaignModel()
            {

                Name = campaign.Name,
                AddedBy = campaign.AddedBy,
                AddedTime = campaign.AddedTime,
                Budget = campaign.Budget,
                CampaignModelId = campaign.Id,
                Country = campaign.Country,
                ClientId = campaign.ClientId,
                StartDateTime = campaign.StartDateTime,
                EndDateTime = campaign.EndDateTime,
                CountryList = dropDownBLObject.GetCountries(),
                ClientList = dropDownBLObject.GetClients(),
                
            };
            if (campaign.AdvertisementSuppliers != null)
            {
                foreach (var supplier in campaign.AdvertisementSuppliers)
                {
                    model.Advertisements.Add(new OMG_Annalect_DomainModels.DomainModel.AdvertisementSupplierModel()
                    {
                        Budget = supplier.Budget,
                        StartDateTime = supplier.StartDateTime,
                        EndDateTime = supplier.EndDateTime,
                        Name = supplier.Name,
                        ChannelName = _channelRepository.GetById(supplier.ChannelId).Name,
                        SupplierName = _supplierRepository.GetById(supplier.SupplierId).Name,
                      SupplierId = supplier.SupplierId,
                      ChannelId = supplier.ChannelId,
                      AdvertisementSupplierId = supplier.Id
                    });
                }
            }
            else
            {
                campaign.AdvertisementSuppliers = new List<AdvertisementSupplier>();
            }
            return model;
        }
        public CampaignModel Insert(CampaignModel entity)
        {
            using (UnitOfWork.BeginTransasction())
            {
                try
                {
                    var campaign = new Campaign();
                    campaign.StartDateTime = entity.StartDateTime;
                    campaign.EndDateTime = entity.EndDateTime;
                    campaign.Budget = entity.Budget;
                    campaign.Name = entity.Name;
                    campaign.Action = entity.Action;
                    campaign.Country = entity.Country;
                    campaign.ClientId = entity.ClientId;
                    campaign.AddedBy = entity.AddedBy;
                    var obj = _campaignRepository.Insert(campaign);
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
        public CampaignModel Update(CampaignModel entity)
        {
            using (UnitOfWork.BeginTransasction())
            {
                try
                {
                    var campaign = _campaignRepository.GetById(entity.CampaignModelId);
                    campaign.Name = entity.Name;
                    campaign.Budget = entity.Budget;
                    campaign.StartDateTime = entity.StartDateTime;
                    campaign.EndDateTime = entity.EndDateTime;
                    campaign.Country = entity.Country;
                    campaign.Action = entity.Action;
                    campaign.ClientId = entity.ClientId;
                    campaign.ModifiedBy = entity.ModifiedBy;
                    _campaignRepository.Update(campaign);
                    UnitOfWork.Commit();
                    return entity;
                }
                catch
                {
                    UnitOfWork.Rollback();
                    return entity;
                }
            }
        }
        public int Delete(CampaignModel entity)
        {
            var campaign = new Campaign();
            campaign.Id = entity.CampaignModelId;
            return _campaignRepository.Delete(campaign);
        }
        public List<CampaignModel> GetTable()
        {
            var response = new List<CampaignModel>();
            var campaigns = _campaignRepository.GetTable().ToList();
            foreach (var item in campaigns)
            {
                response.Add(new CampaignModel()
                {
                    Name = item.Name,
                    Code=item.Code,
                    CampaignModelId = item.Id,
                    AddedBy=item.AddedBy,
                    AddedTime=item.AddedTime,
                    ModifiedBy=item.ModifiedBy,
                    Action = item.Action,
                    ModifiedTime = item.ModifiedTime,
                    IsDeleted = item.IsDeleted,
                    StartDateTime = item.StartDateTime,
                    EndDateTime = item.EndDateTime,
                    Budget = item.Budget,
                    Country = item.Country,
                    ClientId =item.ClientId
                });
            }
            return response;
        }

        public bool DeleteByID(long id)
        {
            try
            {
                return _campaignRepository.DeleteByID(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public ChannelModel InsertChannel(ChannelModel entity)
        {
            using (UnitOfWork.BeginTransasction())
            {
                try
                {
                    var channel = new Channel();
                    channel.Name = entity.Name;
                    channel.IsDeleted = false;
                    channel.ModifiedBy = entity.ModifiedBy;
                    channel.ModifiedTime = DateTime.Now;
                    channel.AddedBy = entity.AddedBy;
                    var obj = _channelRepository.Insert(channel);
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
        public SupplierModel InsertSupplier(SupplierModel entity)
        {
            using (UnitOfWork.BeginTransasction())
            {
                try
                {
                    var supplier = new Supplier();
                    supplier.Name = entity.Name;
                    supplier.IsDeleted = false;
                    supplier.ModifiedBy = entity.ModifiedBy;
                    supplier.ModifiedTime = DateTime.Now;
                    supplier.AddedBy = entity.AddedBy;
                    supplier.ChannelId = entity.Channel.ChannelId;
                    var obj = _supplierRepository.Insert(supplier);
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

    }
}
