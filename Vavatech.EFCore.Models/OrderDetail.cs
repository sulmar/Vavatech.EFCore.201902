namespace Vavatech.EFCore.Models
{
    public class OrderDetail : Base
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }

    


}
