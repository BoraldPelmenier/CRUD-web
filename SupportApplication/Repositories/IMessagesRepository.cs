using SupportApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportApplication.Repositories
{
    public interface IMessagesRepository
    {
        public List<Messages> GetMessages();
        public void AddMessages(Messages messages);
        public void DeleteMessages(int id);
        public Messages GetMessage(int id);
        public void UpdateMessage(Messages message);
        
    }
}
