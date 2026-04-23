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

        private DateTime _dateOfArrival;
        [Required]
        public DateTime DateOfArrival {
            get => _dateOfArrival;
            set => _dateOfArrival = new DateTime(
                value.Year, value.Month, value.Day,
                value.Hour, value.Minute, 0, 0 
            );
        }
        [Required]
        public decimal Price { get; set; }
        public bool isArrived { get; set; } = false;
        public bool isOverdue { get; set; } = false;
    }
}
