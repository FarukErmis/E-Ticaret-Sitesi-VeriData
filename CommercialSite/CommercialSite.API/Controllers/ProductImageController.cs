using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.ProductImage;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.ProductImage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("productImage")]
    public class ProductImageController : BaseApiController<ProductImageController>
    {
        private readonly IProductImageRepository _productImageRepository;
        private readonly IMapper _mapper;
        public ProductImageController(
            IProductImageRepository productImageRepository,
            IMapper mapper)
        {
            _productImageRepository = productImageRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<ProductImageResponse>>>> GetProductImages()
        {
            UserResponse currentUser = WorkContext.CurrentUser;
            //using Microsoft.EntityFrameworkCore;
            var productImageResult = _mapper.Map<List<ProductImageResponse>>(await _productImageRepository.TableNoTracking.ToListAsync());
            if (productImageResult.Count > 0)
                return new WebApiResponse<List<ProductImageResponse>>(true, "Success", productImageResult);
            return new WebApiResponse<List<ProductImageResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductImageResponse>>> GetProductImage(Guid id)
        {
            var productImageResult = _mapper.Map<ProductImageResponse>(await _productImageRepository.GetById(id));
            if (productImageResult != null)
                return new WebApiResponse<ProductImageResponse>(true, "Success", productImageResult);
            return new WebApiResponse<ProductImageResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<ProductImageResponse>>> PostProductImage(ProductImageRequest request)
        {
            ProductImage entity = _mapper.Map<ProductImage>(request);
            var insertResult = await _productImageRepository.Add(entity);
            if (entity != null)
            {
                ProductImageResponse rm = _mapper.Map<ProductImageResponse>(entity);
                return new WebApiResponse<ProductImageResponse>(true, "Success", rm);
            }
            return new WebApiResponse<ProductImageResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductImageResponse>>> PutProductImage(Guid id, ProductImageRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                ProductImage entity = await _productImageRepository.GetById(id);
                if (entity == null)
                    return NotFound();

                //Eğer request'ten gelen data varsa onu veritabanında günceller, yoksa veri tabanındakini tutar, null ile ezmez....
                _mapper.Map(request, entity);

                var updateResult = await _productImageRepository.Update(entity);
                if (updateResult != null)
                {
                    ProductImageResponse rm = _mapper.Map<ProductImageResponse>(updateResult);
                    return new WebApiResponse<ProductImageResponse>(true, "Success", rm);
                }
                return new WebApiResponse<ProductImageResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductImageResponse>>> DeleteProductImage(Guid id)
        {
            ProductImage entity = await _productImageRepository.GetById(id);
            if (entity == null)
                return NotFound();
            else
            {
                if (await _productImageRepository.Remove(entity))
                {
                    ProductImageResponse rm = _mapper.Map<ProductImageResponse>(entity);
                    return new WebApiResponse<ProductImageResponse>(true, "Success", rm);
                }
                return new WebApiResponse<ProductImageResponse>(false, "Error");
            }
        }

        [HttpGet("activate/{id}")]
        public async Task<ActionResult<WebApiResponse<bool>>> Activate(Guid id)
        {
            bool result = await _productImageRepository.Activate(id);
            if (result)
                return new WebApiResponse<bool>(true, "Success", true);
            return new WebApiResponse<bool>(false, "Error");
        }

        [HttpGet("getactive")]
        public async Task<ActionResult<WebApiResponse<List<ProductImageResponse>>>> GetActive()
        {
            var productImageResult = _mapper.Map<List<ProductImageResponse>>(await _productImageRepository.GetActive().ToListAsync());
            if (productImageResult.Count > 0)
                return new WebApiResponse<List<ProductImageResponse>>(true, "Success", productImageResult);
            return new WebApiResponse<List<ProductImageResponse>>(false, "Error");
        }

        [HttpGet("GetByProductId/{id}")]
        public async Task<WebApiResponse<List<ProductImageResponse>>> GetByProductId(Guid id)
        {
            var productDetailResult = _mapper.Map<List<ProductImageResponse>>(await _productImageRepository.GetDefault(x => x.ProductId == id).ToListAsync());
            if (productDetailResult.Count > 0)
            {
                return new WebApiResponse<List<ProductImageResponse>>(true, "Success", productDetailResult);
            }
            return new WebApiResponse<List<ProductImageResponse>>(false, "Error");
        }
    }
}
