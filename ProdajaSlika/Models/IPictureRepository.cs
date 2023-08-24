namespace ProdajaSlika.Models
{
    public interface IPictureRepository
    {
        IEnumerable<Picture> AllPictures { get; }
        IEnumerable<Picture> SpecialOfferPictures { get; }
        Picture GetPictureById(int id);
        Picture Update(Picture izmenjenaSlika);
        Picture Insert(Picture novaSlika);
        Picture Delete(int id);
        int GetCountOfPictures();
        public Picture GetPictureWithRelatedEntities(int id);
    }
}
