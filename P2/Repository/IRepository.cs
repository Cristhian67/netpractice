namespace P2.Repository
{
    public interface IRepository <TEntity>
    {
        Task<IEnumerable<TEntity>> Get();

        Task<TEntity> GetById(int id);

        Task Add(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(TEntity entity);

        Task Save();

        IEnumerable<TEntity> Search(Func<TEntity, bool> filter);
    }
}
