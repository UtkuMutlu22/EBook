using Core.DataAccess.EntityFramework;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EBook.DataAccess.Concrete.EntityFramework
{
    public class EfAudioDal : EfEntityRepositoryBase<Audio, EBookContext>, IAudioDal, IAudioDetail
    {
        public List<AudioDetail> GetAudioDetails()
        {
            using (EBookContext context= new EBookContext())
            {
                var result = from audio in context.Audios
                             join student in context.Students
                             on audio.StudentId equals student.StudentId
                             join teacher in context.Teachers
                             on audio.TeacherId equals teacher.TeacherId
                             join remak in context.Remaks
                             on audio.RemakId equals remak.RemakId
                             select new AudioDetail
                             {
                                 AudioName=audio.AudioName,
                                 StudentName=student.FirstName,
                                 TeacherName=teacher.FirstName,
                                 RemakText=remak.Text
                             };
                return result.ToList();
            }
        }

        public AudioDetail GetByAudioDetail(int id)
        {
            using (EBookContext context = new EBookContext())
            {
                var result = from audio in context.Audios
                             join student in context.Students
                             on audio.StudentId equals student.StudentId
                             join teacher in context.Teachers
                             on audio.TeacherId equals teacher.TeacherId
                             join remak in context.Remaks
                             on audio.RemakId equals remak.RemakId
                             select new AudioDetail
                             {
                                 AudioName = audio.AudioName,
                                 StudentName = student.FirstName,
                                 TeacherName = teacher.FirstName,
                                 RemakText = remak.Text
                             };
                return result.FirstOrDefault(audio=>audio.AudioId==id);
            }
        }
    }
}
