using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OMG_Annalect_BL_Core.BusinessObject;
using OMG_Annalect_DAL_Core.Interface;
using OMG_Annalect_DomainModels;
using OMG_Annalect_DomainModels.DomainModel;

namespace OMG_Annalect_Assessment.Controllers
{
    [Authorize]
    public class CampaignController : Controller
    {
        private ICampaignBLObject campaignBLObject;
        private IAdvertisementBLObject advObj;
        private IDropDownBLObject dropdownObj;
        private IDocumentBLObject docObj;
        public CampaignController(ICampaignBLObject CampaignBLObject, IDropDownBLObject DropdownObj, IAdvertisementBLObject AdvObj, IDocumentBLObject DocObj)
        {
            campaignBLObject = CampaignBLObject;
            dropdownObj = DropdownObj;
            advObj = AdvObj;
            docObj = DocObj;
        }
        public IActionResult InsertSupplier()
        {

            ViewBag.SupplierList = dropdownObj.GetSuppliers();
            ViewBag.ChannelList = dropdownObj.GetChannels();
            return View(new ChannelModel());
        }
        public IActionResult InsertDocument()
        {

            ViewBag.DocumentTypes = new SelectList(new List<string>(), "DocumentTypeId", "DocumentTypeId");
            return View(new DocumentModel());
        }

        public IActionResult Index()
        {
            var models = new List<CampaignModel>();
            if (User.IsInRole("Planner"))
                models = campaignBLObject.GetTable().Where(x => x.Action == "AssigntoPlanner" || x.AddedBy == User.Identity.Name).OrderByDescending(s => s.CampaignModelId).ToList();
            else if (User.IsInRole("Manager"))
                models = campaignBLObject.GetTable().Where(x => x.Action == "AssigntoManager" || x.AddedBy == User.Identity.Name).OrderByDescending(s => s.CampaignModelId).ToList();
            else if (User.IsInRole("Client"))
            { 
                models = campaignBLObject.GetTable().OrderByDescending(s => s.CampaignModelId).ToList();
            }
            if (User.IsInRole("Admin"))
                return RedirectToAction("UserList", "Account");

           return View(models);
        }
        public IActionResult Create()
        {
            var model = new CampaignModel()
            {
                ClientList = dropdownObj.GetClients(),
                CountryList = dropdownObj.GetCountries()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CampaignModel model)
        {
            if (ModelState.IsValid)
            {
                model.AddedBy = User.Identity.Name;
                var avb = campaignBLObject.Insert(model);
                return RedirectToAction("Index", new { message = avb.Name });
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateCampaign(CampaignModel model)
        {
            var avb = campaignBLObject.Update(model);
           
            return Json(new { success = true, campaign = avb.Name });
        }

        public IActionResult Edit(int id)
        {
            var model = new CampaignEditModel();
            model.CampaignModel = campaignBLObject.GetById(id);
            model.AdsCreateModel = new AdvertisementSupplierCreateModel()
            {
                SupplierList = dropdownObj.GetSuppliers(),
                ChannelList = dropdownObj.GetChannels(),
                CampaignId = id

            };
            IList<SelectListItem> list = Enum.GetValues(typeof(CampaignAction)).Cast<Enum>().Select(x => new SelectListItem { Text = x.ToString(), Value = x.ToString() }).ToList();
            model.CampaignModel.ActionList = new SelectList(list, "Text", "Value");
            model.Document = new DocumentModel()
            {
                DocumentTypes = dropdownObj.GetDocTypes(),
                CampaignId = id
            };

            model.DocumentsList = docObj.GetDocsByCampaignId(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult InsertAdvertisement(AdvertisementSupplierCreateModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {


                    var Campaignmodel = campaignBLObject.GetById(model.CampaignId);
                    if (Campaignmodel != null)
                    {

                        var advertisementModel = Campaignmodel.Advertisements;


                        var SameChannelSameSupplier = advertisementModel.Where(t => t.ChannelId == model.ChannelId && t.SupplierId == model.SuppplierId);


                        double AllBudgte = advertisementModel.Sum(x => x.Budget);
                        AllBudgte += model.Budget;
                        if (model.Budget > Campaignmodel.Budget)
                            return Json(new { success = false, title = "Budget can't be greater than campaign budget" });
                        else if (model.StartDateTime < Campaignmodel.StartDateTime || model.EndDateTime > Campaignmodel.EndDateTime)
                            return Json(new { success = false, title = "Start and end date must be within campaing date range." });
                        else if (AllBudgte > Campaignmodel.Budget)
                            return Json(new { success = false, title = "Budget can't be greater than campaign budget" });
                        else
                        {
                            foreach (var item in SameChannelSameSupplier)
                            {
                                if (model.StartDateTime <= item.StartDateTime || model.EndDateTime >= item.EndDateTime)
                                    return Json(new { success = false, title = "Start and end date should not be within range for same advertisement." });
                            }
                        }
                    }



                    model.AddedBy = User.Identity.Name;
                    var response = advObj.Insert(model);
                    return Json(new { success = true, adv = response.Name });
                }
                return Json(new { success = false });

            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public IActionResult UploadDocument(DocumentModel document)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (document.documentFile != null)
                    {
                        if (document.DocumentTypeId == 0)
                        {
                            return Json(new { success = false });
                        }
                        document.guid = Guid.NewGuid();

                        var fileName = Path.GetFileName(document.documentFile.FileName);

                        var path = Path.Combine(
                      Directory.GetCurrentDirectory(), "wwwroot/Uploads/Campaign/", document.guid.ToString());

                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);

                        using (var stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                        {
                            document.documentFile.CopyTo(stream);
                        }


                        document.DocumentName = fileName;
                        document.AddedBy = User.Identity.Name;
                        document.AddedTime = DateTime.Now;
                        document.ModifiedBy = User.Identity.Name;
                        document.ModifiedTime = DateTime.Now;
                        document.IsDeleted = false;
                        docObj.Insert(document);
                        return Json(new { success = true });
                    }
                }
                return Json(new { success = false });
            }
            catch (Exception ex)
            {
                var exx = ex;
            }
            return Json(new { success = false });
        }
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
        public ActionResult DeleteAdvertisement(long id)
        {

            if (id > 0)
            {

                var response = advObj.DeleteByID(id);
                if (response)
                    return Json(new { success = true });
                else
                    return Json(new { success = false });
            }

            return Json(new { success = false });
        }
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
        public ActionResult DeleteDocument(long id)
        {

            if (id > 0)
            {

                var response = docObj.DeleteByID(id);
                if (response)
                    return Json(new { success = true });
                else
                    return Json(new { success = false });
            }

            return Json(new { success = false });
        }
        [HttpPost]
        [Authorize(Roles = "Admin,Manager")]
        public ActionResult DeleteCampaign(long id)
        {

            if (id > 0)
            {

                var response = campaignBLObject.DeleteByID(id);

                return Json(new { success = true });

            }

            return Json(new { success = false });
        }

        public ActionResult DownloadFile(long id)
        {
            var document = docObj.GetDocumentById(id);
            if (document != null)
            {
                string filename = document.DocumentName;

                string folderpath = Path.Combine(
                  Directory.GetCurrentDirectory(), "wwwroot/Uploads/Campaign/", document.guid.ToString());
                if (Directory.Exists(folderpath))
                {
                    string filepath = Path.Combine(folderpath, filename);
                    var memory = new MemoryStream();
                    using (var stream = new FileStream(filepath, FileMode.Open))
                    {
                        stream.CopyTo(memory);
                    }
                    memory.Position = 0;
                    return File(memory, GetContentType(filepath), filename);
                }

            }
            return Json(new { success = false });
        }
        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats  officedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"},
                 {".xml", "text/xml"}
            };
        }
        [HttpGet]
        public ActionResult GetSupplier(long id)
        {

            var suppliers = dropdownObj.GetSuppliersById(id).Select(x => new
            {
                Value = x.Value,
                Text = x.Text
            });
            return Json(suppliers);
        }


        public ActionResult GenerateXmlFile(long id)
        {
            if (id > 0)
            {
                try
                {
                    var model = campaignBLObject.GetById(id);
                    var fileName = model.Name + "_" + "Campaign.xml";
                    string folderpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Campaign/");

                    if (!Directory.Exists(folderpath))
                        Directory.CreateDirectory(folderpath);

                    XmlTextWriter writer = new XmlTextWriter(Path.Combine(folderpath, fileName), System.Text.Encoding.UTF8);

                    writer.Formatting = Formatting.Indented;
                    writer.Indentation = 2;
                    writer.WriteStartDocument(true);
                    writer.WriteStartElement("Campaign");
                    writer.WriteStartElement("Campaign_Name");
                    writer.WriteString(model.Name);
                    writer.WriteEndElement();
                    writer.WriteStartElement("Country");
                    writer.WriteString(model.Country);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Budget");
                    writer.WriteString(model.Budget.ToString());
                    writer.WriteEndElement();

                    writer.WriteStartElement("Campaign_Start_Date");
                    writer.WriteString(model.StartDateTime.ToShortDateString().ToString());
                    writer.WriteEndElement();

                    writer.WriteStartElement("Campaign_End_Date");
                    writer.WriteString(model.EndDateTime.ToShortDateString().ToString());
                    writer.WriteEndElement();

                    writer.WriteStartElement("Advertisement_Details");
                    foreach (var item in model.Advertisements)
                    {
                        CreateNode(item.Name, item.ChannelName, item.SupplierName, item.Budget.ToString(), item.StartDateTime.ToShortDateString(), item.StartDateTime.ToShortDateString(), writer);
                    }

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Close();
                    var memory = new MemoryStream();
                    string filepath = Path.Combine(folderpath, fileName);
                    using (var stream = new FileStream(filepath, FileMode.Open))
                    {
                        stream.CopyTo(memory);
                    }
                    memory.Position = 0;
                    return File(memory, GetContentType(filepath), fileName);


                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
                return RedirectToAction("Index", "Campaign");

        }

        private void CreateNode(string AdName, string Channel, string Supplier, string AdBudget, string Startdate, string Enddate, XmlTextWriter writer)
        {
            writer.WriteStartElement("Advertisement");
            writer.WriteStartElement("Addvertisement_Name");
            writer.WriteString(AdName);
            writer.WriteEndElement();
            writer.WriteStartElement("Channel");
            writer.WriteString(Channel);
            writer.WriteEndElement();
            writer.WriteStartElement("Supplier");
            writer.WriteString(Supplier);
            writer.WriteEndElement();
            writer.WriteStartElement("Ad_Budget");
            writer.WriteString(AdBudget);
            writer.WriteEndElement();
            writer.WriteStartElement("Start_Date");
            writer.WriteString(Startdate);
            writer.WriteEndElement();
            writer.WriteStartElement("End_Date");
            writer.WriteString(Enddate);
            writer.WriteEndElement();

            writer.WriteEndElement();
        }


        public IActionResult Dashboard()
        { return View(); }

        public IActionResult AddSupplier(long id)
        {
            try
            {
                var suppliers = dropdownObj.GetSuppliersById(id);

                var model = new AdvertisementSupplierCreateModel()
                {
                    SupplierList = suppliers

                };
                return PartialView("AddSupplier", model);
            }
            catch (Exception)
            {

                throw;
            }

           
        }


        public IActionResult Reports()
        {
            ViewBag.ClientList = dropdownObj.GetClients();
            ViewBag.CountryList = dropdownObj.GetCountries();
            return View(new List<CampaignModel>());
        }

    }
}