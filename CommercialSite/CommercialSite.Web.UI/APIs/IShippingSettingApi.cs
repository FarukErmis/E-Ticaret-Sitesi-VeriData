using CommercialSite.Common.DTOs.ProductProperty;
using CommercialSite.Common.DTOs.ShippingSetting;
using CommercialSite.Common.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.APIs
{
    [Headers("Authorization: Bearer", "Content-Type: application/json")]
    public interface IShippingSettingApi
    {
        [Get("/iShippingSettingApi")]
        Task<ApiResponse<WebApiResponse<List<ShippingSettingResponse>>>> List();

        [Get("/iShippingSettingApi/{id}")]
        Task<ApiResponse<WebApiResponse<ShippingSettingResponse>>> Get(Guid id);

        [Post("/iShippingSettingApi")]
        Task<ApiResponse<WebApiResponse<ShippingSettingResponse>>> Post(ShippingSettingRequest request);

        [Put("/iShippingSettingApi/{id}")]
        Task<ApiResponse<WebApiResponse<ShippingSettingResponse>>> Put([FromQuery] Guid id, [FromBody] ShippingSettingRequest request);

        [Delete("/iShippingSettingApi/{id}")]
        Task<ApiResponse<WebApiResponse<ShippingSettingResponse>>> Delete(Guid id);

        [Get("/iShippingSettingApi/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/iShippingSettingApi/getactive")]
        Task<ApiResponse<WebApiResponse<List<ShippingSettingResponse>>>> GetActive();

        [Get("/post/GetByProductId/{id}")]
        Task<ApiResponse<WebApiResponse<List<ShippingSettingResponse>>>> GetByProductId(Guid id);
    }
}
