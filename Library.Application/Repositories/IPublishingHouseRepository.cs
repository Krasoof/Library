using Library.Application.EF;
using Library.Domain.Entities;

namespace Library.Application.Repositories
{
    public interface IPublishingHouseRepository
    {
        Task<PublishingHouse?> GetAsync(int id);

        Task<IEnumerable<PublishingHouse>> GetAllAsync();

        Task AddAsync(PublishingHouse publishingHouse);
    }
}
