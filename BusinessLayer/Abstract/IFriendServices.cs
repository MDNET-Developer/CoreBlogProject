using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    internal interface IFriendServices:IGenericService<Friend>
    {
        List<Friend> GetFriendList(string p);
        List<Friend> GetSuggestFriendList(string p);
    }
}
