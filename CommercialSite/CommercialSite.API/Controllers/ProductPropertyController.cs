using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.ProductProperty;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.ProductProperty;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("productProperty")]
    public class ProductPropertyController : BaseApiController<ProductPropertyController>
    {
        private readonly IProductPropertyRepository _productPropertyRepository;
        private readonly IMapper _mapper;
        public ProductPropertyController(
            IProductPropertyRepository productPropertyRepository,
            IMapper mapper)
        {
            _productPropertyRepository = productPropertyRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<ProductPropertyResponse>>>> GetProductProperties()
        {
            UserResponse currentUser = WorkContext.CurrentUser;
            //using Microsoft.EntityFrameworkCore;
            var productPropertyResult = _mapper.Map<List<ProductPropertyResponse>>(await _productPropertyRepository.TableNoTracking.ToListAsync());
            if (productPropertyResult.Count > 0)
                return new WebApiResponse<List<ProductPropertyResponse>>(true, "Success", productPropertyResult);
            return new WebApiResponse<List<ProductPropertyResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductPropertyResponse>>> GetProductProperty(Guid id)
        {
            var productPropertyResult = _mapper.Map<ProductPropertyResponse>(await _productPropertyRepository.GetById(id));
            if (productPropertyResult != null)
                return new WebApiResponse<ProductPropertyResponse>(true, "Success", productPropertyResult);
            return new WebApiResponse<ProductPropertyResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<ProductPropertyResponse>>> PostProductProperty(ProductPropertyRequest request)
        {
            ProductProperty entity = _mapper.Map<ProductProperty>(request);
            var insertResult = await _productPropertyRepository.Add(entity);
            if (entity != null)
            {
                ProductPropertyResponse rm = _mapper.Map<ProductPropertyResponse>(entity);
                return new WebApiResponse<ProductPropertyResponse>(true, "Success", rm);
            }
            return new WebApiResponse<ProductPropertyResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductPropertyResponse>>> PutProductProperty(Guid id, ProductPropertyRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                ProductProperty entity = await _productPropertyRepository.GetById(id);
                if (entity == null)
                    return NotFound();

                //Eğer request'ten gelen data varsa onu veritabanında günceller, yoksa veri tabanındakini tutar, null ile ezmez....
                _mapper.Map(request, entity);

                var updateResult = await _productPropertyRepository.Update(entity);
                if (updateResult != null)
                {
                    ProductPropertyResponse rm = _mapper.Map<ProductPropertyResponse>(updateResult);
                    return new WebApiResponse<ProductPropertyResponse>(true, "Success", rm);
                }
                return new WebApiResponse<ProductPropertyResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductPropertyResponse>>> DeleteProductProperty(Guid id)
        {
            ProductProperty entity = await _productPropertyRepository.GetById(id);
            if (entity == null)
                return NotFound();
            else
            {
                if (await _productPropertyRepository.Remove(entity))
                {
                    ProductPropertyResponse rm = _mapper.Map<ProductPropertyResponse>(entity);
                    return new WebApiResponse<ProductPropertyResponse>(true, "Success", rm);
                }
                return new WebApiResponse<ProductPropertyResponse>(false, "Error");
            }
        }

        [HttpGet("activate/{id}")]
        public async Task<ActionResult<WebApiResponse<bool>>> Activate(Guid id)
        {
            bool result = await _productPropertyRepository.Activate(id);
            if (result)
                return new WebApiResponse<bool>(true, "Success", true);
            return new WebApiResponse<bool>(false, "Error");
        }

        [HttpGet("getactive")]
        public async Task<ActionResult<WebApiResponse<List<ProductPropertyResponse>>>> GetActive()
        {
            var productPropertyResult = _mapper.Map<List<ProductPropertyResponse>>(await _productPropertyRepository.GetActive().ToListAsync());
            if (productPropertyResult.Count > 0)
                return new WebApiResponse<List<ProductPropertyResponse>>(true, "Success", productPropertyResult);
            return new WebApiResponse<List<ProductPropertyResponse>>(false, "Error");
        }

        [HttpGet("GetByProductId/{id}")]
        public async Task<WebApiResponse<List<ProductPropertyResponse>>> GetByProductId(Guid id)
        {
            var productPropertyResult = _mapper.Map<List<ProductPropertyResponse>>(await _productPropertyRepository.GetDefault(x => x.ProductId == id).ToListAsync());
            if (productPropertyResult.Count > 0)
            {
                return new WebApiResponse<List<ProductPropertyResponse>>(true, "Success", productPropertyResult);
            }
            return new WebApiResponse<List<ProductPropertyResponse>>(false, "Error");
        }
    }
}
