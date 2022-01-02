using AutoMapper;
using CommercialSite.Common.DTOs.ProductComment;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductCommentViewModels;
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
    public class ProductCommentController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IProductCommentApi _productCommentApi;
        private readonly IProductApi _productApi;
        private readonly IMapper _mapper;
        public ProductCommentController(
            IWebHostEnvironment env,
            IProductCommentApi productCommentApi,
            IProductApi productApi,
            IMapper mapper)
        {
            _env = env;
            _productCommentApi = productCommentApi;
            _productApi = productApi;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<ProductCommentViewModel> list = new List<ProductCommentViewModel>();
            var listResult = await _productCommentApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<ProductCommentViewModel>>(listResult.Content.ResultData);
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
        public async Task<IActionResult> Insert(CreateProductCommentViewModel item, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                var insertResult = await _productCommentApi.Post(_mapper.Map<ProductCommentRequest>(item));
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

            UpdateProductCommentViewModel model = new UpdateProductCommentViewModel();
            var updateModelResult = await _productCommentApi.Get(id);
            if (updateModelResult.IsSuccessStatusCode && updateModelResult.Content.IsSuccess && updateModelResult?.Content?.ResultData != null)
                model = _mapper.Map<UpdateProductCommentViewModel>(updateModelResult?.Content?.ResultData);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductCommentViewModel item)
        {
            if (ModelState.IsValid)
            {

                var updateResult = await _productCommentApi.Put(item.Id, _mapper.Map<ProductCommentRequest>(item));
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
            var deleteResult = await _productCommentApi.Delete(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activate(Guid id)
        {
            var deleteResult = await _productCommentApi.Activate(id);
            return RedirectToAction("Index");
        }
    }
}
