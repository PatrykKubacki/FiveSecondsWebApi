using AutoMapper;
using FiveSecondsWebApi.Domain.Models;
using FiveSecondsWebApi.Domain.Repositories;
using FiveSecondsWebApi.Infrastructure.Dto;
using FiveSecondsWebApi.Infrastructure.Services.Abstract;

namespace FiveSecondsWebApi.Infrastructure.Services.Implementation
{
    public class QuestionsService : IQuestionsService
    {
        readonly IQuestionsRepostiory _repository;
        readonly IMapper _mapper;

        public QuestionsService(IQuestionsRepostiory repo, IMapper mapper)
        {
            _repository = repo;
            _mapper = mapper;
        }

        public void AddQuestion(QuestionsDTO question)
        {
            var mappedQuestion = _mapper.Map<QuestionsDTO, Questions>(question);

            _repository.Add(mappedQuestion);
        }

        public QuestionsDTO GetRandomQuestion()
        {
            var question = _repository.GetRandomQuestion();

            return _mapper.Map<Questions,QuestionsDTO>(question);
        }
    }
}
