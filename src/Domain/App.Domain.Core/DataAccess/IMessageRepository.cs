using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DataAccess
{
    public interface IMessageRepository
    {
        Task<List<MessageDto>> GetAll(string userId, CancellationToken cancellationToken);
        Task<MessageDto> GetDatail(int messageId, CancellationToken cancellationToken);
        Task Create(string userId, string text,string title, CancellationToken cancellationToken);
        Task Update(MessageDto message, CancellationToken cancellationToken);
        Task SoftDelete(int messageId, CancellationToken cancellationToken);
        Task HardDelted(int messageId, CancellationToken cancellationToken);
    }
}
