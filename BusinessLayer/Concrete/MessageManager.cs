using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class MessageManager:IMessageService
    {
        private IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public List<Message> getListInbox(string mail)
        {
            return _messageDal.List(x=>x.ReceiverMail==mail);
        }
        public List<Message> getListSendBox(string mail)
        {
            return _messageDal.List(x => x.SenderMail == mail);
        }

        public Message getById(int id)
        {
            return _messageDal.Get(x=>x.MessageId==id);
        }

        public void add(Message message)
        {
            _messageDal.Add(message);
        }

        public void update(Message message)
        {
            _messageDal.Update(message);
        }

        public void delete(Message message)
        {
            _messageDal.Delete(message);
        }
    }
}
