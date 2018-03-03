using FiveSecondsWebApi.Domain.Models;
using FiveSecondsWebApi.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiveSecondsWebApi.Infrastructure.Repositories
{
    public class QuestionsRepository : IQuestionsRepostiory
    {
        FiveSecondsDataBaseContext _context = new FiveSecondsDataBaseContext();

        public IEnumerable<Questions> Questions => _context.Questions;

        public void Add(Questions question)
        {
            if (!string.IsNullOrEmpty(question.Question))
                _context.Questions.Add(question);

            _context.SaveChanges();
        }

        public Questions GetRandomQuestion()
        {
            var questionsCount = Questions.Count();
            var random = new Random(questionsCount);
            var randomId = random.Next() + 1;

            return Questions.FirstOrDefault(q => q.Id == randomId);
        }
    }
}
