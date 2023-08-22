namespace ProdajaSlika.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int? PicId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Picture Picture { get; set; }
        public Order Order { get; set; }
    }
}
