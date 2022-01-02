using CommercialSite.Common.DTOs.UserDetail;
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
    public interface IUserDetailApi
    {
        [Get("/userDetail")]
        Task<ApiResponse<WebApiResponse<List<UserDetailResponse>>>> List();

        [Get("/userDetail/{id}")]
        Task<ApiResponse<WebApiResponse<UserDetailResponse>>> Get(Guid id);

        [Post("/userDetail")]
        Task<ApiResponse<WebApiResponse<UserDetailResponse>>> Post(UserDetailRequest request);

        [Put("/userDetail/{id}")]
        Task<ApiResponse<WebApiResponse<UserDetailResponse>>> Put([FromQuery] Guid id, [FromBody] UserDetailRequest request);

        [Delete("/userDetail/{id}")]
        Task<ApiResponse<WebApiResponse<UserDetailResponse>>> Delete(Guid id);

        [Get("/userDetail/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/userDetail/getactive")]
        Task<ApiResponse<WebApiResponse<List<UserDetailResponse>>>> GetActive();

        [Get("/post/GetByUserDetailId/{id}")]
        Task<ApiResponse<WebApiResponse<List<UserDetailResponse>>>> GetByUserDetailId(Guid id);

    }
}
