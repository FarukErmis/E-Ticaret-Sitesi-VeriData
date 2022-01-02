using CommercialSite.Common.DTOs.ProductProperty;
using CommercialSite.Common.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.APIs
{
    [Headers("Authorization: Bearer", "Content-Type: application/json")]
    public interface IProductPropertyApi
    {
        [Get("/productProperty")]
        Task<ApiResponse<WebApiResponse<List<ProductPropertyResponse>>>> List();

        [Get("/productProperty/{id}")]
        Task<ApiResponse<WebApiResponse<ProductPropertyResponse>>> Get(Guid id);

        [Post("/productProperty")]
        Task<ApiResponse<WebApiResponse<ProductPropertyResponse>>> Post(ProductPropertyRequest request);

        [Put("/productProperty/{id}")]
        Task<ApiResponse<WebApiResponse<ProductPropertyResponse>>> Put([FromQuery] Guid id, [FromBody] ProductPropertyRequest request);

        [Delete("/productProperty/{id}")]
        Task<ApiResponse<WebApiResponse<ProductPropertyResponse>>> Delete(Guid id);

        [Get("/productProperty/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/productProperty/getactive")]
        Task<ApiResponse<WebApiResponse<List<ProductPropertyResponse>>>> GetActive();

        [Get("/post/GetByProductId/{id}")]
        Task<ApiResponse<WebApiResponse<List<ProductPropertyResponse>>>> GetByProductId(Guid id);
    }
}
