namespace Demodal.model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<DutyInfo> DutyInfo { get; set; }
        public virtual DbSet<information> information { get; set; }
        public virtual DbSet<trashtype> trashtype { get; set; }
        public virtual DbSet<usertable> usertable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DutyInfo>()
                .Property(e => e.DutyName)
                .IsUnicode(false);

            //modelBuilder.Entity<usertable>()
            //    .HasForeignKey(e => e.userDuty);

            modelBuilder.Entity<information>()
                .Property(e => e.infoName)
                .IsUnicode(false);

            modelBuilder.Entity<information>()
                .Property(e => e.infoImg)
                .IsUnicode(false);

            modelBuilder.Entity<trashtype>()
                .Property(e => e.typeName)
                .IsUnicode(false);

            modelBuilder.Entity<trashtype>()
                .Property(e => e.typeHarm)
                .IsUnicode(false);

            modelBuilder.Entity<trashtype>()
                .Property(e => e.typeWay)
                .IsUnicode(false);

            modelBuilder.Entity<trashtype>()
                .HasMany(e => e.information)
                .WithOptional(e => e.trashtype)
                .HasForeignKey(e => e.infoType);

            modelBuilder.Entity<usertable>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<usertable>()
                .Property(e => e.userWord)
                .IsUnicode(false);
        }
    }
}
