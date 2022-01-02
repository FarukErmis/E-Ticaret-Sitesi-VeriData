using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.UserDetail;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.UserDetail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("userDetail")]
    public class UserDetailController : BaseApiController<UserDetailController>
    {
        private readonly IUserDetailRepository _userDetailRepository;
        private readonly IMapper _mapper;
        public UserDetailController(
            IUserDetailRepository userDetailRepository,
            IMapper mapper)
        {
            _userDetailRepository = userDetailRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<UserDetailResponse>>>> GetUserDetails()
        {
            UserResponse currentUser = WorkContext.CurrentUser;
            //using Microsoft.EntityFrameworkCore;
            var userDetailResult = _mapper.Map<List<UserDetailResponse>>(await _userDetailRepository.TableNoTracking.ToListAsync());
            if (userDetailResult.Count > 0)
                return new WebApiResponse<List<UserDetailResponse>>(true, "Success", userDetailResult);
            return new WebApiResponse<List<UserDetailResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<UserDetailResponse>>> GetUserDetail(Guid id)
        {
            var userDetailResult = _mapper.Map<UserDetailResponse>(await _userDetailRepository.GetById(id));
            if (userDetailResult != null)
                return new WebApiResponse<UserDetailResponse>(true, "Success", userDetailResult);
            return new WebApiResponse<UserDetailResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<UserDetailResponse>>> PostPUserDetail(UserDetailRequest request)
        {
            UserDetail entity = _mapper.Map<UserDetail>(request);
            var insertResult = await _userDetailRepository.Add(entity);
            if (insertResult != null)
            {
                UserDetailResponse rm = _mapper.Map<UserDetailResponse>(entity);
                return new WebApiResponse<UserDetailResponse>(true, "Success", rm);
            }
            return new WebApiResponse<UserDetailResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<UserDetailResponse>>> PutUserDetail(Guid id, UserDetailRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                UserDetail entity = await _userDetailRepository.GetById(id);
                if (entity == null)
                    return NotFound();

                //Eğer request'ten gelen data varsa onu veritabanında günceller, yoksa veri tabanındakini tutar, null ile ezmez....
                _mapper.Map(request, entity);

                var updateResult = await _userDetailRepository.Update(entity);
                if (updateResult != null)
                {
                    UserDetailResponse rm = _mapper.Map<UserDetailResponse>(updateResult);
                    return new WebApiResponse<UserDetailResponse>(true, "Success", rm);
                }
                return new WebApiResponse<UserDetailResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<UserDetailResponse>>> DeleteUserDetail(Guid id)
        {
            UserDetail entity = await _userDetailRepository.GetById(id);
            if (entity == null)
                return NotFound();
            else
            {
                if (await _userDetailRepository.Remove(entity))
                {
                    UserDetailResponse rm = _mapper.Map<UserDetailResponse>(entity);
                    return new WebApiResponse<UserDetailResponse>(true, "Success", rm);
                }
                return new WebApiResponse<UserDetailResponse>(false, "Error");
            }
        }

        [HttpGet("activate/{id}")]
        public async Task<ActionResult<WebApiResponse<bool>>> Activate(Guid id)
        {
            bool result = await _userDetailRepository.Activate(id);
            if (result)
                return new WebApiResponse<bool>(true, "Success", true);
            return new WebApiResponse<bool>(false, "Error");
        }

        [HttpGet("getactive")]
        public async Task<ActionResult<WebApiResponse<List<UserDetailResponse>>>> GetActive()
        {
            var userDetailResult = _mapper.Map<List<UserDetailResponse>>(await _userDetailRepository.GetActive().ToListAsync());
            if (userDetailResult.Count > 0)
                return new WebApiResponse<List<UserDetailResponse>>(true, "Success", userDetailResult);
            return new WebApiResponse<List<UserDetailResponse>>(false, "Error");
        }

        [HttpGet("GetByUserId/{id}")]
        public async Task<WebApiResponse<List<UserDetailResponse>>> GetByUserId(Guid id)
        {
            var userDetailResult = _mapper.Map<List<UserDetailResponse>>(await _userDetailRepository.GetDefault(x => x.UserId == id).ToListAsync());
            if (userDetailResult.Count > 0)
            {
                return new WebApiResponse<List<UserDetailResponse>>(true, "Success", userDetailResult);
            }
            return new WebApiResponse<List<UserDetailResponse>>(false, "Error");
        }
    }
}
