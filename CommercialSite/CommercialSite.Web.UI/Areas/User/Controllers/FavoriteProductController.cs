using AutoMapper;
using CommercialSite.Common.DTOs.FavoriteProduct;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.User.Models.FavoriteProductViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
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
using Newtonsoft.Json;
using CommercialSite.Common.Enums;

namespace CommercialSite.Web.UI.Areas.User.Controllers
{
    [Area("User"), Authorize]
    public class FavoriteProductController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IFavoriteProductApi _favoriteProductApi;
        private readonly IUserApi _userApi;
        private readonly IProductApi _productApi;
        private readonly IMapper _mapper;
        public FavoriteProductController(
            IWebHostEnvironment env,
            IFavoriteProductApi favoriteProductApi,
            IUserApi userApi,
            IProductApi productApi,
            IMapper mapper)
        {
            _env = env;
            _favoriteProductApi = favoriteProductApi;
            _userApi = userApi;
            _productApi = productApi;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = JsonConvert.DeserializeObject<Guid>(HttpContext.Session.GetString("UserId"));

            List<FavoriteProductViewModel> list = new List<FavoriteProductViewModel>();
            var listResult = await _favoriteProductApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<FavoriteProductViewModel>>(listResult.Content.ResultData.Where(x=>x.UserId == userId && x.Status == Status.Active));
            return View(list);
        }

        public async Task<IActionResult> Add(CreateFavoriteProductViewModel item,Guid productId)
        {
            var userId = JsonConvert.DeserializeObject<Guid>(HttpContext.Session.GetString("UserId"));

            List<FavoriteProductViewModel> list = new List<FavoriteProductViewModel>();
            var listResult = await _favoriteProductApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<FavoriteProductViewModel>>(listResult.Content.ResultData.Where(x => x.UserId == userId));


            if (list.Where(x => x.ProductId == productId && x.Status == Status.Deleted).Any())
            {
                var deleteResult = await _favoriteProductApi.Activate(list.Where(x => x.ProductId == productId).Select(x => x.Id).FirstOrDefault());
                return RedirectToAction("List", "ShoppingCart", new { area = "" });
            }
            else if (list.Where(x=>x.ProductId == productId).Any())
            {
                return RedirectToAction("List", "ShoppingCart", new { area = "" });
            }
            else
            {
                item.ProductId = productId;
                item.UserId = userId;
                item.Status = Status.Active;

                var insertResult = await _favoriteProductApi.Post(_mapper.Map<FavoriteProductRequest>(item));
                return RedirectToAction("List", "ShoppingCart", new { area = "" });
            }
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            List<UserViewModel> list = new List<UserViewModel>();
            var listResult = await _userApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<UserViewModel>>(listResult.Content.ResultData);
            ViewBag.Users = new SelectList(list, "Id", "FirstName");

            List<ProductViewModel> listProduct = new List<ProductViewModel>();
            var listProductResult = await _productApi.List();
            if (listProductResult.IsSuccessStatusCode && listProductResult.Content.IsSuccess && listProductResult.Content.ResultData.Any())
                listProduct = _mapper.Map<List<ProductViewModel>>(listProductResult.Content.ResultData);
            ViewBag.Products = new SelectList(listProduct, "Id", "ProductName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CreateFavoriteProductViewModel item)
        {
            if (ModelState.IsValid)
            {
                var insertResult = await _favoriteProductApi.Post(_mapper.Map<FavoriteProductRequest>(item));
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

            List<ProductViewModel> listProduct = new List<ProductViewModel>();
            var listProductResult = await _productApi.List();
            if (listProductResult.IsSuccessStatusCode && listProductResult.Content.IsSuccess && listProductResult.Content.ResultData.Any())
                listProduct = _mapper.Map<List<ProductViewModel>>(listProductResult.Content.ResultData);
            ViewBag.Products = new SelectList(listProduct, "Id", "ProductName");

            UpdateFavoriteProductViewModel model = new UpdateFavoriteProductViewModel();
            var updateModelResult = await _favoriteProductApi.Get(id);
            if (updateModelResult.IsSuccessStatusCode && updateModelResult.Content.IsSuccess && updateModelResult?.Content?.ResultData != null)
                model = _mapper.Map<UpdateFavoriteProductViewModel>(updateModelResult?.Content?.ResultData);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateFavoriteProductViewModel item)
        {
            if (ModelState.IsValid)
            {

                var updateResult = await _favoriteProductApi.Put(item.Id, _mapper.Map<FavoriteProductRequest>(item));
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
            var deleteResult = await _favoriteProductApi.Delete(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activate(Guid id)
        {
            var deleteResult = await _favoriteProductApi.Activate(id);
            return RedirectToAction("Index");
        }
    }
}
