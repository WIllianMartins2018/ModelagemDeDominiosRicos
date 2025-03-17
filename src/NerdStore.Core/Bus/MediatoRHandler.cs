using MediatR;
using NerdStore.Core.Messages;

namespace NerdStore.Core.Bus
{
    public class MediatoRHandler : IMediatoRHandler
    {
        private readonly IMediator _mediator;

        public MediatoRHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task PublicarEvento<T>(T evento) where T : Event
        {
            await _mediator.Publish(evento);
        }
    }
}
