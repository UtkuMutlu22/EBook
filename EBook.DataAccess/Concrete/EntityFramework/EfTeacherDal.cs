using Core.DataAccess.EntityFramework;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EBook.DataAccess.Concrete.EntityFramework
{
    public class EfTeacherDal : EfEntityRepositoryBase<Teacher, EBookContext>, ITeacherDal, IQuestionDal, IStudentQuestionDal, IVideoDal, IAudioDal, IPictureDal, IAnswerDal
    {
        IAnswerDal _answerDal;
        IStudentQuestionDal _studentQuestionDal;
        IQuestionDal _questionDal;
        IVideoDal _videoDal;
        IPictureDal _pictureDal;
        IAudioDal _audioDal;

        public EfTeacherDal(IAnswerDal answerDal, IStudentQuestionDal studentQuestionDal, IQuestionDal questionDal, IVideoDal videoDal, IPictureDal pictureDal, IAudioDal audioDal)
        {
            _answerDal = answerDal;
            _studentQuestionDal = studentQuestionDal;
            _questionDal = questionDal;
            _videoDal = videoDal;
            _pictureDal = pictureDal;
            _audioDal = audioDal;
        }

        public void Add(Answer entity)
        {
            _answerDal.Add(entity);
        }

        public void Add(Question entity)
        {
            _questionDal.Add(entity);
        }

        public void Add(StudentQuestion entity)
        {
            _studentQuestionDal.Add(entity);
        }

        public void Add(Video entity)
        {
            _videoDal.Add(entity);
        }

        public void Add(Audio entity)
        {
            _audioDal.Add(entity);
        }

        public void Add(Picture entity)
        {
            _pictureDal.Add(entity);
        }

        public void Delete(Answer entity)
        {
            _answerDal.Delete(entity);
        }

        public void Delete(Question entity)
        {
            _questionDal.Delete(entity);
        }

        public void Delete(StudentQuestion entity)
        {
            _studentQuestionDal.Delete(entity);
        }

        public void Delete(Video entity)
        {
            _videoDal.Delete(entity);
        }

        public void Delete(Audio entity)
        {
            _audioDal.Delete(entity);
        }

        public void Delete(Picture entity)
        {
            _pictureDal.Delete(entity);
        }

        public Answer Get(Expression<Func<Answer, bool>> filter)
        {
            return
            _answerDal.Get(filter);
        }

        public Question Get(Expression<Func<Question, bool>> filter)
        {
            return
           _questionDal.Get(filter);
        }

        public StudentQuestion Get(Expression<Func<StudentQuestion, bool>> filter)
        {
            return
          _studentQuestionDal.Get(filter);
        }

        public Video Get(Expression<Func<Video, bool>> filter)
        {
            return
          _videoDal.Get(filter);
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

        public List<Answer> GetAll(Expression<Func<Answer, bool>> filter = null)
        {
            return _answerDal.GetAll();
        }

        public List<Question> GetAll(Expression<Func<Question, bool>> filter = null)
        {
            return _questionDal.GetAll();
        }

        public List<StudentQuestion> GetAll(Expression<Func<StudentQuestion, bool>> filter = null)
        {
            return _studentQuestionDal.GetAll();
        }

        public List<Video> GetAll(Expression<Func<Video, bool>> filter = null)
        {
            return _videoDal.GetAll();
        }

        public List<Audio> GetAll(Expression<Func<Audio, bool>> filter = null)
        {
            return _audioDal.GetAll();
        }

        public List<Picture> GetAll(Expression<Func<Picture, bool>> filter = null)
        {
            return _pictureDal.GetAll();
        }

        public void Update(Answer entity)
        {
            _answerDal.Update(entity);
        }

        public void Update(Question entity)
        {
            _questionDal.Update(entity);
        }

        public void Update(StudentQuestion entity)
        {
            _studentQuestionDal.Update(entity);
        }

        public void Update(Video entity)
        {
            _videoDal.Update(entity);
        }

        public void Update(Audio entity)
        {
            _audioDal.Update(entity);
        }

        public void Update(Picture entity)
        {
            _pictureDal.Update(entity);
        }
    }
}
