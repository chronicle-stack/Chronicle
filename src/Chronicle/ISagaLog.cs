using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chronicle
{
    public interface ISagaLog
    {
        Task<IEnumerable<ISagaLogData>> ReadAsync(SagaId sagaId, Type sagaType);
        Task WriteAsync(ISagaLogData message);
        Task DeleteAsync(SagaId sagaId, Type sagaType);
    }
}