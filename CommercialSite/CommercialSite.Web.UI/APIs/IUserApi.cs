using CommercialSite.Common.DTOs.User;
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
    public interface IUserApi
    {
        [Get("/user")]
        Task<ApiResponse<WebApiResponse<List<UserResponse>>>> List();

        [Get("/user/{id}")]
        Task<ApiResponse<WebApiResponse<UserResponse>>> Get(Guid id);

        [Post("/user")]
        Task<ApiResponse<WebApiResponse<UserResponse>>> Post(UserRequest request);

        [Put("/user/{id}")]
        Task<ApiResponse<WebApiResponse<UserResponse>>> Put([FromQuery] Guid id, [FromBody] UserRequest request);

        [Delete("/user/{id}")]
        Task<ApiResponse<WebApiResponse<UserResponse>>> Delete(Guid id);

        [Get("/user/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/user/getactive")]
        Task<ApiResponse<WebApiResponse<List<UserResponse>>>> GetActive();

    }
}
