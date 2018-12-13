namespace DbModelTest
{
	using DbModelTest.Entities;
	using Microsoft.EntityFrameworkCore;

	public class CorrectContext : DbContext
	{
		public CorrectContext()
		{
			Database.EnsureDeleted();
			Database.EnsureCreated();
		}

		public DbSet<Measurement> Measurements { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlite("Data Source = correct.db").UseLazyLoadingProxies();
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<TypeUnit>().HasKey(x => new { x.TypeId, x.UnitId });
			modelBuilder.Entity<TypeMethod>().HasKey(x => new { x.TypeId, x.MethodId });
			modelBuilder.Entity<TypeCode>().HasKey(x => new { x.TypeId, x.CodeId });

			// The only difference is the order here:
			modelBuilder.Entity<Measurement>().HasOne(t => t.TypeUnit).WithMany(t => t.Measurements)
				.HasForeignKey("TypeId", "UnitId");
			modelBuilder.Entity<Measurement>().HasOne(t => t.TypeMethod).WithMany(t => t.Measurements)
				.HasForeignKey("TypeId", "MethodId");
			modelBuilder.Entity<Measurement>().HasOne(t => t.TypeCode).WithMany(t => t.Measurements)
				.HasForeignKey("TypeId", "CodeId");
		}
	}
}