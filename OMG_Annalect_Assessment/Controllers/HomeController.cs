using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OMG_Annalect_Assessment.Models;
using OMG_Annalect_BL_Core.BusinessObject;
using OMG_Annalect_DomainModels;

namespace OMG_Annalect_Assessment.Controllers
{
    public class HomeController : Controller
    {
        private ICampaignBLObject campaignBLObject;
        private IDropDownBLObject dropdownObj;


        public HomeController(ICampaignBLObject CampaignBLObject, IDropDownBLObject DropdownObj)
        {
            campaignBLObject = CampaignBLObject;
            dropdownObj = DropdownObj;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Campaign");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult CreateChannel()
        {
            return View(new ChannelModel());
        }
        [HttpPost]
        public IActionResult CreateChannel(ChannelModel channelModel)
        {

            if (ModelState.IsValid)
            {
                channelModel.AddedBy = User.Identity.Name;
                channelModel.AddedTime = DateTime.Now;
                channelModel.ModifiedBy = User.Identity.Name;
                channelModel.ModifiedTime = DateTime.Now;
                channelModel.IsDeleted = false;
                campaignBLObject.InsertChannel(channelModel);
                return RedirectToAction("ChannelsList", "Home");
            }
            else
                return RedirectToAction("ChannelsList", "Home");
        }
        [HttpGet]
        public IActionResult CreateSupplier()
        {
            ViewBag.ChannelList = dropdownObj.GetChannels();
            return View(new SupplierModel());
        }

        [HttpPost]
        public IActionResult CreateSupplier(SupplierModel supplierModel)
        {

            if (ModelState.IsValid)
            {
                supplierModel.AddedBy = User.Identity.Name;
                supplierModel.AddedTime = DateTime.Now;
                supplierModel.ModifiedBy = User.Identity.Name;
                supplierModel.ModifiedTime = DateTime.Now;
                supplierModel.IsDeleted = false;
                campaignBLObject.InsertSupplier(supplierModel);
                return RedirectToAction("SupplierList", "Home");
            }
            else
                return RedirectToAction("SupplierList", "Home");
        }

        public IActionResult ChannelsList()
        {
            var channelModels = new List<ChannelModel>();
            var ChannelList = dropdownObj.GetChannels();
            foreach (var item in ChannelList)
            {
                var model = new ChannelModel()
                {
                    Name = item.Text
                };
                channelModels.Add(model);
            }
            return View(channelModels);

        }
        [HttpPost]
        public IActionResult DeleteChannel(string id)
        {
            if (id == null)
            {
                return RedirectToAction("ChannelsList", "Home");
            }

            try
            {
                var user = true;//= campaignBLObject.DeleteClient(id);
                if (user)
                    return Json(new { success = true });
                else
                    return Json(new { success = false });
            }
            catch (Exception)
            {
                return Json(new { success = false });
                throw;
            }
        }
        [HttpPost]
        public IActionResult DeleteSupplier(string id)
        {
            if (id == null)
            {
                return RedirectToAction("SupplierList", "Home");
            }

            try
            {
                var user = true;//= campaignBLObject.DeleteClient(id);
                if (user)
                    return Json(new { success = true });
                else
                    return Json(new { success = false });
            }
            catch (Exception)
            {
                return Json(new { success = false });
                throw;
            }
        }
        public IActionResult SupplierList()
        {
            var supplierModel = new List<SupplierModel>();
            var selectLists = dropdownObj.GetSuppliers();
            foreach (var item in selectLists)
            {
                var model = new SupplierModel()
                {
                    Name = item.Text
                };
                supplierModel.Add(model);
            }
            return View(supplierModel);

        }

    }

}
