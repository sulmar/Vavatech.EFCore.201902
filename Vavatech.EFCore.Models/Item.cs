namespace Vavatech.EFCore.Models
{
    public abstract class Item : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }

    }

    


}
