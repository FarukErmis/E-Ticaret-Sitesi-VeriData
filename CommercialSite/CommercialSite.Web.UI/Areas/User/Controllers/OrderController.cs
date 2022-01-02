using AutoMapper;
using CommercialSite.Common.DTOs.Order;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.User.Models.OrderInfoViewModels;
using CommercialSite.Web.UI.Areas.User.Models.OrderViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
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

namespace CommercialSite.Web.UI.Areas.User.Controllers
{
    [Area("User"), Authorize]
    public class OrderController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IOrderApi _orderApi;
        private readonly IOrderInfoApi _orderInfoApi;
        private readonly IUserApi _userApi;
        private readonly IProductApi _productApi;
        private readonly IMapper _mapper;
        public OrderController(
            IWebHostEnvironment env,
            IOrderApi orderApi,
            IOrderInfoApi orderInfoApi,
            IProductApi productApi,
            IUserApi userApi,
            IMapper mapper)
        {
            _env = env;
            _orderApi = orderApi;
            _orderInfoApi = orderInfoApi;
            _productApi = productApi;
            _userApi = userApi;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var userId = JsonConvert.DeserializeObject<Guid>(HttpContext.Session.GetString("UserId"));
            List<OrderViewModel> list = new List<OrderViewModel>();
            var listResult = await _orderApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<OrderViewModel>>(listResult.Content.ResultData.Where(x=>x.UserId == userId));
            var a = list.GroupBy(x => x.OrderInfoId).ToList();
            List<OrderViewModel> listGroupBy = new List<OrderViewModel>();
            foreach (var item in a)
            {
                foreach (var item1 in item)
                {
                    listGroupBy.Add(item1);
                }
            }
            return View(listGroupBy);
        }

        [HttpGet]
        public async Task<IActionResult> Insert()
        {
            List<UserViewModel> list = new List<UserViewModel>();
            var listResult = await _userApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<UserViewModel>>(listResult.Content.ResultData);
            ViewBag.Users = new SelectList(list, "Id", "FirstName");

            List<ProductViewModel> listProduct = new List<ProductViewModel>();
            var listProductResult = await _userApi.List();
            if (listProductResult.IsSuccessStatusCode && listProductResult.Content.IsSuccess && listProductResult.Content.ResultData.Any())
                listProduct = _mapper.Map<List<ProductViewModel>>(listProductResult.Content.ResultData);
            ViewBag.Products = new SelectList(listProduct, "Id", "ProductName");

            List<OrderInfoViewModel> listOrderInfo = new List<OrderInfoViewModel>();
            var listOrderInfoResult = await _userApi.List();
            if (listOrderInfoResult.IsSuccessStatusCode && listOrderInfoResult.Content.IsSuccess && listOrderInfoResult.Content.ResultData.Any())
                listOrderInfo = _mapper.Map<List<OrderInfoViewModel>>(listOrderInfoResult.Content.ResultData);
            ViewBag.OrderInfos = new SelectList(listOrderInfo, "Id", "ShippingFirstName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CreateOrderViewModel item, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                var insertResult = await _orderApi.Post(_mapper.Map<OrderRequest>(item));
                if (insertResult.IsSuccessStatusCode && insertResult.Content.IsSuccess && insertResult?.Content?.ResultData != null)
                    return RedirectToAction("Index");
                else
                    TempData["Message"] = "Kayıt işlemi sırasında bir hata oluştu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";

            }
            else
                TempData["Message"] = "İşlem başarısız oldu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";
            return View(item);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            List<UserViewModel> list = new List<UserViewModel>();
            var listResult = await _userApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<UserViewModel>>(listResult.Content.ResultData);
            ViewBag.Users = new SelectList(list, "Id", "FirstName");

            List<ProductViewModel> listProduct = new List<ProductViewModel>();
            var listProductResult = await _userApi.List();
            if (listProductResult.IsSuccessStatusCode && listProductResult.Content.IsSuccess && listProductResult.Content.ResultData.Any())
                listProduct = _mapper.Map<List<ProductViewModel>>(listProductResult.Content.ResultData);
            ViewBag.Products = new SelectList(listProduct, "Id", "ProductName");

            List<OrderInfoViewModel> listOrderInfo = new List<OrderInfoViewModel>();
            var listOrderInfoResult = await _userApi.List();
            if (listOrderInfoResult.IsSuccessStatusCode && listOrderInfoResult.Content.IsSuccess && listOrderInfoResult.Content.ResultData.Any())
                listOrderInfo = _mapper.Map<List<OrderInfoViewModel>>(listOrderInfoResult.Content.ResultData);
            ViewBag.OrderInfos = new SelectList(listOrderInfo, "Id", "ShippingFirstName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateOrderViewModel item)
        {
            if (ModelState.IsValid)
            {

                var updateResult = await _orderApi.Put(item.Id, _mapper.Map<OrderRequest>(item));
                if (updateResult.IsSuccessStatusCode && updateResult.Content.IsSuccess && updateResult?.Content?.ResultData != null)
                    return RedirectToAction("Index");
                else
                    TempData["Message"] = "Kayıt işlemi sırasında bir hata oluştu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";
            }
            else
                TempData["Message"] = "İşlem başarısız oldu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";
            return View(item);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var deleteResult = await _orderApi.Delete(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activate(Guid id)
        {
            var deleteResult = await _orderApi.Activate(id);
            return RedirectToAction("Index");
        }
    }
}
