using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace OMG_Annalect_DAL_Core.Interface
{
    public interface IGenericRepository<T>
    {
        T GetById(object id);
        T Insert(T entity);
        T Update(T entity);
        int Delete(T entity);
        List<T> GetTable();

        bool DeleteByID(object id);
    }
}
