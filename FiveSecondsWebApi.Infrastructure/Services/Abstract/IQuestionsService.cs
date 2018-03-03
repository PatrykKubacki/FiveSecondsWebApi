using FiveSecondsWebApi.Infrastructure.Dto;

namespace FiveSecondsWebApi.Infrastructure.Services.Abstract
{
    public interface IQuestionsService : IService
    {
        QuestionsDTO GetRandomQuestion();

        void AddQuestion(QuestionsDTO question);
    }
}
