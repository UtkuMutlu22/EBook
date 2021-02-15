using EBook.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.DataAccess.Abstract
{
    public interface IDetails
    {
        List<StudentDetail> GetStudentDetail();
        List<TeacherDetail> GetTeacherDetail();
    }
}
