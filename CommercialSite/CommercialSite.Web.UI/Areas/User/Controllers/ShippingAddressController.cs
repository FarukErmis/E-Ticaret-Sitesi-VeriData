using AutoMapper;
using CommercialSite.Common.DTOs.ShippingAddress;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.User.Models.ShippingAddressViewModels;
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

namespace CommercialSite.Web.UI.Areas.User.Controllers
{
    [Area("User"), Authorize]
    public class ShippingAddressController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IShippingAddressApi _shippingAddressApi;
        private readonly IUserApi _userApi;
        private readonly IMapper _mapper;
        public ShippingAddressController(
            IWebHostEnvironment env,
            IShippingAddressApi shippingAddressApi,
            IUserApi userApi,
            IMapper mapper)
        {
            _env = env;
            _shippingAddressApi = shippingAddressApi;
            _userApi = userApi;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<ShippingAddressViewModel> list = new List<ShippingAddressViewModel>();
            var listResult = await _shippingAddressApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<ShippingAddressViewModel>>(listResult.Content.ResultData);
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> Insert()
        {
            List<UserViewModel> list = new List<UserViewModel>();
            var listResult = await _userApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<UserViewModel>>(listResult.Content.ResultData);
            ViewBag.Users = new SelectList(list, "Id", "FirstName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CreateShippingAddressViewModel item, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                var insertResult = await _shippingAddressApi.Post(_mapper.Map<ShippingAddressRequest>(item));
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

            UpdateShippingAddressViewModel model = new UpdateShippingAddressViewModel();
            var updateModelResult = await _shippingAddressApi.Get(id);
            if (updateModelResult.IsSuccessStatusCode && updateModelResult.Content.IsSuccess && updateModelResult?.Content?.ResultData != null)
                model = _mapper.Map<UpdateShippingAddressViewModel>(updateModelResult?.Content?.ResultData);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateShippingAddressViewModel item)
        {
            if (ModelState.IsValid)
            {

                var updateResult = await _shippingAddressApi.Put(item.Id, _mapper.Map<ShippingAddressRequest>(item));
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
            var deleteResult = await _shippingAddressApi.Delete(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activate(Guid id)
        {
            var deleteResult = await _shippingAddressApi.Activate(id);
            return RedirectToAction("Index");
        }
    }
}
