using AutoMapper;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductImageViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductApi _productApi;
        private readonly IUserApi _userApi;
        private readonly IMapper _mapper;
        private readonly IProductImageApi _productImageApi;

        public HomeController(
            IProductApi productApi,
            IProductImageApi productImageApi,
            IUserApi userApi,
            IMapper mapper)
        {
            _productApi = productApi;
            _userApi = userApi;
            _mapper = mapper;
            _productImageApi = productImageApi;
        }
        public async Task<ActionResult> Index()
        {
            List<ProductViewModel> listProduct = new List<ProductViewModel>();
            var listProductResult = await _productApi.List();
            if (listProductResult.IsSuccessStatusCode && listProductResult.Content.IsSuccess &&listProductResult.Content.ResultData.Any())
                listProduct = _mapper.Map<List<ProductViewModel>>(listProductResult.Content.ResultData.ToList());
            var listProduct1 = listProduct.Where(x => x.Status == Common.Enums.Status.Active).ToList();
            return View(listProduct);
        }
    }
}
