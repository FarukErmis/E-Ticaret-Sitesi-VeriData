using CommercialSite.Common.DTOs.Product;
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
    public interface IProductApi
    {
        [Get("/product")]
        Task<ApiResponse<WebApiResponse<List<ProductResponse>>>> List();

        [Get("/product/{id}")]
        Task<ApiResponse<WebApiResponse<ProductResponse>>> Get(Guid id);

        [Post("/product")]
        Task<ApiResponse<WebApiResponse<ProductResponse>>> Post(ProductRequest request);

        [Put("/product/{id}")]
        Task<ApiResponse<WebApiResponse<ProductResponse>>> Put([FromQuery] Guid id, [FromBody] ProductRequest request);

        [Delete("/product/{id}")]
        Task<ApiResponse<WebApiResponse<ProductResponse>>> Delete(Guid id);

        [Get("/product/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/product/getactive")]
        Task<ApiResponse<WebApiResponse<List<ProductResponse>>>> GetActive();

        [Get("/post/GetByCategoryId/{id}")]
        Task<ApiResponse<WebApiResponse<List<ProductResponse>>>> GetByCategoryId(Guid id);

        [Get("/post/GetByBrandId/{id}")]
        Task<ApiResponse<WebApiResponse<List<ProductResponse>>>> GetByBrandId(Guid id);
    }
}
