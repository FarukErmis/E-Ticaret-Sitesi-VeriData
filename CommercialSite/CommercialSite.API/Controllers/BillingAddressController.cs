using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.BillingAddress;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.BillingAddress;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("billingAddress")]
    public class BillingAddressController : BaseApiController<BillingAddressController>
    {
        private readonly IBillingAddressRepository _pr;
        private readonly IMapper _mapper;
        public BillingAddressController(
            IBillingAddressRepository pr,
            IMapper mapper)
        {
            _pr = pr;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<BillingAddressResponse>>>> GetBillingAddresses()
        {
            //using Microsoft.EntityFrameworkCore;
            var billingAddressResult = _mapper.Map<List<BillingAddressResponse>>(await _pr.TableNoTracking.ToListAsync());
            if (billingAddressResult.Count > 0)
            {
                return new WebApiResponse<List<BillingAddressResponse>>(true, "Success", billingAddressResult);
            }
            return new WebApiResponse<List<BillingAddressResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<BillingAddressResponse>>> GetBillingAddress(Guid id)
        {
            var billingAddressResult = _mapper.Map<BillingAddressResponse>(await _pr.GetById(id));
            if (billingAddressResult != null)
            {
                return new WebApiResponse<BillingAddressResponse>(true, "Success", billingAddressResult);
            }
            return new WebApiResponse<BillingAddressResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<BillingAddressResponse>>> PostBillingAddress(BillingAddressRequest request)
        {
            BillingAddress entity = _mapper.Map<BillingAddress>(request);
            var insertResult = await _pr.Add(entity);
            if (insertResult != null)
            {
                BillingAddressResponse rm = _mapper.Map<BillingAddressResponse>(insertResult);
                return new WebApiResponse<BillingAddressResponse>(true, "Success", rm);
            }
            return new WebApiResponse<BillingAddressResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<BillingAddressResponse>>> PutBillingAddress(Guid id, BillingAddressRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                BillingAddress entity = await _pr.GetById(id);
                if (entity == null)
                    return NotFound();
                //Eğer request'ten gelen data varsa onu veritabanında günceller, request'ten gelen data yoksa veritabanındakini tutar.
                _mapper.Map(request, entity);

                var updateResult = await _pr.Update(entity);
                if (updateResult != null)
                {
                    BillingAddressResponse rm = _mapper.Map<BillingAddressResponse>(updateResult);
                    return new WebApiResponse<BillingAddressResponse>(true, "Success", rm);
                }
                return new WebApiResponse<BillingAddressResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<BillingAddressResponse>>> DeleteBillingAddress(Guid id)
        {
            var post = await _pr.GetById(id);
            if (post != null)
            {
                if (await _pr.Remove(post))
                    return new WebApiResponse<BillingAddressResponse>(true, "Success", _mapper.Map<BillingAddressResponse>(post));
                else
                    return new WebApiResponse<BillingAddressResponse>(false, "Error");
            }
            return new WebApiResponse<BillingAddressResponse>(false, "Error");
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
        public async Task<ActionResult<WebApiResponse<List<BillingAddressResponse>>>> GetActive()
        {
            var billingAddressResult = _mapper.Map<List<BillingAddressResponse>>(await _pr.GetActive().ToListAsync());
            if (billingAddressResult.Count > 0)
            {
                return new WebApiResponse<List<BillingAddressResponse>>(true, "Success", billingAddressResult);
            }
            return new WebApiResponse<List<BillingAddressResponse>>(false, "Error");
        }

        [HttpGet("GetByUserId/{id}")]
        public async Task<WebApiResponse<List<BillingAddressResponse>>> GetByUserId(Guid id)
        {
            var billingAddressResult = _mapper.Map<List<BillingAddressResponse>>(await _pr.GetDefault(x => x.UserId == id).ToListAsync());
            if (billingAddressResult.Count > 0)
            {
                return new WebApiResponse<List<BillingAddressResponse>>(true, "Success", billingAddressResult);
            }
            return new WebApiResponse<List<BillingAddressResponse>>(false, "Error");
        }
    }
}
