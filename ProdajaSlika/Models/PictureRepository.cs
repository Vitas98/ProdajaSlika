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

        public Picture Delete(int id)
        {
            Picture picture = GetPictureById(id);
            if (picture != null)
            {
                _db.Pictures.Remove(picture);
                _db.SaveChanges();
            }
            return picture;
        }

        public int GetCountOfPictures()
        {
            return _db.Pictures.Count();
        }

        public Picture GetPictureById(int id)
        {
            return _db.Pictures.FirstOrDefault(p => p.Id == id);
        }

        public Picture Insert(Picture novaSlika)
        {
            _db.Pictures.Add(novaSlika);
            _db.SaveChanges();
            return novaSlika;
        }

        public Picture Update(Picture izmenjenaSlika)
        {
            var entity = _db.Pictures.Attach(izmenjenaSlika);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            return izmenjenaSlika;
        }
        public Picture GetPictureWithRelatedEntities(int id)
        {
            return _db.Pictures
                .Include(p => p.Category)
                .Include(p => p.FrameType)
                .Include(p => p.CanvasType)
                .FirstOrDefault(p => p.Id == id);
        }
    }
}
