using Library.Application.EF;
using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Application.Repositories
{
    public class PublishingHouseRepository : IPublishingHouseRepository
    {
        private readonly LibraryContext _context;

        public PublishingHouseRepository(LibraryContext context)
        {
            _context = context;
        }
        public Task<PublishingHouse?> GetAsync(int id)
            => _context.PublishingHouses.FirstOrDefaultAsync(ph => ph.Id == id);

        public async Task<IEnumerable<PublishingHouse>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(PublishingHouse publishingHouse)
        {
            await _context.PublishingHouses.AddAsync(publishingHouse);
            await _context.SaveChangesAsync();
        }
    }
}
