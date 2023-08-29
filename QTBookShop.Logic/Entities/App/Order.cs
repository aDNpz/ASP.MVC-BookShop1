namespace QTBookShop.Logic.Entities.App
{
    [Table("Orders")]
    public class Order : VersionEntity
	{
        public IdType BookId { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
