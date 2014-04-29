using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using QuizTime.Models;

namespace QuizTime.Controllers
{
    public class QuizAnswerController : ApiController
    {
        static readonly IQuizAnswerRepository repository = QuizAnswerRepository.Instance;

        public IEnumerable<QuizAnswer> GetAllAnswers()
        {
            return repository.GetAll();
        }

        [ActionName("ComputeScore")]
        [HttpPost]
        public PlayerScore ComputeScore(IEnumerable<QuizAnswer> answers)
        {
            return repository.SendAll(answers);
        }
    }
}
