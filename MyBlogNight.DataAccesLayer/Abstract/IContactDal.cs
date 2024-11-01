using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccesLayer.Abstract
{
    public interface IContactDal :IGenericDal<Contact>      //IGenericDal'dan Contact sınıfı için miras alıyoruz
    {
    }
}
