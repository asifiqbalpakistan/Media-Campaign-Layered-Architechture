using OMG_Annalect_DAL_Core.Interface;
using OMG_Annalect_DAL_Core.Models;
using OMG_Annalect_DomainModels.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OMG_Annalect_DomainModels;

namespace OMG_Annalect_BL_Core.BusinessObject
{
    public class DocumentBLObject : BaseBL, IDocumentBLObject
    {
        private readonly IGenericRepository<Documents> _docRepository;
        private readonly IGenericRepository<DocumentType> _typeRepository;
        public DocumentBLObject()
        {
            _docRepository = UnitOfWork.GenericRepository<Documents>();
            _typeRepository = UnitOfWork.GenericRepository<DocumentType>();
        }

        public List<DocumentModel> GetDocsByCampaignId(long campaignId)
        {
            var response = new List<DocumentModel>();
            var records = _docRepository.GetTable().Where(t => t.CampaignId == campaignId).ToList();
            foreach (var record in records)
            {
                response.Add(new DocumentModel()
                {
                    DocumentName = record.DocumentName,
                    DocumentTypeName = _typeRepository.GetById(record.DocumentTypeId).DocumentTypeName,
                    AddedBy = record.AddedBy,
                    DocumentId=record.Id
                }) ;
            }
            return response;
        }

        public DocumentModel Insert(DocumentModel entity)
        {
            using (UnitOfWork.BeginTransasction())
            {
                try
                {
                    var doc = new Documents();
                    doc.guid = entity.guid;
                    doc.CampaignId = entity.CampaignId;
                    doc.DocumentName = entity.DocumentName;
                    doc.DocumentTypeId = entity.DocumentTypeId;
                    doc.AddedBy = entity.AddedBy;
                    _docRepository.Insert(doc);
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
        public bool DeleteByID(long id)
        {
            try
            {
                return _docRepository.DeleteByID(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public DocumentModel GetDocumentById(long id)
        {

            try
            {
                var docModel = new DocumentModel();
                var records = _docRepository.GetTable().Where(t => t.Id == id).FirstOrDefault();
                if (records != null)
                {
                    docModel.documentFile = records.documentFile;
                    docModel.guid = records.guid;
                    docModel.DocumentName = records.DocumentName;

                }
              
                return docModel;
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }

    }
}
