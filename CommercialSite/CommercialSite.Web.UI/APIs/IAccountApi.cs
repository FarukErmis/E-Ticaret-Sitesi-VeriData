using CommercialSite.Common.DTOs.Login;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Models;
using Refit;
using System.Threading.Tasks;

namespace CommercialSite.Web.UI.APIs
{
    [Headers("Content-Type: application/json")]
    public interface IAccountApi
    {
        [Get("/account/login")]
        Task<ApiResponse<WebApiResponse<UserResponse>>> Login(LoginRequest request);

        [Get("/account/refreshtoken")]
        Task<ApiResponse<WebApiResponse<GetAccessToken>>> RefreshToken(RefreshToken request);
    }
}
