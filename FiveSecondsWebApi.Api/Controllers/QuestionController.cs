using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveSecondsWebApi.Infrastructure.Services.Abstract;
using Microsoft.AspNetCore.Http;
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
        [Route("api/randomQuestion")]
        public IActionResult GetRandomQuestion()
        {
            var question = _service.GetRandomQuestion();

            return Ok(question);
        }
    }
}