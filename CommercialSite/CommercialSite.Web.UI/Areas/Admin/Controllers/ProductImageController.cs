using AutoMapper;
using CommercialSite.Common.DTOs.ProductImage;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductImageViewModels;
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
    public class ProductImageController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IProductImageApi _productImageApi;
        private readonly IProductApi _productApi;
        private readonly IMapper _mapper;
        public ProductImageController(
            IWebHostEnvironment env,
            IProductImageApi productImageApi,
            IProductApi productApi,
            IMapper mapper)
        {
            _env = env;
            _productImageApi = productImageApi;
            _productApi = productApi;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<ProductImageViewModel> list = new List<ProductImageViewModel>();
            var listResult = await _productImageApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<ProductImageViewModel>>(listResult.Content.ResultData);
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
        public async Task<IActionResult> Insert(CreateProductImageViewModel item, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                bool imageResult;
                string imagePath = Upload.ImageUpload(files, _env, out imageResult);
                if (imageResult)
                    item.ImageUrl = imagePath;
                else
                {
                    ViewBag.Message = imagePath;
                    return View();
                }
                
                var insertResult = await _productImageApi.Post(_mapper.Map<ProductImageRequest>(item));
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

            UpdateProductImageViewModel model = new UpdateProductImageViewModel();
            var updateModelResult = await _productImageApi.Get(id);
            if (updateModelResult.IsSuccessStatusCode && updateModelResult.Content.IsSuccess && updateModelResult?.Content?.ResultData != null)
                model = _mapper.Map<UpdateProductImageViewModel>(updateModelResult?.Content?.ResultData);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductImageViewModel item)
        {
            if (ModelState.IsValid)
            {

                var updateResult = await _productImageApi.Put(item.Id, _mapper.Map<ProductImageRequest>(item));
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
            var deleteResult = await _productImageApi.Delete(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activate(Guid id)
        {
            var deleteResult = await _productImageApi.Activate(id);
            return RedirectToAction("Index");
        }
    }
}
