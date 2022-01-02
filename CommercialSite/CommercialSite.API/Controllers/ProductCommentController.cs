using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.ProductComment;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.ProductComment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("productComment")]
    public class ProductCommentController : BaseApiController<ProductCommentController>
    {
        private readonly IProductCommentRepository _productCommentRepository;
        private readonly IMapper _mapper;
        public ProductCommentController(
            IProductCommentRepository productCommentRepository,
            IMapper mapper)
        {
            _productCommentRepository = productCommentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<ProductCommentResponse>>>> GetProductComments()
        {
            UserResponse currentUser = WorkContext.CurrentUser;
            //using Microsoft.EntityFrameworkCore;
            var productCommentResult = _mapper.Map<List<ProductCommentResponse>>(await _productCommentRepository.TableNoTracking.ToListAsync());
            if (productCommentResult.Count > 0)
                return new WebApiResponse<List<ProductCommentResponse>>(true, "Success", productCommentResult);
            return new WebApiResponse<List<ProductCommentResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductCommentResponse>>> GetProductComment(Guid id)
        {
            var productCommentResult = _mapper.Map<ProductCommentResponse>(await _productCommentRepository.GetById(id));
            if (productCommentResult != null)
                return new WebApiResponse<ProductCommentResponse>(true, "Success", productCommentResult);
            return new WebApiResponse<ProductCommentResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<ProductCommentResponse>>> PostProductComment(ProductCommentRequest request)
        {
            ProductComment entity = _mapper.Map<ProductComment>(request);
            var insertResult = await _productCommentRepository.Add(entity);
            if (insertResult != null)
            {
                ProductCommentResponse rm = _mapper.Map<ProductCommentResponse>(entity);
                return new WebApiResponse<ProductCommentResponse>(true, "Success", rm);
            }
            return new WebApiResponse<ProductCommentResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductCommentResponse>>> PutProductComment(Guid id, ProductCommentRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                ProductComment entity = await _productCommentRepository.GetById(id);
                if (entity == null)
                    return NotFound();

                //Eğer request'ten gelen data varsa onu veritabanında günceller, yoksa veri tabanındakini tutar, null ile ezmez....
                _mapper.Map(request, entity);

                var updateResult = await _productCommentRepository.Update(entity);
                if (updateResult != null)
                {
                    ProductCommentResponse rm = _mapper.Map<ProductCommentResponse>(updateResult);
                    return new WebApiResponse<ProductCommentResponse>(true, "Success", rm);
                }
                return new WebApiResponse<ProductCommentResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<ProductCommentResponse>>> DeleteProductComment(Guid id)
        {
            ProductComment entity = await _productCommentRepository.GetById(id);
            if (entity == null)
                return NotFound();
            else
            {
                if (await _productCommentRepository.Remove(entity))
                {
                    ProductCommentResponse rm = _mapper.Map<ProductCommentResponse>(entity);
                    return new WebApiResponse<ProductCommentResponse>(true, "Success", rm);
                }
                return new WebApiResponse<ProductCommentResponse>(false, "Error");
            }
        }

        [HttpGet("activate/{id}")]
        public async Task<ActionResult<WebApiResponse<bool>>> Activate(Guid id)
        {
            bool result = await _productCommentRepository.Activate(id);
            if (result)
                return new WebApiResponse<bool>(true, "Success", true);
            return new WebApiResponse<bool>(false, "Error");
        }

        [HttpGet("GetByProductId/{id}")]
        public async Task<WebApiResponse<List<ProductCommentResponse>>> GetByProductId(Guid id)
        {
            var productCommentResult = _mapper.Map<List<ProductCommentResponse>>(await _productCommentRepository.GetDefault(x => x.ProductId == id).ToListAsync());
            if (productCommentResult.Count > 0)
            {
                return new WebApiResponse<List<ProductCommentResponse>>(true, "Success", productCommentResult);
            }
            return new WebApiResponse<List<ProductCommentResponse>>(false, "Error");
        }
    }
}
