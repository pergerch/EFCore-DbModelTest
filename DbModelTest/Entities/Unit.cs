namespace DbModelTest.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Unit
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public virtual ICollection<TypeUnit> TypeUnits { get; set; } = new List<TypeUnit>();
	}
}