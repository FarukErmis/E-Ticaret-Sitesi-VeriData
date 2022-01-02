using CommercialSite.Common.DTOs.CommentReaction;
using CommercialSite.Common.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.APIs
{
    [Headers("Authorization: Bearer", "Content-Type: application/json")]
    public interface ICommentReactionApi
    {
        [Get("/commentReaction")]
        Task<ApiResponse<WebApiResponse<List<CommentReactionResponse>>>> List();

        [Get("/commentReaction/{id}")]
        Task<ApiResponse<WebApiResponse<CommentReactionResponse>>> Get(Guid id);

        [Post("/commentReaction")]
        Task<ApiResponse<WebApiResponse<CommentReactionResponse>>> Post(CommentReactionRequest request);

        [Put("/commentReaction/{id}")]
        Task<ApiResponse<WebApiResponse<CommentReactionResponse>>> Put([FromQuery] Guid id, [FromBody] CommentReactionRequest request);

        [Delete("/commentReaction/{id}")]
        Task<ApiResponse<WebApiResponse<CommentReactionResponse>>> Delete(Guid id);

        [Get("/commentReaction/activate/{id}")]
        Task<ApiResponse<WebApiResponse<bool>>> Activate(Guid id);

        [Get("/commentReaction/getactive")]
        Task<ApiResponse<WebApiResponse<List<CommentReactionResponse>>>> GetActive();

        [Get("/post/GetByProductCommentId/{id}")]
        Task<ApiResponse<WebApiResponse<List<CommentReactionResponse>>>> GetByProductCommentId(Guid id);
    }
}
