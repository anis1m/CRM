namespace CRM.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> getAll();
        TEntity getSingle(int id);
        TEntity update(TEntity entity);
        void delete(int id);
    }
}
