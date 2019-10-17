using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OMG_Annalect_DAL_Core.Repositories;
using OMG_Annalect_DAL_Core.Data;

namespace OMG_Annalect_DAL_Core.Interface
{
    public interface IUnitOfWork
    {
        void Commit();
        void SaveAndCommit();
        IDbContextTransaction BeginTransasction();
        void Rollback();
        GenericRepository<T> GenericRepository<T>() where T : BaseEntity;
        ApplicationDbContext GetContext();
    }
}
