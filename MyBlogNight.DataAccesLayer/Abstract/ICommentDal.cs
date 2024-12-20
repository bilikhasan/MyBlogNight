﻿using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccesLayer.Abstract
{
    public interface ICommentDal :IGenericDal<Comment>      //IGenericDal'dan Comment sınıfı için miras alıyoruz
    {
        List<Comment> GetCommentsByArticleId(int id);
    }
}
