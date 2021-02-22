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
    public class ContextManager : IContextService
    {
        IContextDal _contextDal;

        public ContextManager(IContextDal contextDal)
        {
            _contextDal = contextDal;
        }

        public IResult Add(Context context)
        {
            _contextDal.Add(context);
            return new SuccessResult();
        }

        public IResult Delete(Context context)
        {
            _contextDal.Delete(context);
            return new SuccessResult();
        }

        public IDataResult<List<Context>> GetAll()
        {
            return new SuccessDataResult<List<Context>>(_contextDal.GetAll());
        }

        public IDataResult<Context> GetByContext(int id)
        {
            return new SuccessDataResult<Context>(_contextDal.Get(context=>context.ContextId==id));
        }

        public IDataResult<List<ContextDetail>> GetContextDetail()
        {
            using (EBookContext context=new EBookContext())
            {
                var result = from contexts in context.Contexts
                             join publisher in context.Publishers
                             on contexts.PublisherId equals publisher.PublisherId
                             join question in context.Questions
                             on contexts.QuestionId equals question.QuestionId
                             join remak in context.Remaks
                             on contexts.RemakId equals remak.RemakId
                             join audio in context.Audios
                             on contexts.ContextAudio equals audio.AudioId
                             join video in context.Videos
                             on contexts.ContextVideo equals video.VideoId
                             join picture in context.Pictures
                             on contexts.ContextPicture equals picture.PictureId
                             join book in context.Books
                             on contexts.BookId equals book.BookId
                             select new ContextDetail
                             {
                                BookName= book.BookName,
                                ContextText=contexts.ContextText,
                                BookTitle=book.CategoryId,
                                PublisherName=publisher.PublisherName,
                                QuestionAnswer=question.QuestionAnswer,
                                QuestionAudio=question.QuestionAudio,
                                QuestionPicture=question.QuestionPicture,
                                QuestionText=question.QuestionText,
                                QuestionVideo=question.QuestionVideo,
                                Remak=remak.RemakId
                             };
                return new SuccessDataResult<List<ContextDetail>>(result.ToList());
            }
        }

        public IResult Update(Context context)
        {
            _contextDal.Update(context);
            return new SuccessResult();
        }
    }
}
