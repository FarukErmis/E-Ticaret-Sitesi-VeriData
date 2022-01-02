using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.Product;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("product")]
    public class ProductController : BaseApiController<ProductController>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductController(
            IProductRepository commentReactionRepository,
            IMapper mapper)
        {
            _productRepository = commentReactionRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<ProductResponse>>>> GetProducts()
        {
            //ok mi
            //tmm hocam istediğimiz kadar tabloyu include edebiliriz değilmi bu şekilde
            //evet
            //tmm hocam çok sağolun
            //kapattım görüşürüz
            //tmm hocam

            UserResponse currentUser = WorkContext.CurrentUser;
            var result = await _productRepository
                                            .Table
                                            .Include(x => x.ProductImages)
                                            .Include(x => x.ProductComments)
                                            .Include(x => x.ProductProperties)
                                            .Include(x => x.ShippingSettings)
                                            .Include(x=>x.Category)
                                            .Include(x=>x.Brand)
                                            .ToListAsync();
            //using Microsoft.EntityFrameworkCore;
            //var productResult = _mapper.Map<List<ProductResponse>>(await _productRepository
            //    .GetDefault(x=> x.Brand.Id == x.BrandId ,x=>x.Brand).ToListAsync());
            var productResult = _mapper.Map<List<ProductResponse>>(result);

            //var productResultt = _mapper.Map<List<ProductResponse>>(await _productRepository
            //        .GetDefault(x=> x.ProductImages.Select(y=>y.ProductId == x.Id).FirstOrDefault(),x=>x.ProductImages).ToListAsync());


            if (productResult.Count > 0)
                return new WebApiResponse<List<ProductResponse>>(true, "Success", productResult);
            return new WebApiResponse<List<ProductResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductResponse>>> GetProduct(Guid id)
        {
            var productResult = _mapper.Map<ProductResponse>(await _productRepository.GetById(id));
            if (productResult != null)
                return new WebApiResponse<ProductResponse>(true, "Success", productResult);
            return new WebApiResponse<ProductResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<ProductResponse>>> PostProduct(ProductRequest request)
        {
            Product entity = _mapper.Map<Product>(request);
            var insertResult = await _productRepository.Add(entity);
            if (insertResult != null)
            {
                ProductResponse rm = _mapper.Map<ProductResponse>(entity);
                return new WebApiResponse<ProductResponse>(true, "Success", rm);
            }
            return new WebApiResponse<ProductResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductResponse>>> PutProduct(Guid id, ProductRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                Product entity = await _productRepository.GetById(id);
                if (entity == null)
                    return NotFound();

                //Eğer request'ten gelen data varsa onu veritabanında günceller, yoksa veri tabanındakini tutar, null ile ezmez....
                _mapper.Map(request, entity);

                var updateResult = await _productRepository.Update(entity);
                if (updateResult != null)
                {
                    ProductResponse rm = _mapper.Map<ProductResponse>(updateResult);
                    return new WebApiResponse<ProductResponse>(true, "Success", rm);
                }
                return new WebApiResponse<ProductResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductResponse>>> DeleteProduct(Guid id)
        {
            Product entity = await _productRepository.GetById(id);
            if (entity == null)
                return NotFound();
            else
            {
                if (await _productRepository.Remove(entity))
                {
                    ProductResponse rm = _mapper.Map<ProductResponse>(entity);
                    return new WebApiResponse<ProductResponse>(true, "Success", rm);
                }
                return new WebApiResponse<ProductResponse>(false, "Error");
            }
        }

        [HttpGet("activate/{id}")]
        public async Task<ActionResult<WebApiResponse<bool>>> Activate(Guid id)
        {
            bool result = await _productRepository.Activate(id);
            if (result)
                return new WebApiResponse<bool>(true, "Success", true);
            return new WebApiResponse<bool>(false, "Error");
        }

        [HttpGet("GetByCategoryId/{id}")]
        public async Task<WebApiResponse<List<ProductResponse>>> GetByCategoryId(Guid id)
        {
            var productResult = _mapper.Map<List<ProductResponse>>(await _productRepository.GetDefault(x => x.CategoryId == id).ToListAsync());
            if (productResult.Count > 0)
            {
                return new WebApiResponse<List<ProductResponse>>(true, "Success", productResult);
            }
            return new WebApiResponse<List<ProductResponse>>(false, "Error");
        }

        [HttpGet("GetByBrandId/{id}")]
        public async Task<WebApiResponse<List<ProductResponse>>> GetByBrandId(Guid id)
        {
            var productResult = _mapper.Map<List<ProductResponse>>(await _productRepository.GetDefault(x => x.BrandId == id).ToListAsync());
            if (productResult.Count > 0)
            {
                return new WebApiResponse<List<ProductResponse>>(true, "Success", productResult);
            }
            return new WebApiResponse<List<ProductResponse>>(false, "Error");
        }
    }
}
