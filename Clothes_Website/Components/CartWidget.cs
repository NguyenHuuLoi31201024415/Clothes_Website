using Clothes_Website.Data;
using Clothes_Website.Infrastructure;
using Clothes_Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clothes_Website.Components
{
    public class CartWidget:ViewComponent
    {
        

        public IViewComponentResult Invoke()
        {
            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }
    }
}
