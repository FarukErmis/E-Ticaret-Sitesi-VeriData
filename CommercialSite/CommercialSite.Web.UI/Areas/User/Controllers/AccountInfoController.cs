using AutoMapper;
using CommercialSite.Common.DTOs.BillingAddress;
using CommercialSite.Common.DTOs.ShippingAddress;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Enums;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.Admin.Models.UserViewModels;
using CommercialSite.Web.UI.Areas.User.Models;
using CommercialSite.Web.UI.Areas.User.Models.BillingAddressViewModels;
using CommercialSite.Web.UI.Areas.User.Models.ShippingAddressViewModels;
using CommercialSite.Web.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Areas.User.Controllers
{
    [Area("User"), Authorize]
    public class AccountInfoController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IBillingAddressApi _billingAddressApi;
        private readonly IUserApi _userApi;
        private readonly IShippingAddressApi _shippingAddressApi;
        private readonly IMapper _mapper;
        public AccountInfoController(
            IWebHostEnvironment env,
            IBillingAddressApi billingAddressApi,
            IUserApi userApi,
            IShippingAddressApi shippingAddressApi,
            IMapper mapper)
        {
            _env = env;
            _billingAddressApi = billingAddressApi;
            _userApi = userApi;
            _shippingAddressApi = shippingAddressApi;
            _mapper = mapper;
        }
        public async Task<IActionResult> InfoPanel()
        {
            var userId = JsonConvert.DeserializeObject<Guid>(HttpContext.Session.GetString("UserId"));

            var listUsers = await _userApi.List();
            var listBillingAddresses = await _billingAddressApi.List();
            var listShippingAddresses = await _shippingAddressApi.List();

            var listUser = listUsers.Content.ResultData.Where(x => x.Id == userId).FirstOrDefault();

            BillingAddressResponse listBillingAddress = new BillingAddressResponse();
            ShippingAddressResponse listShippingAddress = new ShippingAddressResponse();
            if (listBillingAddresses.Content.ResultData != null)
            {
                listBillingAddress = listBillingAddresses.Content.ResultData.Where(x => x.UserId == userId && x.Status == Status.Active).FirstOrDefault();
            }
            if (listShippingAddresses.Content.ResultData != null)
            {
                listShippingAddress = listShippingAddresses.Content.ResultData.Where(x => x.UserId == userId && x.Status == Status.Active).FirstOrDefault();
            }

            if (listBillingAddress == null && listShippingAddress == null)
            {
                AccountInfoVM accountInfoVM = new AccountInfoVM()
                {
                    UserId = listUser.Id,
                    FirstName = listUser.FirstName,
                    Surname = listUser.LastName,
                    Email = listUser.Email
                };
                HttpContext.Session.SetString("InfoPanel", JsonConvert.SerializeObject(accountInfoVM));
                return View(accountInfoVM);
            }
            else if (listBillingAddress == null && listShippingAddress != null)
            {
                AccountInfoVM accountInfoVM = new AccountInfoVM()
                {
                    UserId = listUser.Id,
                    FirstName = listUser.FirstName,
                    Surname = listUser.LastName,
                    Email = listUser.Email,
                    ShippingId = listShippingAddress.Id,
                    ShippingEmail = listShippingAddress.Email,
                    ShippingFirstName = listShippingAddress.FirstName,
                    ShippingSurName = listShippingAddress.SurName,
                    ShippingAdress = listShippingAddress.Adress,
                    ShippingCountry = listShippingAddress.Country,
                    ShippingLocation = listShippingAddress.Location,
                    ShippingSubLocation = listShippingAddress.SubLocation,
                    ShippingPhoneNumber = listShippingAddress.PhoneNumber
                };
                HttpContext.Session.SetString("InfoPanel", JsonConvert.SerializeObject(accountInfoVM));
                return View(accountInfoVM);
            }
            else if (listBillingAddress != null && listShippingAddress == null)
            {
                AccountInfoVM accountInfoVM = new AccountInfoVM()
                {
                    UserId = listUser.Id,
                    FirstName = listUser.FirstName,
                    Surname = listUser.LastName,
                    Email = listUser.Email,
                    BillingId = listBillingAddress.Id,
                    BillingEmail = listBillingAddress.Email,
                    BillingFirstName = listBillingAddress.FirstName,
                    BillingSurName = listBillingAddress.SurName,
                    BillingAdress = listBillingAddress.Adress,
                    BillingCountry = listBillingAddress.Country,
                    BillingLocation = listBillingAddress.Location,
                    BillingSubLocation = listBillingAddress.SubLocation,
                    BillingPhoneNumber = listBillingAddress.PhoneNumber
                };
                HttpContext.Session.SetString("InfoPanel", JsonConvert.SerializeObject(accountInfoVM));
                return View(accountInfoVM);
            }
            else
            {
                AccountInfoVM accountInfoVM = new AccountInfoVM()
                {
                    UserId = listUser.Id,
                    FirstName = listUser.FirstName,
                    Surname = listUser.LastName,
                    Email = listUser.Email,
                    BillingEmail = listBillingAddress.Email,
                    BillingFirstName = listBillingAddress.FirstName,
                    BillingSurName = listBillingAddress.SurName,
                    BillingAdress = listBillingAddress.Adress,
                    BillingCountry = listBillingAddress.Country,
                    BillingLocation = listBillingAddress.Location,
                    BillingSubLocation = listBillingAddress.SubLocation,
                    BillingPhoneNumber = listBillingAddress.PhoneNumber,
                    ShippingEmail = listShippingAddress.Email,
                    ShippingFirstName = listShippingAddress.FirstName,
                    ShippingSurName = listShippingAddress.SurName,
                    ShippingAdress = listShippingAddress.Adress,
                    ShippingCountry = listShippingAddress.Country,
                    ShippingLocation = listShippingAddress.Location,
                    ShippingSubLocation = listShippingAddress.SubLocation,
                    ShippingPhoneNumber = listShippingAddress.PhoneNumber,
                };

                HttpContext.Session.SetString("InfoPanel", JsonConvert.SerializeObject(accountInfoVM));

                return View(accountInfoVM);
            }
        }

        public async Task<IActionResult> UpdateUser(Guid id)
        {
            UpdateUserViewModel model = new UpdateUserViewModel();
            var updateModelResultList = await _userApi.List();
            var listUser = updateModelResultList.Content.ResultData.Where(x => x.Id == id).FirstOrDefault();
            if (updateModelResultList.IsSuccessStatusCode && updateModelResultList.Content.IsSuccess && updateModelResultList?.Content?.ResultData != null)
                model = _mapper.Map<UpdateUserViewModel>(updateModelResultList?.Content?.ResultData.Where(x => x.Id == id).FirstOrDefault());
            return View(model);
        }

        public async Task<IActionResult> UpdateUserAdress(UpdateUserViewModel item,string email, string password)
        {
            var userId = JsonConvert.DeserializeObject<Guid>(HttpContext.Session.GetString("UserId"));
            var updateModelResultList = await _userApi.List();
            var listUser = updateModelResultList.Content.ResultData.Where(x => x.Id == userId).FirstOrDefault();
            item.Email = email;
            item.Password = password;
            item.Status = Status.Active;
            item.Title = listUser.Title;

            if (ModelState.IsValid)
            {
                var insertResult = await _userApi.Put(userId, _mapper.Map<UserRequest>(item));
                if (insertResult.IsSuccessStatusCode && insertResult.Content.IsSuccess && insertResult?.Content?.ResultData != null)
                    return RedirectToAction("InfoPanel");
                else
                    TempData["Message"] = "Kayıt işlemi sırasında bir hata oluştu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";

            }
            else
                TempData["Message"] = "İşlem başarısız oldu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";
            return View(item);
        }

        [HttpGet]
        public IActionResult InsertBilling()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> InsertBillingAdress(CreateBillingAddressViewModel item)
        {
            var userId = JsonConvert.DeserializeObject<Guid>(HttpContext.Session.GetString("UserId"));
            item.UserId = userId;
            item.Status = Status.Active;
            if (ModelState.IsValid)
            {
                var insertResult = await _billingAddressApi.Post(_mapper.Map<BillingAddressRequest>(item));
                if (insertResult.IsSuccessStatusCode && insertResult.Content.IsSuccess && insertResult?.Content?.ResultData != null)
                    return RedirectToAction("InfoPanel");
                else
                    TempData["Message"] = "Kayıt işlemi sırasında bir hata oluştu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";

            }
            else
                TempData["Message"] = "İşlem başarısız oldu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";
            return View(item);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateBilling(Guid id)
        {
            UpdateBillingAddressViewModel model = new UpdateBillingAddressViewModel();
            var updateModelResult = await _billingAddressApi.Get(id);
            if (updateModelResult.IsSuccessStatusCode && updateModelResult.Content.IsSuccess && updateModelResult?.Content?.ResultData != null)
                model = _mapper.Map<UpdateBillingAddressViewModel>(updateModelResult?.Content?.ResultData);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBillingAdress(UpdateBillingAddressViewModel item)
        {
            var userId = JsonConvert.DeserializeObject<Guid>(HttpContext.Session.GetString("UserId"));
            item.UserId = userId;
            item.Status = Status.Active;
            if (ModelState.IsValid)
            {
                var insertResult = await _billingAddressApi.Put(item.Id,_mapper.Map<BillingAddressRequest>(item));
                if (insertResult.IsSuccessStatusCode && insertResult.Content.IsSuccess && insertResult?.Content?.ResultData != null)
                    return RedirectToAction("InfoPanel");
                else
                    TempData["Message"] = "Kayıt işlemi sırasında bir hata oluştu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";

            }
            else
                TempData["Message"] = "İşlem başarısız oldu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";
            return View(item);
        }
        public async Task<IActionResult> DeleteBilling(Guid id)
        {
            var deleteResult = await _billingAddressApi.Delete(id);
            return RedirectToAction("InfoPanel");
        }

        [HttpGet]
        public IActionResult InsertShipping()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> InsertShippingAdress(CreateShippingAddressViewModel item)
        {
            var userId = JsonConvert.DeserializeObject<Guid>(HttpContext.Session.GetString("UserId"));
            item.UserId = userId;
            item.Status = Status.Active;
            if (ModelState.IsValid)
            {
                var insertResult = await _shippingAddressApi.Post(_mapper.Map<ShippingAddressRequest>(item));
                if (insertResult.IsSuccessStatusCode && insertResult.Content.IsSuccess && insertResult?.Content?.ResultData != null)
                    return RedirectToAction("InfoPanel");
                else
                    TempData["Message"] = "Kayıt işlemi sırasında bir hata oluştu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";

            }
            else
                TempData["Message"] = "İşlem başarısız oldu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";
            return View(item);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateShipping(Guid id)
        {
            UpdateShippingAddressViewModel model = new UpdateShippingAddressViewModel();
            var updateModelResult = await _shippingAddressApi.Get(id);
            if (updateModelResult.IsSuccessStatusCode && updateModelResult.Content.IsSuccess && updateModelResult?.Content?.ResultData != null)
                model = _mapper.Map<UpdateShippingAddressViewModel>(updateModelResult?.Content?.ResultData);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateShippingAdress(UpdateShippingAddressViewModel item)
        {
            var userId = JsonConvert.DeserializeObject<Guid>(HttpContext.Session.GetString("UserId"));
            item.UserId = userId;
            item.Status = Status.Active;
            if (ModelState.IsValid)
            {
                var insertResult = await _shippingAddressApi.Put(item.Id, _mapper.Map<ShippingAddressRequest>(item));
                if (insertResult.IsSuccessStatusCode && insertResult.Content.IsSuccess && insertResult?.Content?.ResultData != null)
                    return RedirectToAction("InfoPanel");
                else
                    TempData["Message"] = "Kayıt işlemi sırasında bir hata oluştu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";

            }
            else
                TempData["Message"] = "İşlem başarısız oldu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";
            return View(item);
        }
        public async Task<IActionResult> DeleteShipping(Guid id)
        {
            var deleteResult = await _shippingAddressApi.Delete(id);
            return RedirectToAction("InfoPanel");
        }

        public IActionResult UpdatePassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword( ChangePasswordVM item)
        {
            
            var userId = JsonConvert.DeserializeObject<Guid>(HttpContext.Session.GetString("UserId"));

            var updateModelResultList = await _userApi.List();
            var listUser = updateModelResultList.Content.ResultData.Where(x => x.Id == userId).FirstOrDefault();

            UpdateUserViewModel model = new UpdateUserViewModel()
            {
                Id = userId,
                FirstName = listUser.FirstName,
                LastName = listUser.LastName,
                Email = listUser.Email,
                Password = item.NewPassword,
                Status = Status.Active,
                Title = listUser.Title
            };

            if (item.NewPassword != item.NewPassword2)
            {
                TempData["Message"] = "Lütfen şifreleri aynı girdiğinizden emin olunuz...";
            }
            else if (item.OldPassword != listUser.Password)
            {
                TempData["Message"] = "Eski şifrenizi yanlış girdiniz...";

            }
            
            else if (ModelState.IsValid)
            {
                listUser.Password = item.NewPassword;
                var insertResult = await _userApi.Put(userId, _mapper.Map<UserRequest>(model));
                if (insertResult.IsSuccessStatusCode && insertResult.Content.IsSuccess && insertResult?.Content?.ResultData != null)
                    return RedirectToAction("InfoPanel");
                else
                    TempData["Message"] = "Kayıt işlemi sırasında bir hata oluştu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";

            }
            else
                TempData["Message"] = "İşlem başarısız oldu!...Lütfen Tüm alanları kontrol edip tekrar deneyiniz...";
            return RedirectToAction("UpdatePassword");
        }
    }
}
