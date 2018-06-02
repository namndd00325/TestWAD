//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWAD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Exam
    {
        public int id { get; set; }
        [Display(Name = "Subject")]
        public Nullable<int> examSubject { get; set; }

        [Display(Name = "Star Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh: mm}")]
        public System.DateTime startTime { get; set; }

        [Display(Name = "Exam Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime examDate { get; set; }

        [Display(Name = "Duration")]

        public int duration { get; set; }

        [Display(Name = "Class Room")]
        public Nullable<int> classRoom { get; set; }

        [Display(Name = "Faculty")]
        public Nullable<int> faculty { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Faculty Faculty1 { get; set; }
    }
}
