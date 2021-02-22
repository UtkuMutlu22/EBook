using Core.Utilities.Results;
using EBook.Business.Abstract;
using EBook.DataAccess;
using EBook.DataAccess.Abstract;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBook.Business.Concrete
{
    public class AudioManager : IAudioService
    {
        IAudioDal _audioDal;

        public AudioManager(IAudioDal audioDal)
        {
            _audioDal = audioDal;
        }

        public IResult Add(Audio audio)
        {
            _audioDal.Add(audio);
            return new SuccessResult();
        }

        public IResult Delete(Audio audio)
        {
            _audioDal.Delete(audio);
            return new SuccessResult();
        }

        public IDataResult<List<Audio>> GetAll()
        {
            return new SuccessDataResult<List<Audio>>(_audioDal.GetAll().ToList());
        }

        public IDataResult<List<AudioDetail>> GetAudioDetail()
        {
            using (EBookContext context=new EBookContext())
            {
                var result = from audio in context.Audios
                             join question in context.Questions
                             on audio.AudioId equals question.QuestionId
                             join answer in context.Answers
                             on audio.AudioId equals answer.AnswerAudio
                             join teacher in context.Teachers
                             on audio.TeacherId equals teacher.TeacherId
                             join student in context.Students
                             on audio.StudentId equals student.StudentId
                             join remak in context.Remaks
                             on audio.RemakId equals remak.RemakId
                             select new AudioDetail
                             {
                                 AudioName=audio.AudioName,
                                 TeacherName=teacher.FirstName+" "+teacher.LastName,
                                 StudentName=student.FirstName+" "+student.LastName,
                                 RemakText=remak.Text

                             };
                return new SuccessDataResult<List<AudioDetail>>(result.ToList());
            }
        }

        public IDataResult<Audio> GetByAudio(int id)
        {
            
            return new SuccessDataResult<Audio>(_audioDal.Get(audio=>audio.AudioId==id));
        }

        public IResult Update(Audio audio)
        {
            _audioDal.Update(audio);
            return new SuccessResult();
        }
    }
}
