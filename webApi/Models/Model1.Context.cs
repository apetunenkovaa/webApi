//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Petunenkova_API_TogetherEntities : DbContext
    {
        public Petunenkova_API_TogetherEntities()
            : base("name=Petunenkova_API_TogetherEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Freetime> Freetime { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Kitchen> Kitchen { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
