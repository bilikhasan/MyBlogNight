using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccesLayer.Abstract
{
    public interface ITagCloudDal :IGenericDal<TagCloud>        //IGenericDal'dan TagCloud sınıfı için miras aldık.
    {

    }
}
