using Microsoft.EntityFrameworkCore;
using OMG_Annalect_DAL_Core.Data;
using OMG_Annalect_DAL_Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OMG_Annalect_DAL_Core.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> _entities;
        readonly string _errorMessage = string.Empty;


        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;

        }
        public T GetById(object id) => Entities.FirstOrDefault(t => t.Id == (long)id);

        public T Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }
                entity.AddedTime = DateTime.Now;
                Entities.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception dbEx)
            {
                throw new Exception(_errorMessage, dbEx);
            }
        }

        public List<T> InsertRange(List<T> entities)
        {
            try
            {
                if (entities.Count > 0)
                {
                    foreach (var entity in entities)
                    {
                        entity.AddedTime = DateTime.Now;
                    }

                    Entities.AddRange(entities);
                    _context.SaveChanges();
                }
                return entities;
            }
            catch (Exception dbEx)
            {
                throw new Exception(_errorMessage, dbEx);
            }
        }

        public T Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }
                entity.ModifiedTime = DateTime.Now;
                _context.SaveChanges();
                return entity;
            }
            catch (Exception dbEx)
            {
                throw new Exception(_errorMessage, dbEx);
            }
        }

        public int Delete(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                Entities.Remove(entity);
                return _context.SaveChanges();
            }
            catch (Exception dbEx)
            {
                throw new Exception(_errorMessage, dbEx);
            }
        }

        public bool DeleteByID(object id)
        {
            try
            {
                if ((long)id > 0)
                {
                    var entity = GetById(id);
                    Entities.Remove(entity);
                    _context.SaveChanges();
                    return true;
                }
                else return false;

            }
            catch (Exception dbEx)
            {
                throw new Exception(_errorMessage, dbEx);
               
            }
            
        }

        public List<T> GetTable()
        {
            return Entities.ToList();
        }

        public List<T> GetTableSync()
        {
            return Entities.ToList();
        }

        public virtual IQueryable<T> Table => Entities;

        private DbSet<T> Entities => _entities ?? (_entities = _context.Set<T>());
    }
}
