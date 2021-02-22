using Core.Utilities.Results;
using EBook.Business.Abstract;
using EBook.DataAccess;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public IResult Add(Question question)
        {
            _questionDal.Add(question);
            return new SuccessResult();
        }

        public IResult Delete(Question question)
        {
            _questionDal.Delete(question);
            return new SuccessResult();
        }

        public IDataResult<Question> Get(int questionId)
        {
            return new SuccessDataResult<Question>(_questionDal.Get(question=>question.QuestionId==questionId));
        }

        public IDataResult<List<Question>> GetAll()
        {
            return new SuccessDataResult<List<Question>>(_questionDal.GetAll());
        }

        public IDataResult<List<QuestionDetail>> GetAllQuestionDetail()
        {
            using (EBookContext context =new EBookContext())
            {
                var result = from question in context.Questions
                             join book in context.Books
                             on question.BookId equals book.BookId
                             join answer in context.Answers
                             on question.QuestionAnswer equals answer.AnswerId
                             join video in context.Videos
                             on question.QuestionVideo equals video.VideoId
                             join audio in context.Audios
                             on question.QuestionAudio equals audio.AudioId
                             join picture in context.Pictures
                             on question.QuestionPicture equals picture.PictureId
                             select new QuestionDetail
                             {
                                 BookName=book.BookName,
                                 QuestionText=question.QuestionText,
                                 QuestionPicture=question.QuestionPicture,
                                 QuestionAudio=question.QuestionAudio,
                                 QuestionVideo=question.QuestionVideo,
                                 QuestionAnswer=question.QuestionAnswer
                             };
                return new SuccessDataResult<List<QuestionDetail>>(result.ToList());
            }
        }

        public IResult Update(Question question)
        {
            _questionDal.Update(question);
            return new SuccessResult();
        }
    }
}
