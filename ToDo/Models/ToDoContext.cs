using Microsoft.EntityFrameworkCore;

namespace ToDoDemo.Models
{
	public class ToDoContext:DbContext
	{
		public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }
		public DbSet<ToDo> ToDos { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Status> Statuses { get; set; }

		// seed data 

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(

				new Category { CategoryId = "work", CategoryName = "Work" },
				new Category { CategoryId = "home", CategoryName = "Home" },
				new Category { CategoryId = "ex", CategoryName = "Exercise" },
				new Category { CategoryId = "shop", CategoryName = "Shopping" },
				new Category { CategoryId = "call", CategoryName = "Contact" }
                );

			modelBuilder.Entity<Status>().HasData(
				
				new Status { StatusId="open", StatusName="Open"},
				new Status { StatusId = "Closed", StatusName = "Completed" }


				);
				
				
				
		}
	}
}
