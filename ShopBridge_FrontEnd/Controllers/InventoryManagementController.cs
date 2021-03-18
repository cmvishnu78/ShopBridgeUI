using Newtonsoft.Json;
using ShopBridge_FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace ShopBridge_FrontEnd.Controllers
{
    public class InventoryManagementController : Controller
    {
        // GET: InventoryManagement
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult ItemDetails(string ItemID)
        {
            ViewBag.Itemid = ItemID;
            return View();
        }
              

    }
}