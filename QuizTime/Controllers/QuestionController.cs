using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuizTime.Models;

namespace QuizTime.Controllers
{
    public class QuestionController : ApiController
    {
        static readonly IQuestionRepository repository =  QuestionRepository.Instance;

        public IEnumerable<Question> GetAllQuestions()
        {
            return repository.GetAll();
        }

        public Question GetQuestion(int id)
        {
            Question item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        public HttpResponseMessage PostQuestion(Question item)
        {
            item = repository.Add(item);
            var response = Request.CreateResponse<Question>(HttpStatusCode.Created, item);
            string uri = Url.Link("DefaultApi", new { id = item.QuestionId });
            response.Headers.Location = new Uri(uri);

            return response;
        }

        public void PutQuestion(int id, Question question)
        {
            question.QuestionId = id;
            if (!repository.Update(question))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public void DeleteQuestion(int id)
        {
            Question item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repository.Remove(id);
        }
    }
}
