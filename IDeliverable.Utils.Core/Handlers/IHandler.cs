using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IDeliverable.Utils.Core.Handlers
{
    public interface IHandler<TMessage>
    {
        Task HandleAsync(TMessage message);
    }
}

