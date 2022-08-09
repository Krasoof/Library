using Library.Application.EF;
using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Application.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryContext _context;

        public AuthorRepository(LibraryContext context)
        {
            _context = context;
        }

        public Task<Author?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Author?> GetWithBooks(int id)
            => await _context.Authors
            .Include(a => a.Books)            
            .FirstOrDefaultAsync(a => a.Id == id);
    }
}
