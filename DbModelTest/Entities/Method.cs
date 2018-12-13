namespace DbModelTest.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Method
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public virtual ICollection<TypeMethod> TypeUnits { get; set; } = new List<TypeMethod>();
	}
}