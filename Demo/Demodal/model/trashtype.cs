namespace Demodal.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("trashtype")]
    public partial class trashtype
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trashtype()
        {
            information = new HashSet<information>();
        }

        [Key]
        public int typeId { get; set; }

        [DisplayName("����")]
        [StringLength(20)]
        public string typeName { get; set; }

        [DisplayName("Σ��")]
        [StringLength(50)]
        public string typeHarm { get; set; }

        [DisplayName("����ʽ")]
        [StringLength(50)]
        public string typeWay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<information> information { get; set; }
    }
}
