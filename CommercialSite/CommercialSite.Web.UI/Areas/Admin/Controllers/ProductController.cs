using AutoMapper;
using CommercialSite.Common.DTOs.Product;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.Admin.Models.CategoryViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.BrandViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
using CommercialSite.Web.UI.Infrastructure.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IProductApi _productApi;
        private readonly ICategoryApi _categoryApi;
        private readonly IBrandApi _brandApi;
        private readonly IMapper _mapper;
        public ProductController(
            IWebHostEnvironment env,
            IProductApi productApi,
            IBrandApi brandApi,
            ICategoryApi categoryApi,
            IMapper mapper)
        {
            _env = env;
            _productApi = productApi;
            _brandApi = brandApi;
            _categoryApi = categoryApi;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<ProductViewModel> list = new List<ProductViewModel>();
            var listResult = await _productApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<ProductViewModel>>(listResult.Content.ResultData);
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> Insert()
        {
            List<CategoryViewModel> listC = new List<CategoryViewModel>();
            var listResultC = await _categoryApi.List();
            if (listResultC.IsSuccessStatusCode && listResultC.Content.IsSuccess && listResultC.Content.ResultData.Any())
                listC = _mapper.Map<List<CategoryViewModel>>(listResultC.Content.ResultData);
            ViewBag.Categories = new SelectList(listC, "Id", "CategoryName");

            List<BrandViewModel> listB = new List<BrandViewModel>();
            var listResultB = await _brandApi.List();
            if (listResultB.IsSuccessStatusCode && listResultB.Content.IsSuccess && listResultB.Content.ResultData.Any())
                listB = _mapper.Map<List<BrandViewModel>>(listResultB.Content.ResultData);
            ViewBag.Brands = new SelectList(listB, "Id", "BrandName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CreateProductViewModel item, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                var insertResult = await _productApi.Post(_mapper.Map<ProductRequest>(item));
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
            List<CategoryViewModel> listC = new List<CategoryViewModel>();
            var listResultC = await _categoryApi.List();
            if (listResultC.IsSuccessStatusCode && listResultC.Content.IsSuccess && listResultC.Content.ResultData.Any())
                listC = _mapper.Map<List<CategoryViewModel>>(listResultC.Content.ResultData);
            ViewBag.Categories = new SelectList(listC, "Id", "CategoryName");

            List<BrandViewModel> listB = new List<BrandViewModel>();
            var listResultB = await _brandApi.List();
            if (listResultB.IsSuccessStatusCode && listResultB.Content.IsSuccess && listResultB.Content.ResultData.Any())
                listB = _mapper.Map<List<BrandViewModel>>(listResultB.Content.ResultData);
            ViewBag.Brands = new SelectList(listB, "Id", "BrandName");

            UpdateProductViewModel model = new UpdateProductViewModel();
            var updateModelResult = await _productApi.Get(id);
            if (updateModelResult.IsSuccessStatusCode && updateModelResult.Content.IsSuccess && updateModelResult?.Content?.ResultData != null)
                model = _mapper.Map<UpdateProductViewModel>(updateModelResult?.Content?.ResultData);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductViewModel item)
        {
            if (ModelState.IsValid)
            {

                var updateResult = await _productApi.Put(item.Id, _mapper.Map<ProductRequest>(item));
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
            var deleteResult = await _productApi.Delete(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activate(Guid id)
        {
            var deleteResult = await _productApi.Activate(id);
            return RedirectToAction("Index");
        }
    }
}
