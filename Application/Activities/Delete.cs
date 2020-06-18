using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = await _context.Activities.FindAsync(request.Id);

                if(activity == null)
                throw new Exception("Activity doesn't exist. Please try again later");

                _context.Remove(activity);

                var succsess = await _context.SaveChangesAsync() > 0;

                if (succsess) return Unit.Value;

                throw new Exception("Error occured while saving the Activities record. Please try again later");
            }
        }
    }
}