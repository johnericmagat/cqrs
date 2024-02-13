using CQRS.Entities;
using MediatR;

namespace CQRS.Queries.GetBook
{
	public class GetBookQuery : IRequest<Book>
	{
		public string Name { get; set; }

		public GetBookQuery(string name)
		{
			Name = name;
		}
	}
}
