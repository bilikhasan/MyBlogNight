﻿using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccesLayer.Abstract
{
    public interface ISocialMediaDal : IGenericDal<SocialMedia>     //IGenericDal'dan SocialMedia sınıf için miras alıyoruz
    {

    }
}
