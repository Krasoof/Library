using Library.Application.Repositories;
using Library.Domain.Entities;

namespace Library.Application.Services
{
    public class PublishingHouseService : IPublishingHouseService
    {
        private readonly IPublishingHouseRepository _publishingHouseRepository;

        public PublishingHouseService(IPublishingHouseRepository publishingHouseRepository)
        {
            _publishingHouseRepository = publishingHouseRepository;
        }

        public async Task AddAsync(PublishingHouse publishingHouse)
        {
            await _publishingHouseRepository.AddAsync(publishingHouse);
        }
    }
}
