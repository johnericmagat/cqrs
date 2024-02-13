using CQRS.Commands.AddBook;
using CQRS.Entities;
using CQRS.Queries.GetBook;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.EnvironmentVariables;

namespace CQRS.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BookController : ControllerBase
	{
		private IMediator _mediator;

		public BookController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public Task<Book> Get(string name)
		{
			var query = new GetBookQuery(name);
			return _mediator.Send(query);
		}

		[HttpPost]
		public Task Add(Book book)
		{
			var command = new AddBookCommand(book);
			return _mediator.Send(command);
		}
	}
}
