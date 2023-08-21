namespace ProdajaSlika.Models
{
    public interface IPictureRepository
    {
        IEnumerable<Picture> AllPictures { get; }
        IEnumerable<Picture> SpecialOfferPictures { get; }
        Picture GetPictureById(int id);
    }
}
