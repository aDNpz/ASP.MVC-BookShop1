namespace QTBookShop.AspMvc.Models.App
{
    public class Order : VersionModel
    {
        public IdType BookId { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public static Order Create(Logic.Models.App.Order entity)
        {
            return new Order
            {
                Id = entity.Id,
                BookId = entity.BookId,
                Date = entity.Date,
                Quantity = entity.Quantity,
                Price = entity.Price,
            };
        }
    }
}
