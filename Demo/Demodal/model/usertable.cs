namespace Demodal.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("usertable")]
    public partial class usertable
    {
        [Key]
        public int userId { get; set; }

        [StringLength(20)]
        public string userName { get; set; }

        [StringLength(20)]
        public string userWord { get; set; }

        public int? userDuty { get; set; }

        //public virtual DutyInfo DutyInfo { get; set; }
    }
}
