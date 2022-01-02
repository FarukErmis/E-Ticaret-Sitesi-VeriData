using AutoMapper;
using CommercialSite.Common.DTOs.Login;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Extensions;
using CommercialSite.Common.Models;
using CommercialSite.Service.Repository.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AccountController(
            IUserRepository userRepository,
            IMapper mapper,
            IConfiguration configuration)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet("login")]
        //http://localhost:5000/account/login?Email=admin@admin.com&Password=123
        public async Task<WebApiResponse<UserResponse>> Login([FromQuery] LoginRequest request)
        {
            if (ModelState.IsValid)
            {
                var result = _userRepository.TableNoTracking.Where(x=>x.Email == request.Email).FirstOrDefault();
                if (result != null)
                {
                    if (result.Email == request.Email && result.Password == request.Password)
                    {
                        UserResponse rm = _mapper.Map<UserResponse>(result);
                        rm.AccessToken = SetAccessToken(rm);
                        return new WebApiResponse<UserResponse>(true, "Success", rm);
                    }
                }
                //if (result != null)
                //{
                //    UserResponse rm = _mapper.Map<UserResponse>(result);
                //    rm.AccessToken = SetAccessToken(rm);
                //    return new WebApiResponse<UserResponse>(true, "Success", rm);
                //}
            }
            return new WebApiResponse<UserResponse>(false, ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList().ToString());
        }

        private GetAccessToken SetAccessToken(UserResponse rm)
        {
            var claims = new List<Claim>
            {
                //using System.IdentityModel.Tokens.Jwt;
                new Claim(JwtRegisteredClaimNames.Email,rm.Email),
                new Claim(JwtRegisteredClaimNames.Jti,rm.Id.ToString())
            };

            //JWT
            var systemSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
            var signingCredentials = new SigningCredentials(systemSecurityKey, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddMinutes(Convert.ToDouble(_configuration["Tokens:Expires"]));
            var ticks = expires.ToUnixTime();

            var jwtSecurityToken = new JwtSecurityToken(
                    issuer: _configuration["Tokens:Issuer"],//yayınlayan
                    audience: _configuration["Tokens:Audience"], //izleyen
                    claims: claims,
                    expires: expires,
                    signingCredentials: signingCredentials
                );

            return new GetAccessToken
            {
                TokenType = "BilgeAdamAccessToken",
                AccessToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                Expires = ticks,
                RefreshToken = $"{rm.Email}_{rm.Password}_{ticks}".Encrypt()
            };
        }

        [HttpGet("refreshtoken")]
        //http://localhost:5000/account/refreshtoken?user_name=admin@admin.com&refresh_token=YWRtaW5AYWRtaW4uY29tXzEyM18xNjEyMDA3OTM3
        public async Task<WebApiResponse<GetAccessToken>> RefreshToken([FromQuery] RefreshToken request)
        {
            if (string.IsNullOrEmpty(request.Refresh_Token))
                throw new Exception("Invalid Refresh Token");

            var key = request.Refresh_Token.Decrypt();
            var userInfo = key.Split('_');

            if (userInfo.Length < 3 || userInfo[0] != request.User_Name)
                throw new Exception("Geçersiz Token");

            var result = await _userRepository.GetByDefault(x => x.Email == userInfo[0] && x.Password == userInfo[1]);
            if (result != null)
            {
                UserResponse rm = _mapper.Map<UserResponse>(result);
                rm.AccessToken = SetAccessToken(rm);
                return new WebApiResponse<GetAccessToken>(true, "Success", rm.AccessToken);
            }
            return new WebApiResponse<GetAccessToken>(false, "User Not Found");
        }
    }
}
