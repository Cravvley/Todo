
using MediatR;
using Persistence;

namespace Application.Todos
{
    public class Delete
    {
        public class Command:IRequest
        {
            public Guid Id { get;set;}
        }
        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var todoItem = await _context.TodoItems.FindAsync(request.Id);
                _context.Remove(todoItem);

                await _context.SaveChangesAsync();
            }
        }
    }
}