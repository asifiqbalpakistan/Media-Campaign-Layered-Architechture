using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using OMG_Annalect_DomainModels.DomainModel;

namespace OMG_Annalect_BL_Core.BusinessObject
{
    public interface IDropDownBLObject
    {
        SelectList GetSuppliers();
        SelectList GetChannels();
        SelectList GetCountries();
        SelectList GetDocTypes();
        SelectList GetClients();

        SelectList GetSuppliersById(long id);

    }
}