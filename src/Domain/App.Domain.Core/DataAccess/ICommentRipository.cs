using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DataAccess
{
    public interface ICommentRipository
    {
        Task Active(int commentId, CancellationToken cancellationToken);
        Task DiActive(int commentId, CancellationToken cancellationToken);
        Task<List<CommentDto>> GetAll(CancellationToken cancellationToken);
        Task<List<CommentDto>> GetAllUser(string userId, CancellationToken cancellationToken);
        Task<List<CommentDto>> GetAllOrder(int orderId, CancellationToken cancellationToken);
        Task<List<CommentDto>> GetAllBooth(int boothId, CancellationToken cancellationToken);
        Task<CommentDto> GetDatail(int commentId, CancellationToken cancellationToken);
        Task Create(CommentDto comment, CancellationToken cancellationToken);
        Task Update(CommentDto comment, CancellationToken cancellationToken);
        Task SoftDelete(int commentId, CancellationToken cancellationToken);
        Task HardDelted(int commentId, CancellationToken cancellationToken);
    }
}
