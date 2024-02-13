namespace CQRS.Entities
{
	public class Book
	{
		public string Name { get; set; }
		public Book(string name)
		{
			Name = name;
		}
	}
}
