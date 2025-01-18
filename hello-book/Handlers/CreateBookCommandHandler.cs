using MediatR;
using System.Threading;
using System.Threading.Tasks;

public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, Guid>
{
    public Task<Guid> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        // 处理命令逻辑，例如保存到数据库
        var newBookId = Guid.NewGuid();
        return Task.FromResult(newBookId);
    }
}
