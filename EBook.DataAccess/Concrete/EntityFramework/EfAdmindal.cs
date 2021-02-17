using Core.DataAccess.EntityFramework;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EBook.DataAccess.Concrete.EntityFramework
{
    public class EfAdmindal : EfEntityRepositoryBase<Admin, EBookContext>, IAdminDal, IAnswerDal,IAudioDal
    {
        IAnswerDal _answerDal;
        IAudioDal _audioDal;
        IBookDal _bookDal;
        IContextDal _contextDal;
        ICosulantDal _cosulantDal;
        IPictureDal _pictureDal;
        IPriceDal _priceDal;
        IQuestionDal _questionDal;
        IRemakDal _remakDal;
        IStudentDal _studentDal;
        IStudentQuestionDal _studentQuestionDal;
        ITeacherDal _teacherDal;
        IVideoDal _videoDal;

        public EfAdmindal(IAnswerDal answerDal, IAudioDal audioDal, IBookDal bookDal, IContextDal contextDal, ICosulantDal cosulantDal, IPictureDal pictureDal, IPriceDal priceDal, IQuestionDal questionDal, IRemakDal remakDal, IStudentDal studentDal, IStudentQuestionDal studentQuestionDal, ITeacherDal teacherDal, IVideoDal videoDal)
        {
            _audioDal = audioDal;
            _answerDal = answerDal;
            _bookDal = bookDal;
            _contextDal = contextDal;
            _cosulantDal = cosulantDal;
            _pictureDal = pictureDal;
            _priceDal = priceDal;
            _questionDal = questionDal;
            _remakDal = remakDal;
            _studentDal = studentDal;
            _studentQuestionDal = studentQuestionDal;
            _teacherDal = teacherDal;
            _videoDal = videoDal;
        }

        public void Add(Answer entity)
        {
            _answerDal.Add(entity);
        }

        public void Add(Audio entity)
        {
            _audioDal.Add(entity);
        }

        public void Add(Book entity)
        {
            _bookDal.Add(entity);
        }

        public void Add(Context entity)
        {
            _contextDal.Add(entity);
        }

        public void Add(Cosulant entity)
        {
            _cosulantDal.Add(entity);
        }

        public void Add(Picture entity)
        {
            _pictureDal.Add(entity);
        }

        public void Add(Price entity)
        {
            _priceDal.Add(entity);
        }

        public void Add(Question entity)
        {
            _questionDal.Add(entity);
        }

        public void Add(Remak entity)
        {
            _remakDal.Add(entity);
        }

        public void Add(Student entity)
        {
            _studentDal.Add(entity);
        }

        public void Add(StudentQuestion entity)
        {
            _studentQuestionDal.Add(entity);
        }

        public void Add(Teacher entity)
        {
            _teacherDal.Add(entity);
        }

        public void Add(Video entity)
        {
            _videoDal.Add(entity);
        }

        public void Delete(Answer entity)
        {
            _answerDal.Delete(entity);
        }

        public void Delete(Audio entity)
        {
            _audioDal.Delete(entity);
        }

        public void Delete(Book entity)
        {
            _bookDal.Delete(entity);
        }

        public void Delete(Context entity)
        {
            _contextDal.Delete(entity);
        }

        public void Delete(Cosulant entity)
        {
            _cosulantDal.Delete(entity);
        }

        public void Delete(Picture entity)
        {
            _pictureDal.Delete(entity);
        }

        public void Delete(Price entity)
        {
            _priceDal.Delete(entity);
        }

        public void Delete(Question entity)
        {
            _questionDal.Delete(entity);
        }

        public void Delete(Remak entity)
        {
            _remakDal.Delete(entity);
        }

        public void Delete(Student entity)
        {
            _studentDal.Delete(entity);
        }

        public void Delete(StudentQuestion entity)
        {
            _studentQuestionDal.Delete(entity);
        }

        public void Delete(Teacher entity)
        {
            _teacherDal.Delete(entity);
        }

        public void Delete(Video entity)
        {
            _videoDal.Delete(entity);
        }

        public Answer Get(Expression<Func<Answer, bool>> filter)
        {
            return _answerDal.Get(filter);
        }

        public Audio Get(Expression<Func<Audio, bool>> filter)
        {
            return _audioDal.Get(filter);
        }

        public Book Get(Expression<Func<Book, bool>> filter)
        {
            return
            _bookDal.Get(filter);
        }

        public Context Get(Expression<Func<Context, bool>> filter)
        {
            return
            _contextDal.Get(filter);
        }

        public Cosulant Get(Expression<Func<Cosulant, bool>> filter)
        {
            return
           _cosulantDal.Get(filter);
        }

        public Picture Get(Expression<Func<Picture, bool>> filter)
        {
            return
           _pictureDal.Get(filter);
        }

        public Price Get(Expression<Func<Price, bool>> filter)
        {
            return
           _priceDal.Get(filter);
        }

        public Question Get(Expression<Func<Question, bool>> filter)
        {
            return
           _questionDal.Get(filter);
        }

        public Remak Get(Expression<Func<Remak, bool>> filter)
        {
            return
           _remakDal.Get(filter);
        }

        public Student Get(Expression<Func<Student, bool>> filter)
        {
            return
           _studentDal.Get(filter);
        }

        public StudentQuestion Get(Expression<Func<StudentQuestion, bool>> filter)
        {
            return
           _studentQuestionDal.Get(filter);
        }

        public Teacher Get(Expression<Func<Teacher, bool>> filter)
        {
            return
           _teacherDal.Get(filter);
        }

        public Video Get(Expression<Func<Video, bool>> filter)
        {
            return
           _videoDal.Get(filter);
        }

        public List<Answer> GetAll(Expression<Func<Answer, bool>> filter = null)
        {
            return _answerDal.GetAll();
        }

        public List<Audio> GetAll(Expression<Func<Audio, bool>> filter = null)
        {
            return _audioDal.GetAll();
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            return _bookDal.GetAll();
        }

        public List<Context> GetAll(Expression<Func<Context, bool>> filter = null)
        {
            return _contextDal.GetAll();
        }

        public List<Cosulant> GetAll(Expression<Func<Cosulant, bool>> filter = null)
        {
            return _cosulantDal.GetAll();
        }

        public List<Picture> GetAll(Expression<Func<Picture, bool>> filter = null)
        {
            return _pictureDal.GetAll();
        }

        public List<Price> GetAll(Expression<Func<Price, bool>> filter = null)
        {
            return _priceDal.GetAll();
        }

        public List<Question> GetAll(Expression<Func<Question, bool>> filter = null)
        {
            return _questionDal.GetAll();
        }

        public List<Remak> GetAll(Expression<Func<Remak, bool>> filter = null)
        {
            return _remakDal.GetAll();
        }

        public List<Student> GetAll(Expression<Func<Student, bool>> filter = null)
        {
            return _studentDal.GetAll();
        }

        public List<StudentQuestion> GetAll(Expression<Func<StudentQuestion, bool>> filter = null)
        {
            return _studentQuestionDal.GetAll();
        }

        public List<Teacher> GetAll(Expression<Func<Teacher, bool>> filter = null)
        {
            return _teacherDal.GetAll();
        }

        public List<Video> GetAll(Expression<Func<Video, bool>> filter = null)
        {
            return _videoDal.GetAll();
        }

        public void Update(Answer entity)
        {
            _answerDal.Delete(entity);
        }

        public void Update(Audio entity)
        {
            _audioDal.Update(entity);
        }

        public void Update(Book entity)
        {
            _bookDal.Update(entity);
        }

        public void Update(Context entity)
        {
            _contextDal.Update(entity);
        }

        public void Update(Cosulant entity)
        {
            _cosulantDal.Update(entity);
        }

        public void Update(Picture entity)
        {
            _pictureDal.Update(entity);
        }

        public void Update(Price entity)
        {
            _priceDal.Update(entity);
        }

        public void Update(Question entity)
        {
            _questionDal.Update(entity);
        }

        public void Update(Remak entity)
        {
            _remakDal.Update(entity);
        }

        public void Update(Student entity)
        {
            _studentDal.Update(entity);
        }

        public void Update(StudentQuestion entity)
        {
            _studentQuestionDal.Update(entity);
        }

        public void Update(Teacher entity)
        {
            _teacherDal.Update(entity);
        }

        public void Update(Video entity)
        {
            _videoDal.Update(entity);
        }
    }
}
