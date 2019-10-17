using OMG_Annalect_DAL_Core.Data;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using OMG_Annalect_DAL_Core.Repositories;
using OMG_Annalect_DAL_Core.Interface;


namespace OMG_Annalect_DAL_Core
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        private bool _disposed;
        private Dictionary<string, object> _repositories;
        private IDbContextTransaction _transaction;
        public DbContextOptions<ApplicationDbContext> Connectionoptions;
      

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
          
        }

        public UnitOfWork()
        {
            var connectionoptionbuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            connectionoptionbuilder.UseSqlServer(DBConnection.ConnectionString);
            Connectionoptions = connectionoptionbuilder.Options;
            _context = new ApplicationDbContext(Connectionoptions);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IDbContextTransaction BeginTransasction()
        {
            _transaction = _context.Database.BeginTransaction();
            return _transaction;
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public GenericRepository<T> GenericRepository<T>() where T : BaseEntity
        {
            if (_repositories == null)
            {
                _repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);
                _repositories.Add(type, repositoryInstance);
            }
            return (GenericRepository<T>)_repositories[type];
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch (Exception exc)
            {
                Rollback();
                throw;
            }
        }

        public void SaveAndCommit()
        {
            try
            {
                _context.SaveChanges();
                _transaction.Commit();
            }
            catch (Exception)
            {
                Rollback();
                throw;
            }
        }

        public void Rollback()
        {
            _transaction.Rollback();
            foreach (var entry in _context.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
        }

        public ApplicationDbContext GetContext()
        {
            return _context;
        }
    }
}
