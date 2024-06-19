using Domain;
using MediatR;
using Persistence;

namespace Application.Todos
{
     public class Details
    {
        public class Query:IRequest<TodoItem>
        {
            public Guid Id {get;set;}
        }
        public class Handler : IRequestHandler<Query, TodoItem>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
                
            }
            public async Task<TodoItem> Handle(Query request, CancellationToken cancellationToken) => await _context.TodoItems.FindAsync(request.Id);
        }
    }
}