namespace DbModelTest.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class TypeCode
	{
		[Required]
		public virtual Code Code { get; set; }

		public int CodeId { get; set; }

		public virtual ICollection<Measurement> Measurements { get; set; } = new List<Measurement>();

		[Required]
		public virtual Type Type { get; set; }

		public int TypeId { get; set; }
	}
}