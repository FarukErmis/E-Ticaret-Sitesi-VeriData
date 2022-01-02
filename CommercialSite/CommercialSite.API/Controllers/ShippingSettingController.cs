using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.ShippingSetting;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.ShippingSetting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("shippingSetting")]
    public class ShippingSettingController : BaseApiController<ShippingSettingController>
    {
        private readonly IShippingSettingRepository _shippingSettingRepository;
        private readonly IMapper _mapper;
        public ShippingSettingController(
            IShippingSettingRepository shippingSettingRepository,
            IMapper mapper)
        {
            _shippingSettingRepository = shippingSettingRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<ShippingSettingResponse>>>> GetShippingSettings()
        {
            UserResponse currentUser = WorkContext.CurrentUser;
            //using Microsoft.EntityFrameworkCore;
            var shippingSettingResult = _mapper.Map<List<ShippingSettingResponse>>(await _shippingSettingRepository.TableNoTracking.ToListAsync());
            if (shippingSettingResult.Count > 0)
                return new WebApiResponse<List<ShippingSettingResponse>>(true, "Success", shippingSettingResult);
            return new WebApiResponse<List<ShippingSettingResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<ShippingSettingResponse>>> GetShippingSetting(Guid id)
        {
            var shippingSettingResult = _mapper.Map<ShippingSettingResponse>(await _shippingSettingRepository.GetById(id));
            if (shippingSettingResult != null)
                return new WebApiResponse<ShippingSettingResponse>(true, "Success", shippingSettingResult);
            return new WebApiResponse<ShippingSettingResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<ShippingSettingResponse>>> PostShippingSetting(ShippingSettingRequest request)
        {
            ShippingSetting entity = _mapper.Map<ShippingSetting>(request);
            var insertResult = await _shippingSettingRepository.Add(entity);
            if (insertResult != null)
            {
                ShippingSettingResponse rm = _mapper.Map<ShippingSettingResponse>(entity);
                return new WebApiResponse<ShippingSettingResponse>(true, "Success", rm);
            }
            return new WebApiResponse<ShippingSettingResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<ShippingSettingResponse>>> PutShippingSetting(Guid id, ShippingSettingRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                ShippingSetting entity = await _shippingSettingRepository.GetById(id);
                if (entity == null)
                    return NotFound();

                //Eğer request'ten gelen data varsa onu veritabanında günceller, yoksa veri tabanındakini tutar, null ile ezmez....
                _mapper.Map(request, entity);

                var updateResult = await _shippingSettingRepository.Update(entity);
                if (updateResult != null)
                {
                    ShippingSettingResponse rm = _mapper.Map<ShippingSettingResponse>(updateResult);
                    return new WebApiResponse<ShippingSettingResponse>(true, "Success", rm);
                }
                return new WebApiResponse<ShippingSettingResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<ShippingSettingResponse>>> DeleteShippingSetting(Guid id)
        {
            ShippingSetting entity = await _shippingSettingRepository.GetById(id);
            if (entity == null)
                return NotFound();
            else
            {
                if (await _shippingSettingRepository.Remove(entity))
                {
                    ShippingSettingResponse rm = _mapper.Map<ShippingSettingResponse>(entity);
                    return new WebApiResponse<ShippingSettingResponse>(true, "Success", rm);
                }
                return new WebApiResponse<ShippingSettingResponse>(false, "Error");
            }
        }

        [HttpGet("activate/{id}")]
        public async Task<ActionResult<WebApiResponse<bool>>> Activate(Guid id)
        {
            bool result = await _shippingSettingRepository.Activate(id);
            if (result)
                return new WebApiResponse<bool>(true, "Success", true);
            return new WebApiResponse<bool>(false, "Error");
        }

        [HttpGet("getactive")]
        public async Task<ActionResult<WebApiResponse<List<ShippingSettingResponse>>>> GetActive()
        {
            var shippingSettingResult = _mapper.Map<List<ShippingSettingResponse>>(await _shippingSettingRepository.GetActive().ToListAsync());
            if (shippingSettingResult.Count > 0)
                return new WebApiResponse<List<ShippingSettingResponse>>(true, "Success", shippingSettingResult);
            return new WebApiResponse<List<ShippingSettingResponse>>(false, "Error");
        }

        [HttpGet("GetByProductId/{id}")]
        public async Task<WebApiResponse<List<ShippingSettingResponse>>> GetByProductId(Guid id)
        {
            var shippingSettingResult = _mapper.Map<List<ShippingSettingResponse>>(await _shippingSettingRepository.GetDefault(x => x.ProductId == id).ToListAsync());
            if (shippingSettingResult.Count > 0)
            {
                return new WebApiResponse<List<ShippingSettingResponse>>(true, "Success", shippingSettingResult);
            }
            return new WebApiResponse<List<ShippingSettingResponse>>(false, "Error");
        }
    }
}
