using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Infrastructures.Db.SqlServer.Ef.Database;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace App.Infrastructures.Data.Repositories.DataAccess.Repositories
{
    public class CommentRipository:ICommentRipository
    {
        private readonly IMapper _mapper;
        private readonly MarketDbContext _context;

        public CommentRipository(IMapper mapper, MarketDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task Active(int commentId, CancellationToken cancellationToken)
        {
            var order = await _context.Comments
            .Where(x => x.Id == commentId)
            .FirstOrDefaultAsync();
            order.IsAccepted = true;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Create(CommentDto comment, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Comment>(comment);
            record.CreatedAt = DateTime.Now;
            record.IsAccepted = false;
            try
            {
                await _context.Comments.AddAsync(record);
                await _context.SaveChangesAsync(cancellationToken);

            }
            catch (Exception ex)
            {
                //_loger.LogError("Error in add new Order {exception}", ex);
            }
        }

        public async Task DiActive(int commentId, CancellationToken cancellationToken)
        {
            var order = await _context.Comments
             .Where(x => x.Id == commentId)
             .FirstOrDefaultAsync();
            order.IsAccepted = false;
            await _context.SaveChangesAsync(cancellationToken);
        }
       public async Task<List<CommentDto>> GetAll(CancellationToken cancellationToken)
        => _mapper.Map<List<CommentDto>>(await _context.Comments.
            ToListAsync(cancellationToken));

        public async Task<List<CommentDto>> GetAllBooth(int boothId, CancellationToken cancellationToken)
        => _mapper.Map<List<CommentDto>>(await _context.Comments.
            Where(x=>x.BoothId == boothId)
            .ToListAsync(cancellationToken));

        public async Task<List<CommentDto>> GetAllOrder(int orderId, CancellationToken cancellationToken)
         => _mapper.Map<List<CommentDto>>(await _context.Comments.
            Where(x => x.OrderId == orderId)
            .ToListAsync(cancellationToken));

        public async Task<List<CommentDto>> GetAllUser(string userId, CancellationToken cancellationToken)
        {
            return null;
        }   //=> _mapper.Map<List<CommentDto>>(_context.Comments
            //    .AsNoTracking()
            //     .Where(x => x.UserId == userId)
            //     .ToListAsync(cancellationToken));


        public async Task<CommentDto> GetDatail(int commentId, CancellationToken cancellationToken)
            => await Task.FromResult(_mapper.Map<CommentDto>(await _context.Comments
             .AsNoTracking()
             .Where(x => x.Id == commentId)
              .FirstOrDefaultAsync(cancellationToken)));


        public async Task HardDelted(int commentId, CancellationToken cancellationToken)
        {
            var comment = await _context.Comments
               .Where(x => x.Id == commentId)
               .FirstOrDefaultAsync(cancellationToken);
            _context.Remove(comment);
            try
            {
                await _context.SaveChangesAsync(cancellationToken);

            }
            catch (Exception ex)
            {
                //_loger.LogError("Error in HardDelete order {exception}", ex);
            }
        }

        public async Task SoftDelete(int commentId, CancellationToken cancellationToken)
        {
            var comment = await _context.Comments
             .Where(x => x.Id == commentId)
             .FirstOrDefaultAsync();
            comment.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Update(CommentDto comment, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<CommentDto>(_context.Set<CommentDto>())
                  .Where(x => x.Id == comment.Id).FirstOrDefaultAsync();
            _mapper.Map(comment, record);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
