using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTCN_Blockchain.Controllers
{
    public class HomeController : Controller
    {
        
        private static bool isLoaded = false; // chưa load -> nếu bằng true thì không load lại
        private static List<string> passwordList = new List<string>() { "admin", "user1", "user2" };
        private static string acc = ""; // tên ví, rỗng là chưa đăng nhập

        // Load , lúc đầu block chỉ có 1 khối, thêm 1 khối giao dịch (cho user1 và user2)
        public void Load()
        {
           
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Index()
        {
            // Index sẽ là nơi vào đầu tiên
            if (!isLoaded) // chưa được load (!false => true)
            {
                this.Load();
                isLoaded = true;
            }

           

            return View("Index");
        }

        public ActionResult CreateWallet()
        {
            ViewBag.status = "";
            ViewBag.Acc = acc;

            return View("CreateWallet");
        }
    }
}