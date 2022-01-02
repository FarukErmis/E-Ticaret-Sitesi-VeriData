using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.Brand;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.Brand;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("brand")]
    public class BrandController : BaseApiController<BrandController>
    {
        private readonly IBrandRepository _pr;
        private readonly IMapper _mapper;
        public BrandController(
            IBrandRepository pr,
            IMapper mapper)
        {
            _pr = pr;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<BrandResponse>>>> GetBrands()
        {
            //using Microsoft.EntityFrameworkCore;
            var brandResult = _mapper.Map<List<BrandResponse>>(await _pr.TableNoTracking.ToListAsync());
            if (brandResult.Count > 0)
            {
                return new WebApiResponse<List<BrandResponse>>(true, "Success", brandResult);
            }
            return new WebApiResponse<List<BrandResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<BrandResponse>>> GetBrand(Guid id)
        {
            var brandResult = _mapper.Map<BrandResponse>(await _pr.GetById(id));
            if (brandResult != null)
            {
                return new WebApiResponse<BrandResponse>(true, "Success", brandResult);
            }
            return new WebApiResponse<BrandResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<BrandResponse>>> PostBrand(BrandResponse request)
        {
            Brand entity = _mapper.Map<Brand>(request);
            var insertResult = await _pr.Add(entity);
            if (insertResult != null)
            {
                BrandResponse rm = _mapper.Map<BrandResponse>(insertResult);
                return new WebApiResponse<BrandResponse>(true, "Success", rm);
            }
            return new WebApiResponse<BrandResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<BrandResponse>>> PutBrand(Guid id, BrandRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                Brand entity = await _pr.GetById(id);
                if (entity == null)
                    return NotFound();
                //Eğer request'ten gelen data varsa onu veritabanında günceller, request'ten gelen data yoksa veritabanındakini tutar.
                _mapper.Map(request, entity);

                var updateResult = await _pr.Update(entity);
                if (updateResult != null)
                {
                    BrandResponse rm = _mapper.Map<BrandResponse>(updateResult);
                    return new WebApiResponse<BrandResponse>(true, "Success", rm);
                }
                return new WebApiResponse<BrandResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<BrandResponse>>> DeleteBrand(Guid id)
        {
            var post = await _pr.GetById(id);
            if (post != null)
            {
                if (await _pr.Remove(post))
                    return new WebApiResponse<BrandResponse>(true, "Success", _mapper.Map<BrandResponse>(post));
                else
                    return new WebApiResponse<BrandResponse>(false, "Error");
            }
            return new WebApiResponse<BrandResponse>(false, "Error");
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
        public async Task<ActionResult<WebApiResponse<List<BrandResponse>>>> GetActive()
        {
            var brandResult = _mapper.Map<List<BrandResponse>>(await _pr.GetActive().ToListAsync());
            if (brandResult.Count > 0)
            {
                return new WebApiResponse<List<BrandResponse>>(true, "Success", brandResult);
            }
            return new WebApiResponse<List<BrandResponse>>(false, "Error");
        }
    }
}
