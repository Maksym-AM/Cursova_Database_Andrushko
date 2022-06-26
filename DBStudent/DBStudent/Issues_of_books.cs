namespace DBStudent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("University.Issues_of_books")]
    public partial class Issues_of_books
    {
        [Key]
        public int issues_of_books_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_issues { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_comeback { get; set; }

        public int book_ID { get; set; }

        public int student_ID { get; set; }

        public virtual Book Book { get; set; }

        public virtual Student Student { get; set; }
    }
}
