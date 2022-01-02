using AutoMapper;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductPropertyViewModels;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Controllers
{
    public class ProductListController : Controller
    {
        private readonly IProductApi _productApi;
        private readonly IProductPropertyApi _productPropertyApi;
        private readonly IMapper _mapper;

        public ProductListController(
            IProductApi productApi,
            IProductPropertyApi productPropertyApi,
            IMapper mapper)
        {
            _productApi = productApi;
            _productPropertyApi = productPropertyApi;
            _mapper = mapper;
        }

        public async Task<ActionResult> Index(string name)
        {
            List<ProductViewModel> listProduct = new List<ProductViewModel>();
            var listProductResult = await _productApi.List();
            if (listProductResult.IsSuccessStatusCode && listProductResult.Content.IsSuccess && listProductResult.Content.ResultData.Where(x=>x.Brand.BrandName.ToLower() == name.ToLower()).Any())
                listProduct = _mapper.Map<List<ProductViewModel>>(listProductResult.Content.ResultData.Where(x=>x.Brand.BrandName.ToLower() == name.ToLower()).ToList());

            else if (listProductResult.IsSuccessStatusCode && listProductResult.Content.IsSuccess && listProductResult.Content.ResultData.Where(x => x.Category.CategoryName.ToLower() == name.ToLower()).Any())
                listProduct = _mapper.Map<List<ProductViewModel>>(listProductResult.Content.ResultData.Where(x => x.Category.CategoryName.ToLower() == name.ToLower()).ToList());

            return View(listProduct);
        }
    }
}
