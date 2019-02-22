namespace Vavatech.EFCore.Models
{
    public class Customer : Base
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public bool IsDeleted { get; set; }
        public decimal Salary { get; set; }

        public byte[] RowVersion { get; set; }
    }

    


}
