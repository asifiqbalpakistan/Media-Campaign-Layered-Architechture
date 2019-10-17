using Microsoft.AspNetCore.Mvc.Rendering;
using OMG_Annalect_DAL_Core.Interface;
using OMG_Annalect_DAL_Core.Models;
using OMG_Annalect_DomainModels.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OMG_Annalect_BL_Core.BusinessObject
{
    public class DropDownBLObject : BaseBL, IDropDownBLObject
    {
        private readonly IGenericRepository<Supplier> _supplierRepository;
        private readonly IGenericRepository<Channel> _chennelRepository;
        private readonly IGenericRepository<Country> _countryRepository;
        private readonly IGenericRepository<DocumentType> _docTypeRepository;
        private readonly IGenericRepository<Client> _clientRepository;
        public DropDownBLObject()
        {
            _supplierRepository = UnitOfWork.GenericRepository<Supplier>();
            _chennelRepository = UnitOfWork.GenericRepository<Channel>();
            _countryRepository = UnitOfWork.GenericRepository<Country>();
            _docTypeRepository = UnitOfWork.GenericRepository<DocumentType>();
            _clientRepository = UnitOfWork.GenericRepository<Client>();
        }

        public SelectList GetSuppliers()
        {
            var response = new List<GenericDropdownModel>();
            var suppliers = _supplierRepository.GetTable();
            foreach (var item in suppliers)
            {
                response.Add(new GenericDropdownModel()
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            return new SelectList(response, "Id", "Name");
        }
        public SelectList GetSuppliersById(long id)
        {
            var response = new List<GenericDropdownModel>();
            var suppliers = _supplierRepository.GetTable().Where(t => t.ChannelId==id).ToList();
            foreach (var item in suppliers)
            {
                response.Add(new GenericDropdownModel()
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            return new SelectList(response, "Id", "Name");
        }
        public SelectList GetChannels()
        {
            var response = new List<GenericDropdownModel>();
            var suppliers = _chennelRepository.GetTable();
            foreach (var item in suppliers)
            {
                response.Add(new GenericDropdownModel()
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            return new SelectList(response, "Id", "Name");
        }

        public SelectList GetCountries()
        {
            var response = new List<GenericDropdownModel>();
            var suppliers = _countryRepository.GetTable();
            foreach (var item in suppliers)
            {
                response.Add(new GenericDropdownModel()
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            return new SelectList(response, "Name", "Name");
        }

        public SelectList GetDocTypes()
        {
            var response = new List<GenericDropdownModel>();
            var suppliers = _docTypeRepository.GetTable();
            foreach (var item in suppliers)
            {
                response.Add(new GenericDropdownModel()
                {
                    Id = item.Id,
                    Name = item.DocumentTypeName
                });
            }
            return new SelectList(response, "Id", "Name");
        }

        public SelectList GetClients()
        {
            var response = new List<GenericDropdownModel>();
            var suppliers = _clientRepository.GetTable();
            foreach (var item in suppliers)
            {
                response.Add(new GenericDropdownModel()
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            return new SelectList(response, "Id", "Name");
        }
    }
}
