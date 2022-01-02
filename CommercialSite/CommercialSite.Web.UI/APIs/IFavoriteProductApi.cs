using CommercialSite.Common.DTOs.FavoriteProduct;
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
    public interface IFavoriteProductApi
    {
        [Get("/favoriteProduct")]
        Task<ApiResponse<WebApiResponse<List<FavoriteProductResponse>>>> List();

        [Get("/favoriteProduct/{id}")]
        Task<ApiResponse<WebApiResponse<FavoriteProductResponse>>> Get(Guid id);

        [Post("/favoriteProduct")]
        Task<ApiResponse<WebApiResponse<FavoriteProductResponse>>> Post(FavoriteProductRequest request);

        [Put("/favoriteProduct/{id}")]
        Task<ApiResponse<WebApiResponse<FavoriteProductResponse>>> Put([FromQuery] Guid id, [FromBody] FavoriteProductRequest request);

        [Delete("/favoriteProduct/{id}")]
        Task<ApiResponse<WebApiResponse<FavoriteProductResponse>>> Delete(Guid id);

        [Get("/favoriteProduct/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/favoriteProduct/getactive")]
        Task<ApiResponse<WebApiResponse<List<FavoriteProductResponse>>>> GetActive();

        [Get("/post/GetByUserId/{id}")]
        Task<ApiResponse<WebApiResponse<List<FavoriteProductResponse>>>> GetByUserId(Guid id);

        [Get("/post/GetByProductId/{id}")]
        Task<ApiResponse<WebApiResponse<List<FavoriteProductResponse>>>> GetByProductId(Guid id);
    }
}
