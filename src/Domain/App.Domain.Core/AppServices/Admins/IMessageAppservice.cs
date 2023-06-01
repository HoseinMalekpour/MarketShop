using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Admins
{
    public interface IMessageAppservice
    {
        Task<MessageDto> GetItem(int ItemId, CancellationToken cancellationToken);

        Task<List<MessageDto>> GetAllMessage(string userId, CancellationToken cancellationToken);
        Task<List<MessageDto>> GetAllUnreadMessage(string userId, CancellationToken cancellationToken);
        Task Create(string title, string text, CancellationToken cancellationToken);
        Task MessageRead(int messageId, CancellationToken cancellationToken);
        Task Update(MessageDto message, CancellationToken cancellationToken);
        Task Deactivate(int messageId, CancellationToken cancellationToken);
        Task Active(int messageId, CancellationToken cancellationToken);
    }
}
