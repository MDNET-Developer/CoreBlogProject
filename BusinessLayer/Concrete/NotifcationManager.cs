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
    public class NotifcationManager : NotifcationService
    {
        INotifcationDal _notifcationDal;

        public NotifcationManager(INotifcationDal notifcationDal)
        {
            _notifcationDal = notifcationDal;
        }

        public Notifcation GetByID(int id)
        {
            return _notifcationDal.GetByID(id);
        }

        public void TAdd(Notifcation t)
        {
           _notifcationDal.Insert(t);
        }

        public void TDelete(Notifcation t)
        {
            _notifcationDal.Delete(t);
        }

        public List<Notifcation> TGetList()
        {
            return _notifcationDal.GetListAll();
        }

        public void TUpdate(Notifcation t)
        {
             _notifcationDal.Update(t);
        }
    }
}
