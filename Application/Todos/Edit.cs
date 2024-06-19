using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Todos
{
    public class Edit
    {
        public class Command:IRequest{
            public TodoItem TodoItem {get;set;}
        }
        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context,IMapper mapper)
            {
                _context = context;     
                _mapper=mapper;
            }
            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var todoItem = await _context.TodoItems.FindAsync(request.TodoItem.Id);
                _mapper.Map(request.TodoItem,todoItem);
                
                await _context.SaveChangesAsync();
            }
        }
    }
}