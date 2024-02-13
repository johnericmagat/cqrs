using CQRS.Entities;
using MediatR;

namespace CQRS.Queries.GetBook
{
	public class GetBookQueryHandler : IRequestHandler<GetBookQuery, Book>
	{
		public Task<Book> Handle(GetBookQuery request, CancellationToken cancellationToken)
		{
			// TODO: Find book by name in the database

			return Task.FromResult(new Book(request.Name));
		}
	}
}
