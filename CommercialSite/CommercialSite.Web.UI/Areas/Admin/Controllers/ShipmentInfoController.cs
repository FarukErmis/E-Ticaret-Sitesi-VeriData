using AutoMapper;
using CommercialSite.Common.DTOs.ShipmentInfo;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.User.Models.ShipmentInfoViewModels;
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
    public class ShipmentInfoController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IShipmentInfoApi _shipmentInfoApi;
        private readonly IMapper _mapper;

        public ShipmentInfoController(
            IWebHostEnvironment env,
            IShipmentInfoApi shipmentInfoApi,
            IMapper mapper)
        {
            _env = env;
            _shipmentInfoApi = shipmentInfoApi;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<ShipmentInfoViewModel> list = new List<ShipmentInfoViewModel>();
            var listResult = await _shipmentInfoApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<ShipmentInfoViewModel>>(listResult.Content.ResultData);
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CreateShipmentInfoViewModel item)
        {
            if (ModelState.IsValid)
            {
                var insertResult = await _shipmentInfoApi.Post(_mapper.Map<ShipmentInfoRequest>(item));
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
            UpdateShipmentInfoViewModel model = new UpdateShipmentInfoViewModel();
            var updateResult = await _shipmentInfoApi.Get(id);
            if (updateResult.IsSuccessStatusCode && updateResult.Content.IsSuccess && updateResult?.Content?.ResultData != null)
                model = _mapper.Map<UpdateShipmentInfoViewModel>(updateResult?.Content?.ResultData);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateShipmentInfoViewModel item)
        {
            if (ModelState.IsValid)
            {
                var updatetResult = await _shipmentInfoApi.Put(item.Id, _mapper.Map<ShipmentInfoRequest>(item));
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
            var deleteResult = await _shipmentInfoApi.Delete(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activate(Guid id)
        {
            var deleteResult = await _shipmentInfoApi.Activate(id);
            return RedirectToAction("Index");
        }
    }
}
