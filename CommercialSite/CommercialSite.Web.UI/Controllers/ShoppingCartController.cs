using CommercialSite.Web.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult List()
        {
            if (HttpContext.Session.Keys.Contains("SessionCart"))
            {
                var sessionCart = JsonConvert.DeserializeObject<List<ProductVM>>(HttpContext.Session.GetString("SessionCart"));
                List<ProductVM> throwTheNulls = new List<ProductVM>();
                foreach (var item in sessionCart)
                {
                    if (item.CategoryName != null)
                    {
                        throwTheNulls.Add(item);
                    }
                }
                return View("Index", throwTheNulls);
            }
            ;
            return View("Index");
        }
        
        public IActionResult Add(Guid id,Guid userId, string productName, string categoryName, string brandName, double withoutDiscountPrice, double discountPrice, int rate, string imageUrl)
        {
            ProductVM vm = new ProductVM()
            {
                Id = id,
                ProductName = productName,
                Image = imageUrl,
                TotalPrice = withoutDiscountPrice,
                TrullyPrice = discountPrice,
                CategoryName = categoryName,
                Rates = rate,
                Quantity = 1,
                BrandName = brandName,
                UserId = userId
            };

            List<ProductVM> vmList = new List<ProductVM>();

            if (HttpContext.Session.Keys.Contains("SessionCart"))
            {
                var sessionCartControl = JsonConvert.DeserializeObject<List<ProductVM>>(HttpContext.Session.GetString("SessionCart"));
                if (sessionCartControl.Where(x => x.Id == vm.Id).Any() && vm.CategoryName != null)
                {
                    foreach (var item in sessionCartControl)
                    {
                        if (vm.Id == item.Id)
                        {
                            item.Quantity++;
                            break;
                        }
                    }
                }
                else
                    vmList.Add(vm);
                vmList.AddRange(sessionCartControl);
                vmList.RemoveAll(x => x.CategoryName == null);
                HttpContext.Session.SetString("SessionCart", JsonConvert.SerializeObject(vmList));
                return RedirectToAction("Index", "Home");
            }
            else
            {
                vmList.Add(vm);
                HttpContext.Session.SetString("SessionCart", JsonConvert.SerializeObject(vmList));
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Increase(Guid id)
        {
            var sessionCartControl = JsonConvert.DeserializeObject<List<ProductVM>>(HttpContext.Session.GetString("SessionCart"));


            foreach (var item in sessionCartControl)
            {
                if (id == item.Id)
                {
                    item.Quantity++;
                    break;
                }
            }
            HttpContext.Session.SetString("SessionCart", JsonConvert.SerializeObject(sessionCartControl));
            return RedirectToAction("List", "ShoppingCart");
        }

        public IActionResult Decrease(Guid id)
        {
            var sessionCartControl = JsonConvert.DeserializeObject<List<ProductVM>>(HttpContext.Session.GetString("SessionCart"));

            foreach (var item in sessionCartControl)
            {
                if (id == item.Id)
                {
                    if (item.Quantity == 1)
                    {
                        sessionCartControl.RemoveAll(x => x.Id == id);
                        RedirectToAction("Remove", "ShoppingCart");
                    }
                    item.Quantity--;
                    break;
                }
            }
            HttpContext.Session.SetString("SessionCart", JsonConvert.SerializeObject(sessionCartControl));
            return RedirectToAction("List", "ShoppingCart");
        }

        public IActionResult Remove(Guid id)
        {
            var sessionCartControl = JsonConvert.DeserializeObject<List<ProductVM>>(HttpContext.Session.GetString("SessionCart"));

            sessionCartControl.RemoveAll(x => x.Id == id);

            HttpContext.Session.SetString("SessionCart", JsonConvert.SerializeObject(sessionCartControl));

            return RedirectToAction("List", "ShoppingCart");
        }

        public IActionResult Finished()
        {
            HttpContext.Session.Remove("SessionCart");

            return View("Finished");
        }
    }
}
