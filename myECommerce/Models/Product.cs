using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace myECommerce.Models
{
    /// <summary>
    /// represents a sellable product
    /// </summary>
    public class Product
    {
        [Key] // makes the property the Primary Key
        // If PK propery is an inter, it will be an identity column by default
        public int ProductID { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [Range(0, 100000 )] // inclusive
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        // TODO: Add Description
    }
}