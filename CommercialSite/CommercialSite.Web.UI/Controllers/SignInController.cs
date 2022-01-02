using AutoMapper;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.Admin.Models.UserViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Controllers
{
    public class SignInController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IUserApi _userApi;
        private readonly IMapper _mapper;
        public SignInController(
            IWebHostEnvironment env,
            IUserApi userApi,
            IMapper mapper)
        {
            _env = env;
            _userApi = userApi;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Register(CreateUserViewModel item)
        {
            UpdateUserViewModel model = new UpdateUserViewModel();
            var updateModelResultList = await _userApi.List();
            var list = updateModelResultList.Content.ResultData.Where(x => x.Email == item.Email).FirstOrDefault();
            if (ModelState.IsValid)
            {
                if (list == null)
                {
                    var insertResult = await _userApi.Post(_mapper.Map<UserRequest>(item));
                    if (insertResult.IsSuccessStatusCode && insertResult.Content.IsSuccess && insertResult?.Content?.ResultData != null)
                        return RedirectToAction("Login", "Account");
                    else
                        TempData["Message"] = "Kayıt işlemi sırasında bir hata oluştu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";
                }
                else
                {
                    TempData["Message"] = "Böyle bir email hesabı zaten vardır...";
                }
                
            }
            else
                TempData["Message"] = "İşlem başarısız oldu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";

            return View("Index");
        }
    }
}
