using MediatR;
using System.Threading;
using System.Threading.Tasks;

public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, Book>
{
    public Task<Book> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
    {
        // 处理查询逻辑，例如从数据库获取数据
        var book = new Book { Id = request.Id, Title = "Sample Title", Author = "Sample Author" };
        return Task.FromResult(book);
    }
}
