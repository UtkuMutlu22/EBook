using Core.Utilities.Results;
using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface IAudioService
    {
        IDataResult<List<Audio>> GetAll();
        IDataResult<Audio> GetByAudio(int id);
        IDataResult<List<AudioDetail>>GetAudioDetail();
        IResult Add(Audio audio);
        IResult Delete(Audio audio);
        IResult Update(Audio audio);
    }
}
