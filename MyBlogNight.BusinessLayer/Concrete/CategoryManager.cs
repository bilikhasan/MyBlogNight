﻿using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.DataAccesLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TInsert(Category entity)
        {
            if(entity.CategoryName.Length>=5 && entity.CategoryName.Length<=50)
            {
                _categoryDal.Insert(entity);
            }
            else
            {
                //hata mesaji
            }
        }

        public List<Category> TtGetAll()
        {
            return _categoryDal.GetAll();
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}