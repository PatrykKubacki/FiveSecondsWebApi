using FiveSecondsWebApi.Domain.Models;
using System.Collections.Generic;

namespace FiveSecondsWebApi.Domain.Repositories
{
    public interface IQuestionsRepostiory
    {
        IEnumerable<Questions> Questions { get; }

        Questions GetRandomQuestion();

        void Add(Questions questions);
    }
}
