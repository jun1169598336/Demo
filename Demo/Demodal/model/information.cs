namespace Demodal.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class information
    {
        [Key]
        public int infoId { get; set; }

        [StringLength(20)]
        public string infoName { get; set; }

        [StringLength(20)]
        public string infoImg { get; set; }

        public int? infoType { get; set; }

        public virtual trashtype trashtype { get; set; }
    }
}
