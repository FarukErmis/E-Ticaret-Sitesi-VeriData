using CommercialSite.Common.DTOs.ShippingAddress;
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
    public interface IShippingAddressApi
    {
        [Get("/shippingAddress")]
        Task<ApiResponse<WebApiResponse<List<ShippingAddressResponse>>>> List();

        [Get("/shippingAddress/{id}")]
        Task<ApiResponse<WebApiResponse<ShippingAddressResponse>>> Get(Guid id);

        [Post("/shippingAddress")]
        Task<ApiResponse<WebApiResponse<ShippingAddressResponse>>> Post(ShippingAddressRequest request);

        [Put("/shippingAddress/{id}")]
        Task<ApiResponse<WebApiResponse<ShippingAddressResponse>>> Put([FromQuery] Guid id, [FromBody] ShippingAddressRequest request);

        [Delete("/shippingAddress/{id}")]
        Task<ApiResponse<WebApiResponse<ShippingAddressResponse>>> Delete(Guid id);

        [Get("/shippingAddress/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/shippingAddress/getactive")]
        Task<ApiResponse<WebApiResponse<List<ShippingAddressResponse>>>> GetActive();

        [Get("/post/GetByUserId/{id}")]
        Task<ApiResponse<WebApiResponse<List<ShippingAddressResponse>>>> GetByUserId(Guid id);
    }
}
