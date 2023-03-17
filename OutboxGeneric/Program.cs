using OutboxGeneric.ArticleType;
using System;
using System.Text.Json.Serialization;

namespace OutboxGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var articleTypeChangeDto = new ArticleTypeChangeDto() { ArticleTypeId = 1, Name = "Original Research"};

            var articleTypeChangeOuboxResolver = new OutboxProducer<ArticleTypeChangeDto>();

            articleTypeChangeOuboxResolver.ProduceOutboxMessage(new ArticleTypeChangeEvent(), articleTypeChangeDto);
        }

    }
}
