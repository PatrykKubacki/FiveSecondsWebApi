using FiveSecondsWebApi.Infrastructure.Dto;
using FiveSecondsWebApi.Infrastructure.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FiveSecondsWebApi.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Question")]
    public class QuestionController : Controller
    {
        readonly IQuestionsService _service;

        public QuestionController(IQuestionsService service)
        {
            _service = service;
        }

        [HttpGet]
        public string GetRandomQuestion()
        {
            var question = _service.GetRandomQuestion();

            return question.Question;
        }

        [HttpPost]
        public void Add([FromBody]string question)
        {
            _service.AddQuestion(new QuestionsDTO { Question = question } );
        }
    }
}