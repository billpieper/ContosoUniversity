using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("First Name")]
        public string FirstMidName { get; set; }





        //未制定的日期的显示格式，默认情况下，根据基于服务器的 CultureInfo 的默认格式显示该数据字段。
        [DataType(DataType.Date)]
        //设置指定的格式应该也应用时的值显示在文本框中进行编辑。（你可能不想一些领域 — — 例如，对于货币值，你可能不希望货币符号在文本框中进行编辑。
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}",ApplyFormatInEditMode=true )]
        [Display(Name= "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName {
            get {
                return LastName + "," + FirstMidName;
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}