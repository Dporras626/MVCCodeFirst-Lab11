namespace MVCCodeFirst.Models
{
    public class Invoice
    {
        public int Id { get; set; } // Clave primaria
        public int CustomersId { get; set; } // Clave foránea
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public double Total { get; set; }

        // Propiedad de navegación para la relación con Customers
        public Customer Customer { get; set; }
    }
}
