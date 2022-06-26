namespace DBStudent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("University.Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            Issues_of_books = new ObservableListSource<Issues_of_books>();
        }

        [Key]
        public int book_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string title { get; set; }

        [Required]
        [StringLength(20)]
        public string author { get; set; }

        [StringLength(20)]
        public string genre { get; set; }

        [Column(TypeName = "money")]
        public decimal price { get; set; }

        public int book_count { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Issues_of_books> Issues_of_books { get; set; }
    }
}
