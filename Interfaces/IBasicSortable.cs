namespace StockMaster.Interfaces
{
    internal interface IBasicSortable
    {
        public void SortDataByIdColumn(bool isFromHigher);
        public void SortDataByNameColumn(bool isFromHigher);
        public void SortDataByQuantityColumn(bool isFromHigher);
    }
}
