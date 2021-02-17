using EBook.Entities.Concrete;
using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EBook.DataAccess.Abstract
{
    public interface IAudioDetail
    {
        List<AudioDetail> GetAudioDetails();
        AudioDetail GetByAudioDetail(int id);
    }
}
