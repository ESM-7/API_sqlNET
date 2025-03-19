using Microsoft.EntityFrameworkCore;

namespace Api_v1.Data
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly AppDbContext _context;
        public DocumentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Document>> GetDocumentAsync() => await _context.documents.Take(100).ToListAsync();
        
    }
}
