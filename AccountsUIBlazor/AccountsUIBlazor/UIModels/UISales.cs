using System.ComponentModel.DataAnnotations;

namespace AccountsUIBlazor.UIModels
{
    public class UISales
    {
        public UISales()
        {
            UICalenderModel = new UICalenderModel();
            UIStockInList = new List<UIStockInItem>();
        }
        public List<UIStockInItem> UIStockInList { get; set; }
        //[Required]
        public UIStockIn StockIn { get; set; }
        public UICalenderModel UICalenderModel { get; set; }
        public UISalesStockInData UISalesStockInData { get; set; }


    }

    public class UISalesStockInData
    {
        public string LoadName { get; set; }
        public int StockInId { get; set; }
        public int VendorId { get; set; }

        public int Quantity { get; set; }



    }

    public class UIStockInItem
    {
        public string LoadName { get; set; }
        public int StockInId { get; set; }
    }
}
