using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.AppServices.Admins;
using App.Domain.Core.DtoModels;

namespace App.Domain.AppService.Admins
{
    public class MessageAppservice : IMessageAppservice
    {
        public Task Active(int messageId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Create(string title, string text, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Deactivate(int messageId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<MessageDto>> GetAllMessage(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<MessageDto>> GetAllUnreadMessage(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<MessageDto> GetItem(int ItemId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task MessageRead(int messageId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Update(MessageDto message, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
