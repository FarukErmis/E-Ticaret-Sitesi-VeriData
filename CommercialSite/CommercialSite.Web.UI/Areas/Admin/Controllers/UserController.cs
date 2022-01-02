using AutoMapper;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.Admin.Models.UserViewModels;
using CommercialSite.Web.UI.Infrastructure.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class UserController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IUserApi _userApi;
        private readonly IMapper _mapper;
        public UserController(
            IWebHostEnvironment env,
            IUserApi userApi,
            IMapper mapper)
        {
            _env = env;
            _userApi = userApi;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<UserViewModel> list = new List<UserViewModel>();
            var listResult = await _userApi.List();
            if (listResult.IsSuccessStatusCode && listResult.Content.IsSuccess && listResult.Content.ResultData.Any())
                list = _mapper.Map<List<UserViewModel>>(listResult.Content.ResultData);
            return View(list);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CreateUserViewModel item, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                bool imageResult;
                string imagePath = Upload.ImageUpload(files, _env, out imageResult);
                if (imageResult)
                    item.AvatarUrl = imagePath;
                else
                {
                    ViewBag.Message = imagePath;
                    return View();
                }

                var insertResult = await _userApi.Post(_mapper.Map<UserRequest>(item));
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
            UpdateUserViewModel model = new UpdateUserViewModel();
            var updateModelResult = await _userApi.Get(id);
            if (updateModelResult.IsSuccessStatusCode && updateModelResult.Content.IsSuccess && updateModelResult?.Content?.ResultData != null)
                model = _mapper.Map<UpdateUserViewModel>(updateModelResult?.Content?.ResultData);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateUserViewModel item)
        {
            if (ModelState.IsValid)
            {
                var updateResult = await _userApi.Put(item.Id, _mapper.Map<UserRequest>(item));
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
            var deleteResult = await _userApi.Delete(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Activate(Guid id)
        {
            var deleteResult = await _userApi.Activate(id);
            return RedirectToAction("Index");
        }
    }
}
