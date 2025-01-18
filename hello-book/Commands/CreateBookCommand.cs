using MediatR;

public record CreateBookCommand(string Title, string Author) : IRequest<Guid>;
