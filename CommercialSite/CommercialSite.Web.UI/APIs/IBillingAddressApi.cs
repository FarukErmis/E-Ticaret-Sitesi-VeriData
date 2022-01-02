using CommercialSite.Common.DTOs.BillingAddress;
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
    public interface IBillingAddressApi
    {
        [Get("/billingAddress")]
        Task<ApiResponse<WebApiResponse<List<BillingAddressResponse>>>> List();

        [Get("/billingAddress/{id}")]
        Task<ApiResponse<WebApiResponse<BillingAddressResponse>>> Get(Guid id);

        [Post("/billingAddress")]
        Task<ApiResponse<WebApiResponse<BillingAddressResponse>>> Post(BillingAddressRequest request);

        [Put("/billingAddress/{id}")]
        Task<ApiResponse<WebApiResponse<BillingAddressResponse>>> Put([FromQuery] Guid id, [FromBody] BillingAddressRequest request);

        [Delete("/billingAddress/{id}")]
        Task<ApiResponse<WebApiResponse<BillingAddressResponse>>> Delete(Guid id);

        [Get("/billingAddress/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/billingAddress/getactive")]
        Task<ApiResponse<WebApiResponse<List<BillingAddressResponse>>>> GetActive();

        [Get("/post/GetByUserId/{id}")]
        Task<ApiResponse<WebApiResponse<List<BillingAddressResponse>>>> GetByUserId(Guid id);
    }
}
