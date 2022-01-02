using AutoMapper;
using CommercialSite.Common.DTOs.Category;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.Admin.Models.CategoryViewModels;
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
    public class CategoryController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly ICategoryApi _categoryApi;
        private readonly IMapper _mapper;

        public CategoryController(
            IWebHostEnvironment env,
            ICategoryApi categoryApi,
            IMapper mapper)
        {
            _env = env;
            _categoryApi = categoryApi;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<CategoryViewModel> list = new List<CategoryViewModel>();
            var listResult = await _categoryApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<CategoryViewModel>>(listResult.Content.ResultData);
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CreateCategoryViewModel item)
        {
            if (ModelState.IsValid)
            {
                var insertResult = await _categoryApi.Post(_mapper.Map<CategoryRequest>(item));
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
            UpdateCategoryViewModel model = new UpdateCategoryViewModel();
            var updateResult = await _categoryApi.Get(id);
            if (updateResult.IsSuccessStatusCode && updateResult.Content.IsSuccess && updateResult?.Content?.ResultData != null)
                model = _mapper.Map<UpdateCategoryViewModel>(updateResult?.Content?.ResultData);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateCategoryViewModel item)
        {
            if (ModelState.IsValid)
            {
                var updatetResult = await _categoryApi.Put(item.Id, _mapper.Map<CategoryRequest>(item));
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
            var deleteResult = await _categoryApi.Delete(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activate(Guid id)
        {
            var deleteResult = await _categoryApi.Activate(id);
            return RedirectToAction("Index");
        }
    }
}
