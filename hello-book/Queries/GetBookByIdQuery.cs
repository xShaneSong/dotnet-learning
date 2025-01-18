using MediatR;

public record GetBookByIdQuery(Guid Id) : IRequest<Book>;
