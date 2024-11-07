﻿using MyBlogNight.DataAccesLayer.Abstract;
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
    public class EfArticleDal : GenericRepositories<Article>, IArticleDal
    {
        public EfArticleDal(BlogContext context) : base(context)
        {
        }
    }
}