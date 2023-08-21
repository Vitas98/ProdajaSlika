namespace ProdajaSlika.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public Picture Picture { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
