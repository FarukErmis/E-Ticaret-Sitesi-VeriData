using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.OrderInfo;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.OrderInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("orderInfo")]
    public class OrderInfoController : BaseApiController<OrderInfoController>
    {
        private readonly IOrderInfoRepository _pr;
        private readonly IMapper _mapper;
        public OrderInfoController(
            IOrderInfoRepository pr,
            IMapper mapper)
        {
            _pr = pr;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<OrderInfoResponse>>>> GetOrderInfos()
        {
            //using Microsoft.EntityFrameworkCore;
            var orderInfoResult = _mapper.Map<List<OrderInfoResponse>>(await _pr.TableNoTracking.ToListAsync());
            if (orderInfoResult.Count > 0)
            {
                return new WebApiResponse<List<OrderInfoResponse>>(true, "Success", orderInfoResult);
            }
            return new WebApiResponse<List<OrderInfoResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<OrderInfoResponse>>> GetOrderInfo(Guid id)
        {
            var orderInfoResult = _mapper.Map<OrderInfoResponse>(await _pr.GetById(id));
            if (orderInfoResult != null)
            {
                return new WebApiResponse<OrderInfoResponse>(true, "Success", orderInfoResult);
            }
            return new WebApiResponse<OrderInfoResponse>(false, "Error");
        }

        [HttpPost,AllowAnonymous]
        public async Task<ActionResult<WebApiResponse<OrderInfoResponse>>> PostOrderInfo(OrderInfoRequest request)
        {
            OrderInfo entity = _mapper.Map<OrderInfo>(request);
            var insertResult = await _pr.Add(entity);
            if (insertResult != null)
            {
                OrderInfoResponse rm = _mapper.Map<OrderInfoResponse>(insertResult);
                return new WebApiResponse<OrderInfoResponse>(true, "Success", rm);
            }
            return new WebApiResponse<OrderInfoResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<OrderInfoResponse>>> PutOrderInfo(Guid id, OrderInfoRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                OrderInfo entity = await _pr.GetById(id);
                if (entity == null)
                    return NotFound();
                //Eğer request'ten gelen data varsa onu veritabanında günceller, request'ten gelen data yoksa veritabanındakini tutar.
                _mapper.Map(request, entity);

                var updateResult = await _pr.Update(entity);
                if (updateResult != null)
                {
                    OrderInfoResponse rm = _mapper.Map<OrderInfoResponse>(updateResult);
                    return new WebApiResponse<OrderInfoResponse>(true, "Success", rm);
                }
                return new WebApiResponse<OrderInfoResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<OrderInfoResponse>>> DeleteOrderInfo(Guid id)
        {
            var post = await _pr.GetById(id);
            if (post != null)
            {
                if (await _pr.Remove(post))
                    return new WebApiResponse<OrderInfoResponse>(true, "Success", _mapper.Map<OrderInfoResponse>(post));
                else
                    return new WebApiResponse<OrderInfoResponse>(false, "Error");
            }
            return new WebApiResponse<OrderInfoResponse>(false, "Error");
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
        public async Task<ActionResult<WebApiResponse<List<OrderInfoResponse>>>> GetActive()
        {
            var orderInfoResult = _mapper.Map<List<OrderInfoResponse>>(await _pr.GetActive().ToListAsync());
            if (orderInfoResult.Count > 0)
            {
                return new WebApiResponse<List<OrderInfoResponse>>(true, "Success", orderInfoResult);
            }
            return new WebApiResponse<List<OrderInfoResponse>>(false, "Error");
        }

        [HttpGet("GetByShipmentInfoId/{id}")]
        public async Task<WebApiResponse<List<OrderInfoResponse>>> GetByShipmentInfoId(Guid id)
        {
            var orderInfoResult = _mapper.Map<List<OrderInfoResponse>>(await _pr.GetDefault(x => x.ShipmentInfoId == id).ToListAsync());
            if (orderInfoResult.Count > 0)
            {
                return new WebApiResponse<List<OrderInfoResponse>>(true, "Success", orderInfoResult);
            }
            return new WebApiResponse<List<OrderInfoResponse>>(false, "Error");
        }

        [HttpGet("GetByUserId/{id}")]
        public async Task<WebApiResponse<List<OrderInfoResponse>>> GetByUserId(Guid id)
        {
            var orderInfoResult = _mapper.Map<List<OrderInfoResponse>>(await _pr.GetDefault(x => x.UserId == id).ToListAsync());
            if (orderInfoResult.Count > 0)
            {
                return new WebApiResponse<List<OrderInfoResponse>>(true, "Success", orderInfoResult);
            }
            return new WebApiResponse<List<OrderInfoResponse>>(false, "Error");
        }
    }
}
