namespace DbModelTest.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Code
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public virtual ICollection<TypeCode> TypeCodes { get; set; } = new List<TypeCode>();
	}
}