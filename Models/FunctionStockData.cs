using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMaster.Models
{
    public class FunctionStockData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StockId { get; set; }
        [ForeignKey("StockId")]
        public virtual Stock MainStock { get; set; }
        [MaxLength(10)]
        [Required]
        public string NameOfGood { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime DateOfArrival { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
