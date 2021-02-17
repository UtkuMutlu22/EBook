using Core.DataAccess;
using EBook.Entities.Abstract;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.DataAccess.Abstract
{
    public interface IAdminDal:IEntityRepository<Admin>,IAnswerDal,IAudioDal,IBookDal,IContextDal,ICosulantDal,IPictureDal,IPriceDal,IQuestionDal,IRemakDal,IStudentDal,IStudentQuestionDal,ITeacherDal,IVideoDal
    {
    }
}
