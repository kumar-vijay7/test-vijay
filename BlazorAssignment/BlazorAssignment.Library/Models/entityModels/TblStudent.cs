using System;
using System.Collections.Generic;

namespace BlazorAssignment.Library.Models.entityModels
{
    public partial class TblStudent
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public string StudentCourse { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
        public string StudentAddress { get; set; }
    }
}
