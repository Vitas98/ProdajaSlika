using ProdajaSlika.Models;

namespace ProdajaSlika.ViewModels
{
    public class PictureListViewModel
    {
        public IEnumerable<Picture> Pictures { get; set; }
        public string CurrentCategory { get; set; }
        public Category Category { get; set; }
    }
}
