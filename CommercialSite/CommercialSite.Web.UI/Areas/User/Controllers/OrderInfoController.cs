using AutoMapper;
using CommercialSite.Common.DTOs.OrderInfo;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.User.Models.OrderInfoViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
using CommercialSite.Web.UI.Areas.User.Models.ShipmentInfoViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.UserViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CommercialSite.Web.UI.Areas.User.Models.OrderViewModels;
using CommercialSite.Web.UI.Models;
using CommercialSite.Common.DTOs.Order;

namespace CommercialSite.Web.UI.Areas.User.Controllers
{
    [Area("User"), Authorize]
    public class OrderInfoController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IShipmentInfoApi _shipmentInfoApi;
        private readonly IOrderInfoApi _orderInfoApi;
        private readonly IOrderApi _orderApi;
        private readonly IUserApi _userApi;
        private readonly IMapper _mapper;
        public OrderInfoController(
            IWebHostEnvironment env,
            IShipmentInfoApi shipmentInfoApi,
            IOrderInfoApi orderInfoApi,
            IOrderApi orderApi,
            IUserApi userApi,
            IMapper mapper)
        {
            _env = env;
            _shipmentInfoApi = shipmentInfoApi;
            _orderInfoApi = orderInfoApi;
            _orderApi = orderApi;
            _userApi = userApi;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<ShipmentInfoViewModel> listC = new List<ShipmentInfoViewModel>();
            var listResultC = await _shipmentInfoApi.List();
            if (listResultC.IsSuccessStatusCode && listResultC.Content.IsSuccess && listResultC.Content.ResultData.Any())
                listC = _mapper.Map<List<ShipmentInfoViewModel>>(listResultC.Content.ResultData);
            ViewBag.ShipmentInfos = new SelectList(listC, "Id", "ShipmentName");
            return View();
        }

        public async Task<IActionResult> Insert(CreateOrderInfoViewModel item)
        {
             
            var userId = JsonConvert.DeserializeObject<Guid>(HttpContext.Session.GetString("UserId"));
            item.UserId = userId;

            if (ModelState.IsValid)
            {
                var insertResult = await _orderInfoApi.Post(_mapper.Map<OrderInfoRequest>(item));
                if (insertResult.IsSuccessStatusCode && insertResult.Content.IsSuccess && insertResult?.Content?.ResultData != null)
                {
                    var sessionCart = JsonConvert.DeserializeObject<List<ProductVM>>(HttpContext.Session.GetString("SessionCart"));
                    for (int i = 0; i < sessionCart.Count(); i++)
                    {
                        CreateOrderViewModel orderVM = new CreateOrderViewModel()
                        {
                            OrderInfoId = insertResult.Content.ResultData.Id,
                            ProductId = sessionCart.Select(x => x.Id).ToList()[i],
                            UserId = userId,
                            Status = Common.Enums.Status.Active
                        };

                        var insertOrder = await _orderApi.Post(_mapper.Map<OrderRequest>(orderVM));
                    }
                    HttpContext.Session.Remove("SessionCart");
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                else
                    TempData["Message"] = "Kayıt işlemi sırasında bir hata oluştu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";

            }
            else
                TempData["Message"] = "İşlem başarısız oldu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";
            return View(item);
        }
    }
}
