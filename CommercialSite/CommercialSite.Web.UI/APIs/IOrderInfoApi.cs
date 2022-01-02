using CommercialSite.Common.DTOs.OrderInfo;
using CommercialSite.Common.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.APIs
{
    [Headers("Authorization: Bearer", "Content-Type: application/json")]
    public interface IOrderInfoApi
    {
        [Get("/orderInfo")]
        Task<ApiResponse<WebApiResponse<List<OrderInfoResponse>>>> List();

        [Get("/orderInfo/{id}")]
        Task<ApiResponse<WebApiResponse<OrderInfoResponse>>> Get(Guid id);

        [Post("/orderInfo")]
        Task<ApiResponse<WebApiResponse<OrderInfoResponse>>> Post(OrderInfoRequest request);

        [Put("/orderInfo/{id}")]
        Task<ApiResponse<WebApiResponse<OrderInfoResponse>>> Put([FromQuery] Guid id, [FromBody] OrderInfoRequest request);

        [Delete("/orderInfo/{id}")]
        Task<ApiResponse<WebApiResponse<OrderInfoResponse>>> Delete(Guid id);

        [Get("/orderInfo/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/orderInfo/getactive")]
        Task<ApiResponse<WebApiResponse<List<OrderInfoResponse>>>> GetActive();

        [Get("/post/GetByUserId/{id}")]
        Task<ApiResponse<WebApiResponse<List<OrderInfoResponse>>>> GetByUserId(Guid id);

        [Get("/post/GetByShipmentInfoId/{id}")]
        Task<ApiResponse<WebApiResponse<List<OrderInfoResponse>>>> GetByShipmentInfoId(Guid id);
    }
}
