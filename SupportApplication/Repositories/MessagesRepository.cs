using Microsoft.Extensions.Configuration;
using SupportApplication.Data.AppDbContexts;
using SupportApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportApplication.Repositories
{
    public class MessagesRepository : IMessagesRepository
    {
        private readonly IConfiguration _configuration;
        private readonly MessagesContext _messagesContext;

        public MessagesRepository(IConfiguration configuration, MessagesContext messagesContext)
        {
            _configuration = configuration;
            _messagesContext = messagesContext;
        }

        public List<Messages> GetMessages()
        {
            var messages = _messagesContext.Messages.ToList();
            return messages;
        }

        public void AddMessages(Messages messages)
        {
            _messagesContext.Messages.Add(messages);
            _messagesContext.SaveChanges();
        }

        public void DeleteMessages(int id)
        {
            var message = _messagesContext.Messages.FirstOrDefault(m => m.Id == id);
            _messagesContext.Messages.Remove(message);
            _messagesContext.SaveChanges();
        }

        public Messages GetMessage(int id)
        {
            return _messagesContext.Messages.FirstOrDefault(m => m.Id == id);            
        }

        public void UpdateMessage(Messages message)
        {
            _messagesContext.Messages.Update(message);
            _messagesContext.SaveChanges();
        }
    }
}
