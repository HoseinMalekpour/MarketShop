using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.AppServices.Admins;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;

namespace App.Domain.AppService.Admins
{
    public class CommentAppservice : ICommentAppservice
    {
        private readonly ICommentRipository _commentRipository;
    public CommentAppservice(ICommentRipository commentRipository)
        {
            _commentRipository = commentRipository;
        }

        public async Task Active(int commentId, CancellationToken cancellationToken)
        {
           await _commentRipository.Active(commentId, cancellationToken);    
        }

        public async Task Create(CommentDto comment, CancellationToken cancellationToken)
        {
            await _commentRipository.Create(comment, cancellationToken);
        }

        public async Task DiActive(int commentId, CancellationToken cancellationToken)
        {
            await _commentRipository.DiActive(commentId, cancellationToken);    
        }
       public async Task<List<CommentDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _commentRipository.GetAll(cancellationToken);
        }
        public async Task<List<CommentDto>> GetAllBooth(int boothId, CancellationToken cancellationToken)
        {
            return await _commentRipository.GetAllBooth(boothId, cancellationToken);
        }

        public Task<List<CommentDto>> GetAllOrder(int orderId, CancellationToken cancellationToken)
        {
           return _commentRipository.GetAllOrder(orderId, cancellationToken);
        }

        public async Task<List<CommentDto>> GetAllUser(string userId, CancellationToken cancellationToken)
        {
           return await _commentRipository.GetAllUser(userId, cancellationToken);
        }

        public async Task<CommentDto> GetDatail(int commentId, CancellationToken cancellationToken)
        {
           return await _commentRipository.GetDatail(commentId, cancellationToken);
        }

        public async Task HardDelted(int commentId, CancellationToken cancellationToken)
        {
            await _commentRipository.HardDelted(commentId, cancellationToken);
        }

        public async Task SoftDelete(int commentId, CancellationToken cancellationToken)
        {
            await _commentRipository.SoftDelete(commentId, cancellationToken);
        }

        public async Task Update(CommentDto comment, CancellationToken cancellationToken)
        {
            await _commentRipository.Update(comment, cancellationToken);
        }
    }
}
