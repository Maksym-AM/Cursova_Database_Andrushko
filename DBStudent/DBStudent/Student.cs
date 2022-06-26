namespace DBStudent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("University.Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            Issues_of_books = new ObservableListSource<Issues_of_books>();
            Student_grade = new ObservableListSource<Student_grade>();
        }

        public int passport_ID { get; set; }

        [Key]
        public int student_ID { get; set; }

        public int group_ID { get; set; }

        [Column(TypeName = "money")]
        public decimal? scholarship { get; set; }

        public int place_in_rating { get; set; }

        public int? dorm_room { get; set; }

        public bool? headmaster { get; set; }

        public virtual Group Group { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Issues_of_books> Issues_of_books { get; set; }

        public virtual Person Person { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Student_grade> Student_grade { get; set; }
    }
}
