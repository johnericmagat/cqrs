using MediatR;

namespace CQRS.Commands.AddBook
{
	public class AddBookCommandHandler : IRequestHandler<AddBookCommand>
	{
		public Task<Unit> Handle(AddBookCommand request, CancellationToken cancellationToken)
		{
			// TODO: Add book to the database

			return Unit.Task;
		}
	}
}
