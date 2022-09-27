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
    public class FriendManager : IFriendServices
    {
        IFriendDal _friendDal;

        public FriendManager(IFriendDal friendDal)
        {
            _friendDal = friendDal;
        }

        public Friend GetByID(int id)
        {
            return _friendDal.GetByID(id);
        }

        public List<Friend> GetFriendList(string p)
        {
            return _friendDal.GetListAll().Where(x => x.Veziyyet == true && ( x.Gonderen==p ||x.Alan==p)).ToList();
        }

        public List<Friend> GetSuggestFriendList(string p)
        {
            return _friendDal.GetListAll().Where(x => x.Alan == p && x.Veziyyet==false).ToList();
        }

        public void TAdd(Friend t)
        {
            _friendDal. Insert(t);
        }

        public void TDelete(Friend t)
        {
            _friendDal.Delete(t);
        }

        public List<Friend> TGetList()
        {
           return _friendDal.GetListAll();
        }

        public void TUpdate(Friend t)
        {
            _friendDal.Update(t);
        }
    }
}
