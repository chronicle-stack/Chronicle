using System;

namespace Chronicle.Persistence
{
    internal class SagaState : ISagaState
    {
        public SagaId Id { get; }
        public Type Type { get; }
        public SagaStates State { get; private set; }
        public object Data { get; private set; }
        public uint Revision { get; }

        private SagaState(SagaId id, Type type, SagaStates state, uint revision, object data) 
            => (Id, Type, State, Revision, Data) = (id, type, state, revision, data);

        public static ISagaState Create(SagaId id, Type type, SagaStates state, uint revision, object data = null) 
            => new SagaState(id, type, state, revision, data);

        public void Update(SagaStates state, object data = null)
        {
            State = state;
            Data = data;
        }
    }
}
