namespace Api_v1

{
     public interface IDocumentRepository
    {
        Task<IEnumerable<Document>> GetDocumentAsync();

    }
}
