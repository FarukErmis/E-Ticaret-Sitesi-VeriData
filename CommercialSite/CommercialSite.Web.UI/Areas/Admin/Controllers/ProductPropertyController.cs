using AutoMapper;
using CommercialSite.Common.DTOs.ProductProperty;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductPropertyViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
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
    public class ProductPropertyController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IProductPropertyApi _productPropertyApi;
        private readonly IProductApi _productApi;
        private readonly IMapper _mapper;
        public ProductPropertyController(
            IWebHostEnvironment env,
            IProductPropertyApi productPropertyApi,
            IProductApi productApi,
            IMapper mapper)
        {
            _env = env;
            _productPropertyApi = productPropertyApi;
            _productApi = productApi;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<ProductPropertyViewModel> list = new List<ProductPropertyViewModel>();
            var listResult = await _productPropertyApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<ProductPropertyViewModel>>(listResult.Content.ResultData);
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> Insert()
        {
            List<ProductViewModel> list = new List<ProductViewModel>();
            var listResult = await _productApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<ProductViewModel>>(listResult.Content.ResultData);
            ViewBag.Products = new SelectList(list, "Id", "ProductName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CreateProductPropertyViewModel item, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                var insertResult = await _productPropertyApi.Post(_mapper.Map<ProductPropertyRequest>(item));
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
            List<ProductViewModel> list = new List<ProductViewModel>();
            var listResult = await _productApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<ProductViewModel>>(listResult.Content.ResultData);
            ViewBag.Products = new SelectList(list, "Id", "ProductName");

            UpdateProductPropertyViewModel model = new UpdateProductPropertyViewModel();
            var updateModelResult = await _productPropertyApi.Get(id);
            if (updateModelResult.IsSuccessStatusCode && updateModelResult.Content.IsSuccess && updateModelResult?.Content?.ResultData != null)
                model = _mapper.Map<UpdateProductPropertyViewModel>(updateModelResult?.Content?.ResultData);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductPropertyViewModel item)
        {
            if (ModelState.IsValid)
            {

                var updateResult = await _productPropertyApi.Put(item.Id, _mapper.Map<ProductPropertyRequest>(item));
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
            var deleteResult = await _productPropertyApi.Delete(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activate(Guid id)
        {
            var deleteResult = await _productPropertyApi.Activate(id);
            return RedirectToAction("Index");
        }
    }
}
