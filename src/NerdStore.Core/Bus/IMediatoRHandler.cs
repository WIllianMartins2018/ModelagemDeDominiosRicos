using NerdStore.Core.Messages;

namespace NerdStore.Core.Bus
{
    public interface IMediatoRHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}
