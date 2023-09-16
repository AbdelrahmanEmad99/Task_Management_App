using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace ToDoDemo.Models
{
	public class ToDo
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Please Enter a Description . ")]
		public string Description { get; set; } = string.Empty;
		[Required(ErrorMessage = "Please Enter a Due Data . ")]
		public DateTime DueData { get; set; }

		[Required(ErrorMessage = "Please Select a Category.")]
		public string CategoryId { get; set; } = string.Empty;
		[ValidateNever]
		public Category Category { get; set; } = null!;

		[Required(ErrorMessage = "Please Select a Status . ")]
		public string StatusId { get; set; } = string.Empty;

		[ValidateNever]
		public Status  Status{ get; set; } = null!;

		public bool Overdue => StatusId == "open" && DueData < DateTime.Today;

		/*public bool Overdue
		{
			
				if (StatusId == "open" && DueDate < DateTime.Today)
				{
					return true;
				}
				else
				{
					return false;
				}
			
		}*/





	}
}
