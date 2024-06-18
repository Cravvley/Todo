using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Todos
{
    public class List
    {
        public class Query:IRequest<List<TodoItem>>{}
        public class Handler : IRequestHandler<Query, List<TodoItem>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<TodoItem>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.TodoItems.ToListAsync();
            }
        }
    }
}