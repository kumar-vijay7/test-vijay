using BlazorAssignment.Library.Models.entityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.Data.Respository
{
   public interface IStudentRepository
    {
        List<TblStudent> StudentDetail();
        bool InsertStudent(TblStudent student);

        TblStudent StudentById(string id);
        bool UpdateStudent(string id,TblStudent student);

        bool DeleteStudent(int id);


    }
}
