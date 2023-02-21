public sealed class DocumentRepository
{
    private static readonly Lazy<DocumentRepository> lazy = new Lazy<DocumentRepository>(() => new DocumentRepository());

    public static DocumentRepository Instance { get { return lazy.Value; } }

    private DocumentRepository()
    {
        // Конструктор класу
    }

    public void Save(Document document)
    {
        // Збереження документу
    }

    public Document Get(int id)
    {
        // Отримання документу по ідентифікатору
        return null;
    }

    // Інші методи роботи з документами
}
