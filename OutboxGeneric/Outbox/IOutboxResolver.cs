namespace OutboxGeneric.Outbox
{
    interface IOutboxResolver<T>
    {
        string GetAggregateId();
        string GetPaylod();
        void SetPayloadAndAggregateId(T obj);
    }
}
