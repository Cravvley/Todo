using Domain;
using MediatR;
using Persistence;

namespace Application.Todos
{
    public class Create
    {
        public class Command:IRequest{
            public TodoItem TodoItem {get;set;}
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
                _context.TodoItems.Add(request.TodoItem);
                await _context.SaveChangesAsync();
            }
        }
    }
}