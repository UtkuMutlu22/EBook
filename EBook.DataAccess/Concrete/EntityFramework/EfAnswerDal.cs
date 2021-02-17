using Core.DataAccess.EntityFramework;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EBook.DataAccess.Concrete.EntityFramework
{
    public class EfAnswerDal : EfEntityRepositoryBase<Answer, EBookContext>, IAnswerDal, IAnswerDetail
    {
        public List<AnswerDetail> GetAnswerDetail()
        {
            using (EBookContext context = new EBookContext())
            {
                var result = from answer in context.Answers
                             join teacher in context.Teachers
                             on answer.AnswerId equals teacher.AnswerId
                             join question in context.Questions
                             on answer.AnswerId equals question.QuestionAnswer
                             join video in context.Videos
                             on answer.AnswerVideo equals video.VideoId
                             join audio in context.Audios
                             on answer.AnswerAudio equals audio.AudioId
                             join picture in context.Pictures
                             on answer.AnswerPicture equals picture.PictureId
                             join remak in context.Remaks
                             on answer.Remak equals remak.RemakId
                             select new AnswerDetail
                             {
                                 Id = answer.AnswerId,
                                 OwnerName = teacher.FirstName,
                                 AnswerText = answer.AnswerText,
                                 AnswerAudio = audio.AudioId,
                                 AnswerPicture = picture.PictureId,
                                 AnswerVideo = video.VideoId,
                                 QuestionAudio = audio.AudioId,
                                 QuestionPicture = picture.PictureId,
                                 QuestionText = question.QuestionText,
                                 QuestionVideo = video.VideoId,
                                 RemakId = answer.Remak


                             };
                return result.ToList();
            }
        }

        public AnswerDetail GetByAnswerDetail(int id)
        {
            using(EBookContext context=new EBookContext())
            {
                var result = from answer in context.Answers
                             join teacher in context.Teachers
                             on answer.AnswerId equals teacher.AnswerId
                             join question in context.Questions
                             on answer.AnswerId equals question.QuestionAnswer
                             join video in context.Videos
                             on answer.AnswerVideo equals video.VideoId
                             join audio in context.Audios
                             on answer.AnswerAudio equals audio.AudioId
                             join picture in context.Pictures
                             on answer.AnswerPicture equals picture.PictureId
                             join remak in context.Remaks 
                             on answer.Remak equals remak.RemakId
                             select new AnswerDetail
                             {
                                 Id=answer.AnswerId,
                                 OwnerName=teacher.FirstName,
                                 AnswerText=answer.AnswerText,
                                 AnswerAudio=audio.AudioId,
                                 AnswerPicture=picture.PictureId,
                                 AnswerVideo=video.VideoId,
                                 QuestionAudio=audio.AudioId,
                                 QuestionPicture=picture.PictureId,
                                 QuestionText=question.QuestionText,
                                 QuestionVideo=video.VideoId,
                                 RemakId=answer.Remak
                                
                                 
                             };
                return result.FirstOrDefault(answer => answer.Id == id);
            }
        }
    }
}
