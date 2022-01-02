using CommercialSite.Common.DTOs.ProductComment;
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
    public interface IProductCommentApi
    {
        [Get("/productComment")]
        Task<ApiResponse<WebApiResponse<List<ProductCommentResponse>>>> List();

        [Get("/productComment/{id}")]
        Task<ApiResponse<WebApiResponse<ProductCommentResponse>>> Get(Guid id);

        [Post("/productComment")]
        Task<ApiResponse<WebApiResponse<ProductCommentResponse>>> Post(ProductCommentRequest request);

        [Put("/productComment/{id}")]
        Task<ApiResponse<WebApiResponse<ProductCommentResponse>>> Put([FromQuery] Guid id, [FromBody] ProductCommentRequest request);

        [Delete("/productComment/{id}")]
        Task<ApiResponse<WebApiResponse<ProductCommentResponse>>> Delete(Guid id);

        [Get("/productComment/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/productComment/getactive")]
        Task<ApiResponse<WebApiResponse<List<ProductCommentResponse>>>> GetActive();

        [Get("/post/GetByProductId/{id}")]
        Task<ApiResponse<WebApiResponse<List<ProductCommentResponse>>>> GetByProductId(Guid id);
    }
}
