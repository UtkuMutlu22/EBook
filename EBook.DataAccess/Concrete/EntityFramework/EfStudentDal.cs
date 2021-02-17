using Core.DataAccess.EntityFramework;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EBook.DataAccess.Concrete.EntityFramework
{
    public class EfStudentDal : EfEntityRepositoryBase<Student, EBookContext>, IStudentDal, IAudioDal, IPictureDal, IAnswerDal
    {
        IAnswerDal _answerDal;
        IAudioDal _audioDal;
        IPictureDal _pictureDal;

        public EfStudentDal(IPictureDal pictureDal,IAnswerDal answerDal,IAudioDal audioDal)
        {
            _pictureDal = pictureDal;
            _audioDal = audioDal;
            _pictureDal = pictureDal;
        }

        public void Add(Audio entity)
        {
            _audioDal.Add(entity);
        }

        public void Add(Picture entity)
        {
            _pictureDal.Add(entity);
        }

        public void Add(Answer entity)
        {
            _answerDal.Add(entity);
        }

        public void Delete(Audio entity)
        {
            _audioDal.Delete(entity);
        }

        public void Delete(Picture entity)
        {
            _pictureDal.Delete(entity);
        }

        public void Delete(Answer entity)
        {
            _answerDal.Delete(entity);
        }

        public Audio Get(Expression<Func<Audio, bool>> filter)
        {
            return
            _audioDal.Get(filter);
        }

        public Picture Get(Expression<Func<Picture, bool>> filter)
        {
            return
           _pictureDal.Get(filter);
        }

        public Answer Get(Expression<Func<Answer, bool>> filter)
        {
            return
           _answerDal.Get(filter);
        }

        public List<Audio> GetAll(Expression<Func<Audio, bool>> filter = null)
        {
            return
            _audioDal.GetAll();
        }

        public List<Picture> GetAll(Expression<Func<Picture, bool>> filter = null)
        {
            return
           _pictureDal.GetAll();
        }

        public List<Answer> GetAll(Expression<Func<Answer, bool>> filter = null)
        {
            return
           _answerDal.GetAll();
        }

        public void Update(Audio entity)
        {
            _audioDal.Update(entity);
        }

        public void Update(Picture entity)
        {
            _pictureDal.Update(entity);
        }

        public void Update(Answer entity)
        {
            _answerDal.Update(entity);
        }
    }
}
