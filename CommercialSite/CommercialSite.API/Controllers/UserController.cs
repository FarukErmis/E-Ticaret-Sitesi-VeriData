using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BilgeAdamBlog.API.Controllers
{
    [Route("user")]
    public class UserController : BaseApiController<UserController>
    {
        private readonly IUserRepository _ur;
        private readonly IMapper _mapper;
        public UserController(
            IUserRepository ur,
            IMapper mapper)
        {
            _ur = ur;
            _mapper = mapper;
        }

        [HttpGet, AllowAnonymous]
        public async Task<ActionResult<WebApiResponse<List<UserResponse>>>> GetUsers()
        {
            //using Microsoft.EntityFrameworkCore;
            var userResult = _mapper.Map<List<UserResponse>>(await _ur.TableNoTracking.ToListAsync());
            if (userResult.Count > 0)
            {
                return new WebApiResponse<List<UserResponse>>(true, "Success", userResult);
            }
            return new WebApiResponse<List<UserResponse>>(false, "Error");
        }

        [HttpGet("{id}"), AllowAnonymous]
        public async Task<ActionResult<WebApiResponse<UserResponse>>> GetUser(Guid id)
        {
            var result = await _ur
                                            .Table
                                            .Include(x=>x.UpdatedUserShippingAddresses)
                                            .Include(x=>x.BillingAddresses)
                                            .ToListAsync();

            var productResult = _mapper.Map<UserResponse>(result);

            var userResult = _mapper.Map<UserResponse>(await _ur.GetById(id));
            if (userResult != null)
            {
                return new WebApiResponse<UserResponse>(true, "Success", productResult);
            }
            return new WebApiResponse<UserResponse>(false, "Error");
        }

        [HttpPost, AllowAnonymous]
        public async Task<ActionResult<WebApiResponse<UserResponse>>> PostUser(UserRequest request)
        {
            User entity = _mapper.Map<User>(request);
            var insertResult = await _ur.Add(entity);
            if (insertResult != null)
            {
                UserResponse rm = _mapper.Map<UserResponse>(insertResult);
                return new WebApiResponse<UserResponse>(true, "Success", rm);
            }
            return new WebApiResponse<UserResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<UserResponse>>> PutUser(Guid id, UserRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                User entity = await _ur.GetById(id);
                if (entity == null)
                    return NotFound();
                //Eğer request'ten gelen data varsa onu veritabanında günceller, request'ten gelen data yoksa veritabanındakini tutar.
                _mapper.Map(request, entity);

                var updateResult = await _ur.Update(entity);
                if (updateResult != null)
                {
                    UserResponse rm = _mapper.Map<UserResponse>(updateResult);
                    return new WebApiResponse<UserResponse>(true, "Success", rm);
                }
                return new WebApiResponse<UserResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<UserResponse>>> DeleteUser(Guid id)
        {
            var user = await _ur.GetById(id);
            if (user != null)
            {
                if (await _ur.Remove(user))
                    return new WebApiResponse<UserResponse>(true, "Success", _mapper.Map<UserResponse>(user));
                else
                    return new WebApiResponse<UserResponse>(false, "Error");
            }
            return new WebApiResponse<UserResponse>(false, "Error");
        }

        [HttpGet("activate/{id}")]
        public async Task<ActionResult<WebApiResponse<bool>>> Activate(Guid id)
        {
            bool result = await _ur.Activate(id);
            if (result)
            {
                return new WebApiResponse<bool>(true, "Success", true);
            }
            return new WebApiResponse<bool>(false, "Error");
        }

        [HttpGet("getactive")]
        public async Task<ActionResult<WebApiResponse<List<UserResponse>>>> GetActive()
        {
            var commentResult = _mapper.Map<List<UserResponse>>(await _ur.GetActive().ToListAsync());
            if (commentResult.Count > 0)
            {
                return new WebApiResponse<List<UserResponse>>(true, "Success", commentResult);
            }
            return new WebApiResponse<List<UserResponse>>(false, "Error");
        }
    }
}
