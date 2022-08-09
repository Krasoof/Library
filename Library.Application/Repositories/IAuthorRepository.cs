using Library.Domain.Entities;

namespace Library.Application.Repositories
{
    public interface IAuthorRepository
    {
        Task<Author?> GetAsync(int id);

        Task<Author?> GetWithBooks(int id);
    }
}
