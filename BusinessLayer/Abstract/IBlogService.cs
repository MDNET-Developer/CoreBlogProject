using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        List<Blog> GetListWithCategory();
        List<Blog> GetLast5Blogs(int id);
        List<Blog> GetLast3BlogsFooter();
        List<Blog> GetBlogListByWriter(int id);
        List<Blog> GetListWithCategoryByWriter(int id);
        List<Blog> GetBlogbyFriend(int id);


    }
}
