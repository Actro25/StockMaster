using StockMaster.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMaster.Models
{
    public class FunctionStockData : BaseDataStock
    {
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
