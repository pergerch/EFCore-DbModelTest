namespace DbModelTest.Entities
{
	using System.ComponentModel.DataAnnotations;

	public class Measurement
	{
		public int Id { get; set; }

		public virtual TypeCode TypeCode { get; set; }

		[Required]
		public virtual TypeMethod TypeMethod { get; set; }

		[Required]
		public virtual TypeUnit TypeUnit { get; set; }

		public double? Value { get; set; }
	}
}