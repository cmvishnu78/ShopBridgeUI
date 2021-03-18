using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopBridge_FrontEnd.Models
{
    public class InventoryItem_Model
    {
        public int Item_Id { get; set; }
        public string Item_Name { get; set; }
        public string Item_Description { get; set; }
        public string Item_Price { get; set; }
        public string ImageUrl { get; set; }
    }
}