using Microsoft.AspNetCore.Mvc.Rendering;
using OMG_Annalect_DomainModels.DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace OMG_Annalect_DomainModels
{
    public class CampaignModel : BaseModel
    {
        public CampaignModel()
        {
            Advertisements = new List<AdvertisementSupplierModel>();
        }
        public long CampaignModelId { get; set; }

       // [Required(ErrorMessage = "Client Name is required")]
        [Display(Name = "Client Name")]
        public long ClientId { get; set; }

        //[Required(ErrorMessage = "Country Name is required")]
        [Display(Name = "Country Name")]
        public string Country { get; set; }
        public SelectList ActionList { get; set; }
        public SelectList ClientList { get; set; }
        public SelectList CountryList { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Campaign Name")]
        public string Name { get; set; }
        [Display(Name = "Campaign Code")]
        public string Code { get; set; }
        public string Language { get; set; }
        public List<string> LanguageList { get; set; }
        public string Region { get; set; }
        public string Action { get; set; }
        public string Status { get; set; }
        public List<string> RegionList { get; set; }
        public string TimeZone { get; set; }
        [Required(ErrorMessage = "Campaign Start DateTime is required")]
        [Display(Name = "Campaign Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDateTime { get; set; }
        [Required(ErrorMessage = "Campaign End DateTime is required")]
        [Display(Name = "Campaign End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDateTime { get; set; }
        [Required(ErrorMessage = "Budget is required")]
        [Display(Name = "Campaign Budget")]
        public Double Budget { get; set; }
        public List<ChannelModel> Channels { get; set; }
        public List<DocumentModel> Documents { get; set; }

        public List<AdvertisementSupplierModel> Advertisements { get; set; }
    }
    public enum CampaignStatus
    {
        [Display(Name = "New")]
        New = 1,
        [Display(Name = "In Progress")]
        InProgress = 2,
        [Display(Name = "Closed")]
        Closed = 3,
        [Display(Name = "Declined")]
        Declined = 4
    }
    public enum CampaignAction
    {
        [Display(Name = "Assign to Planner")]
        AssigntoPlanner = 1,
        [Display(Name = "Assign to Manager")]
        AssigntoManager = 2
    }
}
