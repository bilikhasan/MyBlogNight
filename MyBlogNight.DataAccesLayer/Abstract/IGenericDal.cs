﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccesLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {                                                           //Hepsi elle yazıldı.
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);

    }
}
