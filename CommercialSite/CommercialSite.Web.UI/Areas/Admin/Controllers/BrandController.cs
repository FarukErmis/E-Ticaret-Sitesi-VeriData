using AutoMapper;
using CommercialSite.Common.DTOs.Brand;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.Admin.Models.BrandViewModels;
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
    public class BrandController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IBrandApi _brandApi;
        private readonly IMapper _mapper;

        public BrandController(
            IWebHostEnvironment env,
            IBrandApi brandApi,
            IMapper mapper)
        {
            _env = env;
            _brandApi = brandApi;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<BrandViewModel> list = new List<BrandViewModel>();
            var listResult = await _brandApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<BrandViewModel>>(listResult.Content.ResultData);
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CreateBrandViewModel item)
        {
            if (ModelState.IsValid)
            {
                var insertResult = await _brandApi.Post(_mapper.Map<BrandRequest>(item));
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
            UpdateBrandViewModel model = new UpdateBrandViewModel();
            var updateResult = await _brandApi.Get(id);
            if (updateResult.IsSuccessStatusCode && updateResult.Content.IsSuccess && updateResult?.Content?.ResultData != null)
                model = _mapper.Map<UpdateBrandViewModel>(updateResult?.Content?.ResultData);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateBrandViewModel item)
        {
            if (ModelState.IsValid)
            {
                var updatetResult = await _brandApi.Put(item.Id, _mapper.Map<BrandRequest>(item));
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
            var deleteResult = await _brandApi.Delete(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activate(Guid id)
        {
            var deleteResult = await _brandApi.Activate(id);
            return RedirectToAction("Index");
        }
    }
}
