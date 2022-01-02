using AutoMapper;
using CommercialSite.Common.DTOs.BillingAddress;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.User.Models.BillingAddressViewModels;
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
    public class BillingAddressController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IBillingAddressApi _billingAddressApi;
        private readonly IUserApi _userApi;
        private readonly IMapper _mapper;
        public BillingAddressController(
            IWebHostEnvironment env,
            IBillingAddressApi billingAddressApi,
            IUserApi userApi,
            IMapper mapper)
        {
            _env = env;
            _billingAddressApi = billingAddressApi;
            _userApi = userApi;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<BillingAddressViewModel> list = new List<BillingAddressViewModel>();
            var listResult = await _billingAddressApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<BillingAddressViewModel>>(listResult.Content.ResultData);
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
        public async Task<IActionResult> Insert(CreateBillingAddressViewModel item, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                var insertResult = await _billingAddressApi.Post(_mapper.Map<BillingAddressRequest>(item));
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

            UpdateBillingAddressViewModel model = new UpdateBillingAddressViewModel();
            var updateModelResult = await _billingAddressApi.Get(id);
            if (updateModelResult.IsSuccessStatusCode && updateModelResult.Content.IsSuccess && updateModelResult?.Content?.ResultData != null)
                model = _mapper.Map<UpdateBillingAddressViewModel>(updateModelResult?.Content?.ResultData);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateBillingAddressViewModel item)
        {
            if (ModelState.IsValid)
            {

                var updateResult = await _billingAddressApi.Put(item.Id, _mapper.Map<BillingAddressRequest>(item));
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
            var deleteResult = await _billingAddressApi.Delete(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activate(Guid id)
        {
            var deleteResult = await _billingAddressApi.Activate(id);
            return RedirectToAction("Index");
        }
    }
}
