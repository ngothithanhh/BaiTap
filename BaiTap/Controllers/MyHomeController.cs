using Microsoft.AspNetCore.Mvc;

namespace BaiTap.Controllers
{
    public class MyHomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<string>
            {
                "Nồi cơm điện cao tần Nagakawa NAG0102",
                "Nồi cơm điện cao tần Nagakawa NAG0102",
                "Nồi cơm điện cao tần Nagakawa NAG0102"

            };
            return View(products);
        }
    }
}
