using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.FavoriteProduct;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.FavoriteProduct;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("favoriteProduct")]
    public class FavoriteProductController : BaseApiController<FavoriteProductController>
    {
        private readonly IFavoriteProductRepository _pr;
        private readonly IMapper _mapper;
        public FavoriteProductController(
            IFavoriteProductRepository pr,
            IMapper mapper)
        {
            _pr = pr;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<FavoriteProductResponse>>>> GetFavoriteProducts()
        {

            var result = await _pr
                                            .Table
                                            .Include(x => x.Product)
                                            .Include(x=> x.Product.Brand)
                                            .Include(x=> x.Product.ProductImages)
                                            .ToListAsync();
            //using Microsoft.EntityFrameworkCore;
            //var productResult = _mapper.Map<List<ProductResponse>>(await _productRepository
            //    .GetDefault(x=> x.Brand.Id == x.BrandId ,x=>x.Brand).ToListAsync());
            var productResult = _mapper.Map<List<FavoriteProductResponse>>(result);
            ////using Microsoft.EntityFrameworkCore;
            //var favoriteProductResult = _mapper.Map<List<FavoriteProductResponse>>(await _pr.TableNoTracking.ToListAsync());
            if (productResult.Count > 0)
            {
                return new WebApiResponse<List<FavoriteProductResponse>>(true, "Success", productResult);
            }
            return new WebApiResponse<List<FavoriteProductResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<FavoriteProductResponse>>> GetFavoriteProduct(Guid id)
        {
            var favoriteProductResult = _mapper.Map<FavoriteProductResponse>(await _pr.GetById(id));
            if (favoriteProductResult != null)
            {
                return new WebApiResponse<FavoriteProductResponse>(true, "Success", favoriteProductResult);
            }
            return new WebApiResponse<FavoriteProductResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<FavoriteProductResponse>>> PostFavoriteProduct(FavoriteProductRequest request)
        {
            FavoriteProduct entity = _mapper.Map<FavoriteProduct>(request);
            var insertResult = await _pr.Add(entity);
            if (insertResult != null)
            {
                FavoriteProductResponse rm = _mapper.Map<FavoriteProductResponse>(insertResult);
                return new WebApiResponse<FavoriteProductResponse>(true, "Success", rm);
            }
            return new WebApiResponse<FavoriteProductResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<FavoriteProductResponse>>> PutFavoriteProduct(Guid id, FavoriteProductRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                FavoriteProduct entity = await _pr.GetById(id);
                if (entity == null)
                    return NotFound();
                //Eğer request'ten gelen data varsa onu veritabanında günceller, request'ten gelen data yoksa veritabanındakini tutar.
                _mapper.Map(request, entity);

                var updateResult = await _pr.Update(entity);
                if (updateResult != null)
                {
                    FavoriteProductResponse rm = _mapper.Map<FavoriteProductResponse>(updateResult);
                    return new WebApiResponse<FavoriteProductResponse>(true, "Success", rm);
                }
                return new WebApiResponse<FavoriteProductResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<FavoriteProductResponse>>> DeleteFavoriteProduct(Guid id)
        {
            var post = await _pr.GetById(id);
            if (post != null)
            {
                if (await _pr.Remove(post))
                    return new WebApiResponse<FavoriteProductResponse>(true, "Success", _mapper.Map<FavoriteProductResponse>(post));
                else
                    return new WebApiResponse<FavoriteProductResponse>(false, "Error");
            }
            return new WebApiResponse<FavoriteProductResponse>(false, "Error");
        }

        [HttpGet("activate/{id}")]
        public async Task<ActionResult<WebApiResponse<bool>>> Activate(Guid id)
        {
            bool result = await _pr.Activate(id);
            if (result)
            {
                return new WebApiResponse<bool>(true, "Success", true);
            }
            return new WebApiResponse<bool>(false, "Error");
        }

        [HttpGet("getactive"), AllowAnonymous]
        public async Task<ActionResult<WebApiResponse<List<FavoriteProductResponse>>>> GetActive()
        {
            var favoriteProductResult = _mapper.Map<List<FavoriteProductResponse>>(await _pr.GetActive().ToListAsync());
            if (favoriteProductResult.Count > 0)
            {
                return new WebApiResponse<List<FavoriteProductResponse>>(true, "Success", favoriteProductResult);
            }
            return new WebApiResponse<List<FavoriteProductResponse>>(false, "Error");
        }

        [HttpGet("GetByUserId/{id}")]
        public async Task<WebApiResponse<List<FavoriteProductResponse>>> GetByUserId(Guid id)
        {
            var favoriteProductResult = _mapper.Map<List<FavoriteProductResponse>>(await _pr.GetDefault(x => x.UserId == id).ToListAsync());
            if (favoriteProductResult.Count > 0)
            {
                return new WebApiResponse<List<FavoriteProductResponse>>(true, "Success", favoriteProductResult);
            }
            return new WebApiResponse<List<FavoriteProductResponse>>(false, "Error");
        }

        [HttpGet("GetByProductId/{id}")]
        public async Task<WebApiResponse<List<FavoriteProductResponse>>> GetByProductId(Guid id)
        {
            var favoriteProductResult = _mapper.Map<List<FavoriteProductResponse>>(await _pr.GetDefault(x => x.ProductId == id).ToListAsync());
            if (favoriteProductResult.Count > 0)
            {
                return new WebApiResponse<List<FavoriteProductResponse>>(true, "Success", favoriteProductResult);
            }
            return new WebApiResponse<List<FavoriteProductResponse>>(false, "Error");
        }
    }
}
