namespace MVCCodeFirst.Models
{
    public class Customer
    {
        public int Id { get; set; } // Clave primaria
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }

        public int idCustomers { get; set; } // Clave foránea
    }


}
