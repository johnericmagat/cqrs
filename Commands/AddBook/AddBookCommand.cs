using CQRS.Entities;
using MediatR;

namespace CQRS.Commands.AddBook
{
	public class AddBookCommand : IRequest
	{
		public Book	Book { get; set; }

		public AddBookCommand(Book book)
		{
			Book = book;
		}
	}
}
