using CommercialSite.Common.DTOs.Order;
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
    public interface IOrderApi
    {
        [Get("/order")]
        Task<ApiResponse<WebApiResponse<List<OrderResponse>>>> List();

        [Get("/order/{id}")]
        Task<ApiResponse<WebApiResponse<OrderResponse>>> Get(Guid id);

        [Post("/order")]
        Task<ApiResponse<WebApiResponse<OrderResponse>>> Post(OrderRequest request);

        [Put("/order/{id}")]
        Task<ApiResponse<WebApiResponse<OrderResponse>>> Put([FromQuery] Guid id, [FromBody] OrderRequest request);

        [Delete("/order/{id}")]
        Task<ApiResponse<WebApiResponse<OrderResponse>>> Delete(Guid id);

        [Get("/order/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/order/getactive")]
        Task<ApiResponse<WebApiResponse<List<OrderResponse>>>> GetActive();

        [Get("/post/GetByUserId/{id}")]
        Task<ApiResponse<WebApiResponse<List<OrderResponse>>>> GetByUserId(Guid id);

        [Get("/post/GetByProductId/{id}")]
        Task<ApiResponse<WebApiResponse<List<OrderResponse>>>> GetByProductId(Guid id);

        [Get("/post/GetByOrderInfoId/{id}")]
        Task<ApiResponse<WebApiResponse<List<OrderResponse>>>> GetByOrderInfoId(Guid id);
    }
}
