using Microsoft.EntityFrameworkCore;

namespace ProdajaSlika.Models
{
    public class PictureRepository : IPictureRepository
    {
        private readonly AppDbContext _db;

        public PictureRepository(AppDbContext appDbContext)
        {
            this._db = appDbContext;
        }

        public IEnumerable<Picture> AllPictures => _db.Pictures.Include(p => p.Category);

        public IEnumerable<Picture> SpecialOfferPictures => AllPictures.Where(p => p.IsSpecialOffer);

        public Picture GetPictureById(int id)
        {
            return _db.Pictures.FirstOrDefault(p => p.Id == id);
        }
    }
}
