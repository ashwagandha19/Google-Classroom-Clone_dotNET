using ProjectManagementSystem.Models;
using ProjectManagementSystem.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManagementSystem.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class, new()
    {

        protected PmsDbContext dbContext;

        public BaseRepository(PmsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public T Add(T itemToAdd)
        {
            var entity = dbContext.Add(itemToAdd);
            dbContext.SaveChanges();
            return entity.Entity;
        }

        public bool Delete(T itemToDelete)
        {
            dbContext.Remove(itemToDelete);
            dbContext.SaveChanges();
            return true;
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>()
                           .AsEnumerable();
        }

        public T Update(T itemToUpdate)
        {
            var entity = dbContext.Update(itemToUpdate);
            dbContext.SaveChanges();
            return entity.Entity;
        }
    }
}
