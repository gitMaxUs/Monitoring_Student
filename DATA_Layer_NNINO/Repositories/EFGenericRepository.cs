using DATA_Layer_NNINO.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using DATA_Layer_NNINO.Entities;
using System.Text;
using System.Linq;

namespace DATA_Layer_NNINO.Repositories
{
    public class EFGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        EFContext _context;
        DbSet<TEntity> _dbSet;

        public EFGenericRepository(EFContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }
        public TEntity Get(int id)
        {
            return _dbSet.Find(id);
        }

        public void Create(TEntity item)
        {
            _dbSet.Add(item);

        }
        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;

        }
        public void Delete(int? id)
        {
            var item = _dbSet.Find(id.Value);
            _dbSet.Remove(item);

        }
        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            var result = _context.Set<TEntity>().Where(predicate).ToList();

            return result;
        }
    }
}
