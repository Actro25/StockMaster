using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMaster.Interfaces
{
    public interface IAdvancedSortable
    {
        public void SortDataByDateColumn(bool isFromHigher);
        public void SortDataByPriceColumn(bool isFromHigher);
    }
}
