//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCAdvance.Models.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TBL_EMPLOYEES
    {
        [Display(Name = "Employee ID")]
        public int EMP_ID { get; set; }
        [Required(ErrorMessage ="Please Fill the Detail")]
        [Display(Name ="Employee Name")]
        public string EMP_Name { get; set; }
        [Required(ErrorMessage = "Please Fill the Detail")]
        [Display(Name = "Date of Birth")]
        public Nullable<System.DateTime> EMP_DOB { get; set; }
        [Required(ErrorMessage = "Please Fill the Detail")]
        [Display(Name = "Salary")]
        public Nullable<decimal> EMP_SALARY { get; set; }
        [Required(ErrorMessage = "Please Fill the Detail")]
        [Display(Name = "Manager ID")]
        public Nullable<int> Manager_Id { get; set; }
        public Nullable<bool> IsTrainer { get; set; }
    }
}