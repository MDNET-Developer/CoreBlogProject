using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            return _messageDal.GetByID(id);
        }

        public List<Message> GetListMessageByWriter(string p)
        {
           return _messageDal.GetListAll(x=>x.Sender==p).Where(x => x.MessageStatus == true).ToList();
        }

        public List<Message> GetListInboxMessage(string p)
        {
            return _messageDal.GetListAll(x => x.Receiver == p).Where(x=>x.MessageStatus==true).ToList();
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetListAll();
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }

        public List<Message> GetListDeletedMessage(string p)
        {
          return  _messageDal.GetListAll(x => x.Receiver == p).Where(x => x.MessageStatus == false).ToList();
        }
    }
}
