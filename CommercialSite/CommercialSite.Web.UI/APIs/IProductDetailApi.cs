using CommercialSite.Common.DTOs.ProductDetail;
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
    public interface IProductDetailApi
    {
        [Get("/productDetail")]
        Task<ApiResponse<WebApiResponse<List<ProductDetailResponse>>>> List();

        [Get("/productDetail/{id}")]
        Task<ApiResponse<WebApiResponse<ProductDetailResponse>>> Get(Guid id);

        [Post("/productDetail")]
        Task<ApiResponse<WebApiResponse<ProductDetailResponse>>> Post(ProductDetailRequest request);

        [Put("/productDetail/{id}")]
        Task<ApiResponse<WebApiResponse<ProductDetailResponse>>> Put([FromQuery] Guid id, [FromBody] ProductDetailRequest request);

        [Delete("/productDetail/{id}")]
        Task<ApiResponse<WebApiResponse<ProductDetailResponse>>> Delete(Guid id);

        [Get("/productDetail/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/productDetail/getactive")]
        Task<ApiResponse<WebApiResponse<List<ProductDetailResponse>>>> GetActive();

        [Get("/post/GetByProductId/{id}")]
        Task<ApiResponse<WebApiResponse<List<ProductDetailResponse>>>> GetByProductId(Guid id);

        [Get("/post/GetByProductCommentId/{id}")]
        Task<ApiResponse<WebApiResponse<List<ProductDetailResponse>>>> GetByProductCommentId(Guid id);

        [Get("/post/GetByProductImageId/{id}")]
        Task<ApiResponse<WebApiResponse<List<ProductDetailResponse>>>> GetByProductImageId(Guid id);

        [Get("/post/GetByProductPropertyId/{id}")]
        Task<ApiResponse<WebApiResponse<List<ProductDetailResponse>>>> GetByProductPropertyId(Guid id);

        [Get("/post/GetByShippingSettingId/{id}")]
        Task<ApiResponse<WebApiResponse<List<ProductDetailResponse>>>> GetByShippingSettingId(Guid id);
    }
}
