using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EBook.DataAccess.Abstract
{
    public interface ICosulantDetail
    {
        List<CosulantDetail> GetConsulantDetails();
        CosulantDetail GetByPictureDetail(Expression<Func<Picture, bool>> filter);
    }
}
