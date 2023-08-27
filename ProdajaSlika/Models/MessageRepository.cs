namespace ProdajaSlika.Models
{
    public class MessageRepository : IMessageRepository
    {
        private readonly AppDbContext _db;

        public MessageRepository(AppDbContext appDbContext)
        {
            this._db = appDbContext;
        }

        public Message Insert(Message novaPoruka)
        {
            _db.Messages.Add(novaPoruka);
            _db.SaveChanges();
            return novaPoruka;
        }
    }
}
