using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.ShippingAddress;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.ShippingAddress;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("shippingAddress")]
    public class ShippingAddressController : BaseApiController<ShippingAddressController>
    {
        private readonly IShippingAddressRepository _pr;
        private readonly IMapper _mapper;
        public ShippingAddressController(
            IShippingAddressRepository pr,
            IMapper mapper)
        {
            _pr = pr;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<ShippingAddressResponse>>>> GetShippingAddresses()
        {
            //using Microsoft.EntityFrameworkCore;
            var shippingAddress = _mapper.Map<List<ShippingAddressResponse>>(await _pr.TableNoTracking.ToListAsync());
            if (shippingAddress.Count > 0)
            {
                return new WebApiResponse<List<ShippingAddressResponse>>(true, "Success", shippingAddress);
            }
            return new WebApiResponse<List<ShippingAddressResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<ShippingAddressResponse>>> GetShippingAddress(Guid id)
        {
            var shippingAddress = _mapper.Map<ShippingAddressResponse>(await _pr.GetById(id));
            if (shippingAddress != null)
            {
                return new WebApiResponse<ShippingAddressResponse>(true, "Success", shippingAddress);
            }
            return new WebApiResponse<ShippingAddressResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<ShippingAddressResponse>>> PostShippingAddress(ShippingAddressRequest request)
        {
            ShippingAddress entity = _mapper.Map<ShippingAddress>(request);
            var insertResult = await _pr.Add(entity);
            if (insertResult != null)
            {
                ShippingAddressResponse rm = _mapper.Map<ShippingAddressResponse>(insertResult);
                return new WebApiResponse<ShippingAddressResponse>(true, "Success", rm);
            }
            return new WebApiResponse<ShippingAddressResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<ShippingAddressResponse>>> PutShippingAddress(Guid id, ShippingAddressRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                ShippingAddress entity = await _pr.GetById(id);
                if (entity == null)
                    return NotFound();
                //Eğer request'ten gelen data varsa onu veritabanında günceller, request'ten gelen data yoksa veritabanındakini tutar.
                _mapper.Map(request, entity);

                var updateResult = await _pr.Update(entity);
                if (updateResult != null)
                {
                    ShippingAddressResponse rm = _mapper.Map<ShippingAddressResponse>(updateResult);
                    return new WebApiResponse<ShippingAddressResponse>(true, "Success", rm);
                }
                return new WebApiResponse<ShippingAddressResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<ShippingAddressResponse>>> DeleteShippingAddress(Guid id)
        {
            var post = await _pr.GetById(id);
            if (post != null)
            {
                if (await _pr.Remove(post))
                    return new WebApiResponse<ShippingAddressResponse>(true, "Success", _mapper.Map<ShippingAddressResponse>(post));
                else
                    return new WebApiResponse<ShippingAddressResponse>(false, "Error");
            }
            return new WebApiResponse<ShippingAddressResponse>(false, "Error");
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
        public async Task<ActionResult<WebApiResponse<List<ShippingAddressResponse>>>> GetActive()
        {
            var sippingAddressResult = _mapper.Map<List<ShippingAddressResponse>>(await _pr.GetActive().ToListAsync());
            if (sippingAddressResult.Count > 0)
            {
                return new WebApiResponse<List<ShippingAddressResponse>>(true, "Success", sippingAddressResult);
            }
            return new WebApiResponse<List<ShippingAddressResponse>>(false, "Error");
        }

        [HttpGet("GetByUserId/{id}")]
        public async Task<WebApiResponse<List<ShippingAddressResponse>>> GetByUserId(Guid id)
        {
            var sippingAddressResult = _mapper.Map<List<ShippingAddressResponse>>(await _pr.GetDefault(x => x.UserId == id).ToListAsync());
            if (sippingAddressResult.Count > 0)
            {
                return new WebApiResponse<List<ShippingAddressResponse>>(true, "Success", sippingAddressResult);
            }
            return new WebApiResponse<List<ShippingAddressResponse>>(false, "Error");
        }
    }
}
