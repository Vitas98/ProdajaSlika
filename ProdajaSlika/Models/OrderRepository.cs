namespace ProdajaSlika.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext,ShoppingCart shoppingCart)
        {
            this._appDbContext = appDbContext;
            this._shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach(var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = item.Amount,
                    PicId = item.Picture.Id,
                    Price = item.Picture.Price,
                    Picture = item.Picture,
                };

                order.OrderDetails.Add(orderDetail);
            }

            _appDbContext.Order.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}
