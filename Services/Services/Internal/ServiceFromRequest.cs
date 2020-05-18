using Microsoft.AspNetCore.Http;
using Mniak.AspNetCore.Http.Abstractions;
using System;

namespace Mniak.AspNetCore.Http.Internal
{
    internal class ServiceFromRequest<T> : IServiceFromRequest<T>
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public ServiceFromRequest(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public T Service => (T)httpContextAccessor?.HttpContext?.RequestServices?.GetService(typeof(T));
    }
}
