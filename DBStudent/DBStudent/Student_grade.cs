namespace DBStudent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("University.Student_grade")]
    public partial class Student_grade
    {
        [Key]
        public int number { get; set; }

        public int? dsscipline_ID { get; set; }

        public int student_ID { get; set; }

        public double? grade { get; set; }

        public virtual Discipline Discipline { get; set; }

        public virtual Student Student { get; set; }
    }
}
