using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.Category;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("category")]
    public class CategoryController : BaseApiController<CategoryController>
    {
        private readonly ICategoryRepository _cr;
        private readonly IMapper _mapper;
        public CategoryController(
            ICategoryRepository cr,
            IMapper mapper
            )
        {
            _cr = cr;
            _mapper = mapper;
        }

        [HttpGet, AllowAnonymous]
        public async Task<ActionResult<WebApiResponse<List<CategoryResponse>>>> GetCategories()
        {
            UserResponse currentUser = WorkContext.CurrentUser;
            //using Microsoft.EntityFrameworkCore;
            var categoryResult = _mapper.Map<List<CategoryResponse>>(await _cr.TableNoTracking.ToListAsync());
            if (categoryResult.Count > 0)
            {
                return new WebApiResponse<List<CategoryResponse>>(true, "Success", categoryResult);
            }
            return new WebApiResponse<List<CategoryResponse>>(false, "Error");
        }

        //http://localhost:5000/category/0ac17b49-98fb-41ea-949f-35c676ea0725
        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<CategoryResponse>>> GetCategory(Guid id)
        {
            var categoryResult = _mapper.Map<CategoryResponse>(await _cr.GetById(id));
            if (categoryResult != null)
            {
                return new WebApiResponse<CategoryResponse>(true, "Success", categoryResult);
            }
            return new WebApiResponse<CategoryResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<CategoryResponse>>> PostCategory(CategoryRequest request)
        {
            Category entity = _mapper.Map<Category>(request);
            var insertResult = await _cr.Add(entity);
            if (insertResult != null)
            {
                CategoryResponse rm = _mapper.Map<CategoryResponse>(insertResult);
                return new WebApiResponse<CategoryResponse>(true, "Success", rm);
            }
            return new WebApiResponse<CategoryResponse>(false, "Error");
        }

        //http://localhost:5000/category/0ac17b49-98fb-41ea-949f-35c676ea0725
        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<CategoryResponse>>> PutCategory(Guid id, CategoryRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                Category entity = await _cr.GetById(id);
                if (entity == null)
                    return NotFound();
                //Eğer request'ten gelen data varsa onu veritabanında günceller, request'ten gelen data yoksa veritabanındakini tutar.
                _mapper.Map(request, entity);

                var updateResult = await _cr.Update(entity);
                if (updateResult != null)
                {
                    CategoryResponse rm = _mapper.Map<CategoryResponse>(updateResult);
                    return new WebApiResponse<CategoryResponse>(true, "Success", rm);
                }
                return new WebApiResponse<CategoryResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<CategoryResponse>>> DeleteCategory(Guid id)
        {
            var category = await _cr.GetById(id);
            if (category != null)
            {
                if (await _cr.Remove(category))
                    return new WebApiResponse<CategoryResponse>(true, "Success", _mapper.Map<CategoryResponse>(category));
                else
                    return new WebApiResponse<CategoryResponse>(false, "Error");
            }
            return new WebApiResponse<CategoryResponse>(false, "Error");
        }

        [HttpGet("activate/{id}")]
        public async Task<ActionResult<WebApiResponse<bool>>> Activate(Guid id)
        {
            bool result = await _cr.Activate(id);
            if (result)
            {
                return new WebApiResponse<bool>(true, "Success", true);
            }
            return new WebApiResponse<bool>(false, "Error");
        }

        [HttpGet("getactive"), AllowAnonymous]
        public async Task<ActionResult<WebApiResponse<List<CategoryResponse>>>> GetActive()
        {
            var categoryResult = _mapper.Map<List<CategoryResponse>>(await _cr.GetActive().ToListAsync());
            if (categoryResult.Count > 0)
            {
                return new WebApiResponse<List<CategoryResponse>>(true, "Success", categoryResult);
            }
            return new WebApiResponse<List<CategoryResponse>>(false, "Error");
        }
    }
}
