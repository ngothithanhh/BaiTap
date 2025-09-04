using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class HotProductViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var hotProducts = new List<string>
        {
            "Nồi cơm điện cao tần Nagakawa NAG0102",
            "Nồi cơm điện cao tần Nagakawa NAG0102",
            "Nồi cơm điện cao tần Nagakawa NAG0102"
        };

        return View(hotProducts);
    }
}
