using Microsoft.EntityFrameworkCore;
using MyBlogNight.DataAccesLayer.Abstract;
using MyBlogNight.DataAccesLayer.Context;
using MyBlogNight.DataAccesLayer.Repositories;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccesLayer.EntityFramework
{
    public class EfCommentDal : GenericRepositories<Comment>, ICommentDal
    {
        public EfCommentDal(BlogContext context) : base(context)
        {
        }

        public List<Comment> GetCommentsByArticleId(int id)
        {
            var context = new BlogContext();
            var values = context.Comments.Where(x => x.ArticleId == id).Include(y => y.AppUser).ToList();
            return values;
        }
    }
}
