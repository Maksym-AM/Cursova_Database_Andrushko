namespace DBStudent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("University.Teacher")]
    public partial class Teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher()
        {
            Disciplines = new ObservableListSource<Discipline>();
        }

        [Key]
        public int teacher_ID { get; set; }

        [StringLength(10)]
        public string name { get; set; }

        [StringLength(15)]
        public string surname { get; set; }

        [Required]
        [StringLength(30)]
        public string scientist_degree { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Discipline> Disciplines { get; set; }
    }
}
