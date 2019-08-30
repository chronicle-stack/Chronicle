using System;
using Microsoft.Extensions.DependencyInjection;

namespace Chronicle
{
    public interface IChronicleBuilder
    {
        IServiceCollection Services { get; }
        IChronicleBuilder UseInMemoryPersistence();
        IChronicleBuilder UseRedisPersistence();
        IChronicleBuilder UseSagaLog<TSagaLog>() where TSagaLog : ISagaLog;
        IChronicleBuilder UseSagaStateRepository<TRepository>() where TRepository : ISagaStateRepository;
        IChronicleBuilder DeleteOnCompleted();
    }
}
