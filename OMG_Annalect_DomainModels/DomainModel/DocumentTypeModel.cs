using System;
using System.Collections.Generic;
using System.Text;

namespace OMG_Annalect_DomainModels.DomainModel
{
   public class DocumentTypeModel:BaseModel
    {
     

            public string DocumentTypeName { get; set; }

            public bool IsRequired { get; set; }
        
    }
}
