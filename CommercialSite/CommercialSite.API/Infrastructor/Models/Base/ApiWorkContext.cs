using AutoMapper;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Service.WorkContext;
using CommercialSite.Service.Repository.User;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.IdentityModel.Tokens.Jwt;

namespace CommercialSite.API.Infrastructor.Models.Base
{
    public class ApiWorkContext : IWorkContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserRepository _ur;
        private readonly IMapper _mapper;

        public ApiWorkContext(
            IHttpContextAccessor httpContextAccessor,
            IUserRepository ur,
            IMapper mapper
            )
        {
            _httpContextAccessor = httpContextAccessor;
            _ur = ur;
            _mapper = mapper;
        }

        public UserResponse CurrentUser
        {
            get
            {
                //using Microsoft.AspNetCore.Authentication;
                //using Microsoft.AspNetCore.Authentication.JwtBearer;
                var authResult = _httpContextAccessor.HttpContext.AuthenticateAsync(JwtBearerDefaults.AuthenticationScheme).Result;
                if (!authResult.Succeeded)
                    return null;

                var email = authResult.Principal.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.Email).Value;
                //using System.IdentityModel.Tokens.Jwt;
                var userId = authResult.Principal.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti).Value;
                UserResponse user = _mapper.Map<UserResponse>(_ur.GetById(Guid.Parse(userId)).Result);
                return user;
            }
            set
            {
                CurrentUser = value;
            }
        }
    }
}
