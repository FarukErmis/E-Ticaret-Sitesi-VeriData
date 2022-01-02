using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.ShipmentInfo;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.ShipmentInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("shipmentInfo")]
    public class ShipmentInfoController : BaseApiController<ShipmentInfoController>
    {
        private readonly IShipmentInfoRepository _pr;
        private readonly IMapper _mapper;
        public ShipmentInfoController(
            IShipmentInfoRepository pr,
            IMapper mapper)
        {
            _pr = pr;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<ShipmentInfoResponse>>>> GetShipmentInfos()
        {
            //using Microsoft.EntityFrameworkCore;
            var shipmentInfoResult = _mapper.Map<List<ShipmentInfoResponse>>(await _pr.TableNoTracking.ToListAsync());
            if (shipmentInfoResult.Count > 0)
            {
                return new WebApiResponse<List<ShipmentInfoResponse>>(true, "Success", shipmentInfoResult);
            }
            return new WebApiResponse<List<ShipmentInfoResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<ShipmentInfoResponse>>> GetShipmentInfo(Guid id)
        {
            var shipmentInfoResult = _mapper.Map<ShipmentInfoResponse>(await _pr.GetById(id));
            if (shipmentInfoResult != null)
            {
                return new WebApiResponse<ShipmentInfoResponse>(true, "Success", shipmentInfoResult);
            }
            return new WebApiResponse<ShipmentInfoResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<ShipmentInfoResponse>>> PostShipmentInfo(ShipmentInfoRequest request)
        {
            ShipmentInfo entity = _mapper.Map<ShipmentInfo>(request);
            var insertResult = await _pr.Add(entity);
            if (insertResult != null)
            {
                ShipmentInfoResponse rm = _mapper.Map<ShipmentInfoResponse>(insertResult);
                return new WebApiResponse<ShipmentInfoResponse>(true, "Success", rm);
            }
            return new WebApiResponse<ShipmentInfoResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<ShipmentInfoResponse>>> PutShipmentInfo(Guid id, ShipmentInfoRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                ShipmentInfo entity = await _pr.GetById(id);
                if (entity == null)
                    return NotFound();
                //Eğer request'ten gelen data varsa onu veritabanında günceller, request'ten gelen data yoksa veritabanındakini tutar.
                _mapper.Map(request, entity);

                var updateResult = await _pr.Update(entity);
                if (updateResult != null)
                {
                    ShipmentInfoResponse rm = _mapper.Map<ShipmentInfoResponse>(updateResult);
                    return new WebApiResponse<ShipmentInfoResponse>(true, "Success", rm);
                }
                return new WebApiResponse<ShipmentInfoResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<ShipmentInfoResponse>>> DeleteShipmentInfo(Guid id)
        {
            var post = await _pr.GetById(id);
            if (post != null)
            {
                if (await _pr.Remove(post))
                    return new WebApiResponse<ShipmentInfoResponse>(true, "Success", _mapper.Map<ShipmentInfoResponse>(post));
                else
                    return new WebApiResponse<ShipmentInfoResponse>(false, "Error");
            }
            return new WebApiResponse<ShipmentInfoResponse>(false, "Error");
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
        public async Task<ActionResult<WebApiResponse<List<ShipmentInfoResponse>>>> GetActive()
        {
            var shipmentInfoResult = _mapper.Map<List<ShipmentInfoResponse>>(await _pr.GetActive().ToListAsync());
            if (shipmentInfoResult.Count > 0)
            {
                return new WebApiResponse<List<ShipmentInfoResponse>>(true, "Success", shipmentInfoResult);
            }
            return new WebApiResponse<List<ShipmentInfoResponse>>(false, "Error");
        }
    }
}
