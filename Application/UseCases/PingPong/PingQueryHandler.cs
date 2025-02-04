using MediatR;
namespace Application.UseCases.PingPong
{
    public class PingQueryHandler : IRequestHandler<PingQuery, PingQueryResultDTO>
    {
        public Task<PingQueryResultDTO> Handle(PingQuery request, CancellationToken cancellationToken)
        {
            var result = new PingQueryResultDTO { Message = "Pong" };
            return Task.FromResult(result);
        }
    }
}