namespace Mniak.AspNetCore.Http.Abstractions
{
    public interface IServiceFromRequest<T>
    {
        T Service { get; }
    }
}
