using OutboxGeneric.Outbox;

namespace OutboxGeneric
{
    class OutboxProducer<T>
    {
        public void ProduceOutboxMessage(IOutboxResolver<T> payloadResolver, T dataPayload)
        {
            payloadResolver.SetPayloadAndAggregateId(dataPayload);

            var aggregateId = payloadResolver.GetAggregateId();
            var payload = payloadResolver.GetPaylod();

            //logic to insert data to outbox table 
        }
    }
}
