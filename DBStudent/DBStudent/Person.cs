namespace DBStudent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("University.Person")]
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            Students = new ObservableListSource<Student>();
        }

        [Key]
        public int passport_ID { get; set; }

        public int identification_code { get; set; }

        [Required]
        [StringLength(10)]
        public string name { get; set; }

        [Required]
        [StringLength(15)]
        public string surname { get; set; }

        [Column(TypeName = "date")]
        public DateTime Year_of_birth { get; set; }

        [StringLength(20)]
        public string Place_of_birth { get; set; }

        [StringLength(50)]
        public string adress { get; set; }

        [Required]
        [StringLength(1)]
        public string sex { get; set; }

        public bool? marital_status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Student> Students { get; set; }
    }
}
