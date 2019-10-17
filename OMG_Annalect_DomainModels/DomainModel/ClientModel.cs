using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OMG_Annalect_DomainModels
{
    public class ClientModel: BaseModel
    {
        public long ClientId { get; set; }
        
        [Required(ErrorMessage = "Client Name is required")]
        [Display(Name = "Client Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address1 is required")]
        [Display(Name = "Client Address1")]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [Required(ErrorMessage = "Contact Number is required")]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
        [Required(ErrorMessage = "Client Email is required")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }
        [Display(Name = "Fax Number")]
        public string FaxNumber { get; set; }
        [Required(ErrorMessage = "Contact Person is required")]
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
        public string Industry { get; set; }
        public List<string> Industries { get; set; }

        [Required]
        [Display(Name = "Document Access")]
        public bool IsDocumentAccess { get; set; }
    }
}
