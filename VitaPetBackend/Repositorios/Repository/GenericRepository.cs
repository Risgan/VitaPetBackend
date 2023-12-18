using Microsoft.EntityFrameworkCore;

namespace VitaPetBackend.Repositorios.Repository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            var entidad = await _context.Set<TEntity>().FindAsync(id);
            _context.Set<TEntity>().Remove(entidad);
            await _context.SaveChangesAsync();
            return true;
        }

        public virtual async Task<bool> Exist(int id)
        {
            var entidad = await _context.Set<TEntity>().FindAsync(id);
            return (entidad != null);
        }

        public virtual async Task<TEntity> Get(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<bool> Update(int id, TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
