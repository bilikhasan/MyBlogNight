using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.DataAccesLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;
        public void TDelete(int id)
        {
            _articleDal.Delete(id);
        }

        public Article TGetById(int id)
        {
           return _articleDal.GetById(id);
        }

        public void TInsert(Article entity)
        {
            _articleDal.Insert(entity);
        }

        public List<Article> TtGetAll()
        {
            return _articleDal.GetAll();
        }

        public void TUpdate(Article entity)
        {
            _articleDal.Update(entity);
        }
    }
}
