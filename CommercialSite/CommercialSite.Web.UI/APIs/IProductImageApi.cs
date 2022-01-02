using CommercialSite.Common.DTOs.ProductImage;
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
    public interface IProductImageApi
    {
        [Get("/productImage")]
        Task<ApiResponse<WebApiResponse<List<ProductImageResponse>>>> List();

        [Get("/productImage/{id}")]
        Task<ApiResponse<WebApiResponse<ProductImageResponse>>> Get(Guid id);

        [Post("/productImage")]
        Task<ApiResponse<WebApiResponse<ProductImageResponse>>> Post(ProductImageRequest request);

        [Put("/productImage/{id}")]
        Task<ApiResponse<WebApiResponse<ProductImageResponse>>> Put([FromQuery] Guid id, [FromBody] ProductImageRequest request);

        [Delete("/productImage/{id}")]
        Task<ApiResponse<WebApiResponse<ProductImageResponse>>> Delete(Guid id);

        [Get("/productImage/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/productImage/getactive")]
        Task<ApiResponse<WebApiResponse<List<ProductImageResponse>>>> GetActive();

        [Get("/post/GetByProductId/{id}")]
        Task<ApiResponse<WebApiResponse<List<ProductImageResponse>>>> GetByProductId(Guid id);
    }
}
