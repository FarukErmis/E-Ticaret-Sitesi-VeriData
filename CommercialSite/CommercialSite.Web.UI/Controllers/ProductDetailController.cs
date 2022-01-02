using AutoMapper;
using CommercialSite.Web.UI.APIs;
using CommercialSite.Web.UI.Areas.Admin.Models.ProductViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly IProductApi _productApi;
        private readonly IMapper _mapper;
        private readonly IProductImageApi _productImageApi;

        public ProductDetailController(
            IProductApi productApi,
            IProductImageApi productImageApi,
            IMapper mapper)
        {
            _productApi = productApi;
            _mapper = mapper;
            _productImageApi = productImageApi;
        }

       public async Task<ActionResult> Index(string name, Guid id)
       {
           //List<Product> vm = db.Products.Where(x => x.Id == id).ToList();
           if (id == null)
           {
               List<ProductViewModel> listProduct = new List<ProductViewModel>();
               var listProductResult = await _productApi.List();
                if (listProductResult.IsSuccessStatusCode && listProductResult.Content.IsSuccess && listProductResult.Content.ResultData.Any())
                    
                   listProduct = _mapper.Map<List<ProductViewModel>>(listProductResult.Content.ResultData.ToList());

               return View("~/Views/Home/Index.cshtml", listProduct);
           }
           else
           {
               List<ProductViewModel> listProduct = new List<ProductViewModel>();
               var listProductResult = await _productApi.List();
               if (listProductResult.IsSuccessStatusCode && listProductResult.Content.IsSuccess)
                   listProduct = _mapper.Map<List<ProductViewModel>>(listProductResult.Content.ResultData.Where(x=>x.Id == id).ToList());
               //Product productVM = productRepository.SelectById(id.Value);
               return View(listProduct);
           }
       }
    }
}
