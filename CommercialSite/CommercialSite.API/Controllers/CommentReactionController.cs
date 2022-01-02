using AutoMapper;
using CommercialSite.API.Controllers.Base;
using CommercialSite.Common.DTOs.CommentReaction;
using CommercialSite.Common.DTOs.User;
using CommercialSite.Common.Models;
using CommercialSite.Model.Entities;
using CommercialSite.Service.Repository.CommentReaction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommercialSite.API.Controllers
{
    [Route("commentReaction")]
    public class CommentReactionController : BaseApiController<CommentReactionController>
    {
        private readonly ICommentReactionRepository _commentReactionRepository;
        private readonly IMapper _mapper;
        public CommentReactionController(
            ICommentReactionRepository commentReactionRepository,
            IMapper mapper)
        {
            _commentReactionRepository = commentReactionRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<WebApiResponse<List<CommentReactionResponse>>>> GetCommentReactions()
        {
            UserResponse currentUser = WorkContext.CurrentUser;
            //using Microsoft.EntityFrameworkCore;
            var commentReactionResult = _mapper.Map<List<CommentReactionResponse>>(await _commentReactionRepository.TableNoTracking.ToListAsync());
            if (commentReactionResult.Count > 0)
                return new WebApiResponse<List<CommentReactionResponse>>(true, "Success", commentReactionResult);
            return new WebApiResponse<List<CommentReactionResponse>>(false, "Error");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebApiResponse<CommentReactionResponse>>> GetCommentReaction(Guid id)
        {
            var commentReactionResult = _mapper.Map<CommentReactionResponse>(await _commentReactionRepository.GetById(id));
            if (commentReactionResult != null)
                return new WebApiResponse<CommentReactionResponse>(true, "Success", commentReactionResult);
            return new WebApiResponse<CommentReactionResponse>(false, "Error");
        }

        [HttpPost]
        public async Task<ActionResult<WebApiResponse<CommentReactionResponse>>> PostCommentReaction(CommentReactionRequest request)
        {
            CommentReaction entity = _mapper.Map<CommentReaction>(request);
            var insertResult = await _commentReactionRepository.Add(entity);
            if (insertResult != null)
            {
                CommentReactionResponse rm = _mapper.Map<CommentReactionResponse>(entity);
                return new WebApiResponse<CommentReactionResponse>(true, "Success", rm);
            }
            return new WebApiResponse<CommentReactionResponse>(false, "Error");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WebApiResponse<CommentReactionResponse>>> PutCommentReaction(Guid id, CommentReactionRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            try
            {
                CommentReaction entity = await _commentReactionRepository.GetById(id);
                if (entity == null)
                    return NotFound();

                //Eğer request'ten gelen data varsa onu veritabanında günceller, yoksa veri tabanındakini tutar, null ile ezmez....
                _mapper.Map(request, entity);

                var updateResult = await _commentReactionRepository.Update(entity);
                if (updateResult != null)
                {
                    CommentReactionResponse rm = _mapper.Map<CommentReactionResponse>(updateResult);
                    return new WebApiResponse<CommentReactionResponse>(true, "Success", rm);
                }
                return new WebApiResponse<CommentReactionResponse>(false, "Error");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<WebApiResponse<CommentReactionResponse>>> DeleteCommentReaction(Guid id)
        {
            CommentReaction entity = await _commentReactionRepository.GetById(id);
            if (entity == null)
                return NotFound();
            else
            {
                if (await _commentReactionRepository.Remove(entity))
                {
                    CommentReactionResponse rm = _mapper.Map<CommentReactionResponse>(entity);
                    return new WebApiResponse<CommentReactionResponse>(true, "Success", rm);
                }
                return new WebApiResponse<CommentReactionResponse>(false, "Error");
            }
        }

        [HttpGet("activate/{id}")]
        public async Task<ActionResult<WebApiResponse<bool>>> Activate(Guid id)
        {
            bool result = await _commentReactionRepository.Activate(id);
            if (result)
                return new WebApiResponse<bool>(true, "Success", true);
            return new WebApiResponse<bool>(false, "Error");
        }

        [HttpGet("GetByCommentId/{id}")]
        public async Task<WebApiResponse<List<CommentReactionResponse>>> GetByCommentId(Guid id)
        {
            var postResult = _mapper.Map<List<CommentReactionResponse>>(await _commentReactionRepository.GetDefault(x => x.ProductCommentId == id).ToListAsync());
            if (postResult.Count > 0)
            {
                return new WebApiResponse<List<CommentReactionResponse>>(true, "Success", postResult);
            }
            return new WebApiResponse<List<CommentReactionResponse>>(false, "Error");
        }
    }
}
