namespace MVCCodeFirst.Models
{
    public class Detail
    {
        public int Id { get; set; } // Clave primaria
        public int ProductsId { get; set; } // Clave foránea
        public int Amount { get; set; }
        public double Price { get; set; }
        public double SubTotal { get; set; }

        // Propiedad de navegación para la relación con Products
        public Product Products { get; set; }
    }
}
