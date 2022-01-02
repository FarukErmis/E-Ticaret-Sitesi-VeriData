using AutoMapper;
using CommercialSite.Common.DTOs.Login;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Extensions;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.Admin.Models.UserViewModels;
using CommercialSite.Web.UI.Infrastructure.Helpers;
using CommercialSite.Web.UI.Models.AccountViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace CommercialSite.Web.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountApi _accountApi;
        private readonly IMapper _mapper;

        public AccountController(
            IAccountApi accountApi,
            IMapper mapper)
        {
            _accountApi = accountApi;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel request)
        {
            if (ModelState.IsValid)
            {
                var loginRequest = await _accountApi.Login(_mapper.Map<LoginRequest>(request));
                if (loginRequest.IsSuccessStatusCode && loginRequest.Content.IsSuccess)
                {
                    UserResponse user = loginRequest.Content.ResultData;
                    var claims = new List<Claim>()
                    {
                        new Claim("Id",user.Id.ToString()),
                        new Claim(ClaimTypes.Name, user.FirstName),
                        new Claim(ClaimTypes.Surname, user.LastName),
                        new Claim(ClaimTypes.Email, user.Email)
                    };

                    //Giriş işlemlerini tamamlıyoruz ve kullanıcyı yönetici sayfasına yönlendiriyoruz...
                    var userIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    var cookieModel = new CookieModel
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        AccessToken = user.AccessToken,
                    };
                    HttpContext.Response.Cookies.Append("BilgeAdamAccessToken", JsonConvert.SerializeObject(cookieModel).Encrypt());

                    Guid UserId = user.Id;
                    HttpContext.Session.SetString("UserId", JsonConvert.SerializeObject(UserId));

                    //Microsoft.AspNetCore.Authentication
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["Message"] = "Böyle bir hesap bulunmamaktır. Email veya şifrenizi lütfen gözden geçiriniz...";
                }
            }
            else
            {
                TempData["Message"] = "Bütün alanları lütfen doldurunuz...";
            }
            return View();
        }

        //Kullanıcının güvenli çıkış işlemlerini tamamlıyoruz...
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}
