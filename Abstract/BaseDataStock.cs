using StockMaster.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMaster.Abstract
{
    public class BaseDataStock
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StockId { get; set; }
        [ForeignKey("StockId")]
        public virtual Stock MainStock { get; set; }
        [Required]
        public string NameOfGood { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
