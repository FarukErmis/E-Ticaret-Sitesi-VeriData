using AutoMapper;
using CommercialSite.Common.DTOs.Order;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.User.Models.OrderViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class OrderController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IOrderApi _orderApi;
        private readonly IMapper _mapper;

        public OrderController(
            IWebHostEnvironment env,
            IOrderApi orderApi,
            IMapper mapper)
        {
            _env = env;
            _orderApi = orderApi;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<OrderViewModel> list = new List<OrderViewModel>();
            var listResult = await _orderApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<OrderViewModel>>(listResult.Content.ResultData);
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CreateOrderViewModel item)
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
            UpdateOrderViewModel model = new UpdateOrderViewModel();
            var updateResult = await _orderApi.Get(id);
            if (updateResult.IsSuccessStatusCode && updateResult.Content.IsSuccess && updateResult?.Content?.ResultData != null)
                model = _mapper.Map<UpdateOrderViewModel>(updateResult?.Content?.ResultData);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateOrderViewModel item)
        {
            if (ModelState.IsValid)
            {
                var updatetResult = await _orderApi.Put(item.Id, _mapper.Map<OrderRequest>(item));
                if (updatetResult.IsSuccessStatusCode && updatetResult.Content.IsSuccess && updatetResult?.Content?.ResultData != null)
                    return RedirectToAction("Index");
                else
                    TempData["Message"] = "Güncelleme işlemi sırasında bir hata oluştu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";
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
