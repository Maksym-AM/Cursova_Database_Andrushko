namespace DBStudent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("University.Discipline")]
    public partial class Discipline
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Discipline()
        {
            Student_grade = new ObservableListSource<Student_grade>();
        }

        [Key]
        public int discipline_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string name { get; set; }

        public int teacher_ID { get; set; }

        public int group_ID { get; set; }

        public virtual Group Group { get; set; }

        public virtual Teacher Teacher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Student_grade> Student_grade { get; set; }
    }
}
