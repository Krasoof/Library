using Library.Domain.Entities;

namespace Library.Application.Services
{
    public interface IPublishingHouseService
    {
        Task AddAsync(PublishingHouse publishingHouse);
    }
}
