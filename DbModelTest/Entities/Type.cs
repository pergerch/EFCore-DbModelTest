namespace DbModelTest.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Type
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public virtual ICollection<TypeCode> TypeCodes { get; set; } = new List<TypeCode>();

		public virtual ICollection<TypeMethod> TypeMethods { get; set; } = new List<TypeMethod>();

		public virtual ICollection<TypeUnit> TypeUnits { get; set; } = new List<TypeUnit>();
	}
}