using Newtonsoft.Json;
using OutboxGeneric.Outbox;

namespace OutboxGeneric.ArticleType
{
    class ArticleTypeChangeEvent : IOutboxResolver<ArticleTypeChangeDto>
    {
        private int articleTypeId;
        private ArticleTypeChangeDto articleTypeChangeDto;
        public string GetAggregateId()
        {
            return JsonConvert.SerializeObject(new { articleTypeId });
        }

        public string GetPaylod()
        {
            return JsonConvert.SerializeObject(articleTypeChangeDto);
        }

        public void SetPayloadAndAggregateId(ArticleTypeChangeDto obj)
        {
            articleTypeId = obj.ArticleTypeId;
            articleTypeChangeDto = obj;
        }
    }
}
