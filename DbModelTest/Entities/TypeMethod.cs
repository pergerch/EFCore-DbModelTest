namespace DbModelTest.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class TypeMethod
	{
		public virtual ICollection<Measurement> Measurements { get; set; } = new List<Measurement>();

		[Required]
		public virtual Method Method { get; set; }

		public int MethodId { get; set; }

		[Required]
		public virtual Type Type { get; set; }

		public int TypeId { get; set; }
	}
}