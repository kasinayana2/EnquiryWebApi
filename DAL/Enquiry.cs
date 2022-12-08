namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Enquiry")]
    public partial class Enquiry
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string FristName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public int? Age { get; set; }

        [StringLength(100)]
        public string Address { get; set; }
    }
}
