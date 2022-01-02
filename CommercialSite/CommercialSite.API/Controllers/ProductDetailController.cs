using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.ProductDetail;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.ProductDetail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("productDetail")]
    public class ProductDetailController : BaseApiController<ProductDetailController>
    {
        private readonly IProductDetailRepository _productDetailRepository;
        private readonly IMapper _mapper;
        public ProductDetailController(
            IProductDetailRepository productDetailRepository,
            IMapper mapper)
        {
            _productDetailRepository = productDetailRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<ProductDetailResponse>>>> GetProductDetails()
        {
            UserResponse currentUser = WorkContext.CurrentUser;
            //using Microsoft.EntityFrameworkCore;
            var productDetailResult = _mapper.Map<List<ProductDetailResponse>>(await _productDetailRepository.TableNoTracking.ToListAsync());
            if (productDetailResult.Count > 0)
                return new WebApiResponse<List<ProductDetailResponse>>(true, "Success", productDetailResult);
            return new WebApiResponse<List<ProductDetailResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductDetailResponse>>> GetProductDetail(Guid id)
        {
            var productDetailResult = _mapper.Map<ProductDetailResponse>(await _productDetailRepository.GetById(id));
            if (productDetailResult != null)
                return new WebApiResponse<ProductDetailResponse>(true, "Success", productDetailResult);
            return new WebApiResponse<ProductDetailResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<ProductDetailResponse>>> PostProductDetail(ProductDetailRequest request)
        {
            ProductDetail entity = _mapper.Map<ProductDetail>(request);
            var insertResult = await _productDetailRepository.Add(entity);
            if (insertResult != null)
            {
                ProductDetailResponse rm = _mapper.Map<ProductDetailResponse>(entity);
                return new WebApiResponse<ProductDetailResponse>(true, "Success", rm);
            }
            return new WebApiResponse<ProductDetailResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductDetailResponse>>> PutProductDetail(Guid id, ProductDetailRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                ProductDetail entity = await _productDetailRepository.GetById(id);
                if (entity == null)
                    return NotFound();

                //Eğer request'ten gelen data varsa onu veritabanında günceller, yoksa veri tabanındakini tutar, null ile ezmez....
                _mapper.Map(request, entity);

                var updateResult = await _productDetailRepository.Update(entity);
                if (updateResult != null)
                {
                    ProductDetailResponse rm = _mapper.Map<ProductDetailResponse>(updateResult);
                    return new WebApiResponse<ProductDetailResponse>(true, "Success", rm);
                }
                return new WebApiResponse<ProductDetailResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductDetailResponse>>> DelteCategory(Guid id)
        {
            ProductDetail entity = await _productDetailRepository.GetById(id);
            if (entity == null)
                return NotFound();
            else
            {
                if (await _productDetailRepository.Remove(entity))
                {
                    ProductDetailResponse rm = _mapper.Map<ProductDetailResponse>(entity);
                    return new WebApiResponse<ProductDetailResponse>(true, "Success", rm);
                }
                return new WebApiResponse<ProductDetailResponse>(false, "Error");
            }
        }

        [HttpGet("activate/{id}")]
        public async Task<ActionResult<WebApiResponse<bool>>> Activate(Guid id)
        {
            bool result = await _productDetailRepository.Activate(id);
            if (result)
                return new WebApiResponse<bool>(true, "Success", true);
            return new WebApiResponse<bool>(false, "Error");
        }

        [HttpGet("getactive")]
        public async Task<ActionResult<WebApiResponse<List<ProductDetailResponse>>>> GetActive()
        {
            var productDetailResult = _mapper.Map<List<ProductDetailResponse>>(await _productDetailRepository.GetActive().ToListAsync());
            if (productDetailResult.Count > 0)
                return new WebApiResponse<List<ProductDetailResponse>>(true, "Success", productDetailResult);
            return new WebApiResponse<List<ProductDetailResponse>>(false, "Error");
        }

        [HttpGet("GetByProductId/{id}")]
        public async Task<WebApiResponse<List<ProductDetailResponse>>> GetByProductId(Guid id)
        {
            var productDetailResult = _mapper.Map<List<ProductDetailResponse>>(await _productDetailRepository.GetDefault(x => x.ProductId == id).ToListAsync());
            if (productDetailResult.Count > 0)
            {
                return new WebApiResponse<List<ProductDetailResponse>>(true, "Success", productDetailResult);
            }
            return new WebApiResponse<List<ProductDetailResponse>>(false, "Error");
        }

        [HttpGet("GetByProductCommentId/{id}")]
        public async Task<WebApiResponse<List<ProductDetailResponse>>> GetByProductCommentId(Guid id)
        {
            var productDetailResult = _mapper.Map<List<ProductDetailResponse>>(await _productDetailRepository.GetDefault(x => x.ProductCommentId == id).ToListAsync());
            if (productDetailResult.Count > 0)
            {
                return new WebApiResponse<List<ProductDetailResponse>>(true, "Success", productDetailResult);
            }
            return new WebApiResponse<List<ProductDetailResponse>>(false, "Error");
        }

        [HttpGet("GetByProductPropertyId/{id}")]
        public async Task<WebApiResponse<List<ProductDetailResponse>>> GetByProductPropertyId(Guid id)
        {
            var productDetailResult = _mapper.Map<List<ProductDetailResponse>>(await _productDetailRepository.GetDefault(x => x.ProductId == id).ToListAsync());
            if (productDetailResult.Count > 0)
            {
                return new WebApiResponse<List<ProductDetailResponse>>(true, "Success", productDetailResult);
            }
            return new WebApiResponse<List<ProductDetailResponse>>(false, "Error");
        }

        [HttpGet("GetByProductImageId/{id}")]
        public async Task<WebApiResponse<List<ProductDetailResponse>>> GetByProductImageId(Guid id)
        {
            var productDetailResult = _mapper.Map<List<ProductDetailResponse>>(await _productDetailRepository.GetDefault(x => x.ProductId == id).ToListAsync());
            if (productDetailResult.Count > 0)
            {
                return new WebApiResponse<List<ProductDetailResponse>>(true, "Success", productDetailResult);
            }
            return new WebApiResponse<List<ProductDetailResponse>>(false, "Error");
        }

        [HttpGet("GetByShippingSettingId/{id}")]
        public async Task<WebApiResponse<List<ProductDetailResponse>>> GetByShippingSettingId(Guid id)
        {
            var productDetailResult = _mapper.Map<List<ProductDetailResponse>>(await _productDetailRepository.GetDefault(x => x.ProductId == id).ToListAsync());
            if (productDetailResult.Count > 0)
            {
                return new WebApiResponse<List<ProductDetailResponse>>(true, "Success", productDetailResult);
            }
            return new WebApiResponse<List<ProductDetailResponse>>(false, "Error");
        }
    }
}
