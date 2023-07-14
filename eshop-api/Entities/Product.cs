using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecomAPI.Entities
{
    public class Product
    {
        [Column("product_id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("brand")]
        public string Brand { get; set; }

        [Column("price")]
        public long Price { get; set; }

        [Column("type_of_product")]
        public string TypeProduct { get; set; }

        [Column("qty_in_stock")]
        public int QtyInStock { get; set; }

        public List<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();

        public Product()
        {

        }
    }
}
