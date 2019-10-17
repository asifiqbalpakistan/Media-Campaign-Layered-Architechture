using Microsoft.EntityFrameworkCore;

using OMG_Annalect_DAL_Core;
using OMG_Annalect_DAL_Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMG_Annalect_BL_Core
{
    public class BaseBL
    {
        public IUnitOfWork UnitOfWork;
      
        public BaseBL()
        {
            UnitOfWork = new UnitOfWork();
        }
    }
}
