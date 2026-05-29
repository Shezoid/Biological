namespace Application.Abstractions.Repositories;

public interface IRepository<T>
{
    T Add(T entity);

    ICollection<T> GetAll();

    T? GetById(Guid id);
    
    T Update(T entity);

    void Delete(Guid id);
}