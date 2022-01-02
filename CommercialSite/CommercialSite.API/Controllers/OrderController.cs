using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.Order;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("order")]
    public class OrderController : BaseApiController<OrderController>
    {
        private readonly IOrderRepository _pr;
        private readonly IMapper _mapper;
        public OrderController(
            IOrderRepository pr,
            IMapper mapper)
        {
            _pr = pr;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<OrderResponse>>>> GetOrders()
        {
            var result = await _pr
                                            .Table
                                            .Include(x => x.Product)
                                            .Include(x => x.Product.Brand)
                                            .Include(x => x.Product.ProductImages)
                                            .Include(x => x.OrderInfo)
                                            .Include(x => x.User)
                                            .ToListAsync();
            //using Microsoft.EntityFrameworkCore;
            var orderResult = _mapper.Map<List<OrderResponse>>(result);
            if (orderResult.Count > 0)
            {
                return new WebApiResponse<List<OrderResponse>>(true, "Success", orderResult);
            }
            return new WebApiResponse<List<OrderResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<OrderResponse>>> GetOrder(Guid id)
        {
            var orderResult = _mapper.Map<OrderResponse>(await _pr.GetById(id));
            if (orderResult != null)
            {
                return new WebApiResponse<OrderResponse>(true, "Success", orderResult);
            }
            return new WebApiResponse<OrderResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<OrderResponse>>> PostOrder(OrderRequest request)
        {
            Order entity = _mapper.Map<Order>(request);
            var insertResult = await _pr.Add(entity);
            if (insertResult != null)
            {
                OrderResponse rm = _mapper.Map<OrderResponse>(insertResult);
                return new WebApiResponse<OrderResponse>(true, "Success", rm);
            }
            return new WebApiResponse<OrderResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<OrderResponse>>> PutOrder(Guid id, OrderRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                Order entity = await _pr.GetById(id);
                if (entity == null)
                    return NotFound();
                //Eğer request'ten gelen data varsa onu veritabanında günceller, request'ten gelen data yoksa veritabanındakini tutar.
                _mapper.Map(request, entity);

                var updateResult = await _pr.Update(entity);
                if (updateResult != null)
                {
                    OrderResponse rm = _mapper.Map<OrderResponse>(updateResult);
                    return new WebApiResponse<OrderResponse>(true, "Success", rm);
                }
                return new WebApiResponse<OrderResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<OrderResponse>>> DeleteOrder(Guid id)
        {
            var post = await _pr.GetById(id);
            if (post != null)
            {
                if (await _pr.Remove(post))
                    return new WebApiResponse<OrderResponse>(true, "Success", _mapper.Map<OrderResponse>(post));
                else
                    return new WebApiResponse<OrderResponse>(false, "Error");
            }
            return new WebApiResponse<OrderResponse>(false, "Error");
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
        public async Task<ActionResult<WebApiResponse<List<OrderResponse>>>> GetActive()
        {
            var orderResult = _mapper.Map<List<OrderResponse>>(await _pr.GetActive().ToListAsync());
            if (orderResult.Count > 0)
            {
                return new WebApiResponse<List<OrderResponse>>(true, "Success", orderResult);
            }
            return new WebApiResponse<List<OrderResponse>>(false, "Error");
        }

        [HttpGet("GetByUserId/{id}")]
        public async Task<WebApiResponse<List<OrderResponse>>> GetByUserId(Guid id)
        {
            var orderResult = _mapper.Map<List<OrderResponse>>(await _pr.GetDefault(x => x.UserId == id).ToListAsync());
            if (orderResult.Count > 0)
            {
                return new WebApiResponse<List<OrderResponse>>(true, "Success", orderResult);
            }
            return new WebApiResponse<List<OrderResponse>>(false, "Error");
        }

        [HttpGet("GetByOrderInfoId/{id}")]
        public async Task<WebApiResponse<List<OrderResponse>>> GetByOrderInfoId(Guid id)
        {
            var orderResult = _mapper.Map<List<OrderResponse>>(await _pr.GetDefault(x => x.OrderInfoId == id).ToListAsync());
            if (orderResult.Count > 0)
            {
                return new WebApiResponse<List<OrderResponse>>(true, "Success", orderResult);
            }
            return new WebApiResponse<List<OrderResponse>>(false, "Error");
        }

        [HttpGet("GetByProductId/{id}")]
        public async Task<WebApiResponse<List<OrderResponse>>> GetByProductId(Guid id)
        {
            var orderResult = _mapper.Map<List<OrderResponse>>(await _pr.GetDefault(x => x.ProductId == id).ToListAsync());
            if (orderResult.Count > 0)
            {
                return new WebApiResponse<List<OrderResponse>>(true, "Success", orderResult);
            }
            return new WebApiResponse<List<OrderResponse>>(false, "Error");
        }
    }
}
