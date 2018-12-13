namespace DbModelTest.Entities
{
	using System.Collections.Generic;

	public class TypeUnit
	{
		public virtual ICollection<Measurement> Measurements { get; set; } = new List<Measurement>();

		public virtual Type Type { get; set; }

		public int TypeId { get; set; }

		public virtual Unit Unit { get; set; }

		public int UnitId { get; set; }
	}
}