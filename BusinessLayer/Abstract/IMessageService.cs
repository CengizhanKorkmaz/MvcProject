using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> getListInbox(string mail);
        List<Message> getListSendBox(string mail);
        Message getById(int id);
        void add(Message message);
        void update(Message message);
        void delete(Message message);
    }
}
