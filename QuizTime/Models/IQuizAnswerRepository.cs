using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizTime.Models
{
    public interface IQuizAnswerRepository
    {
        PlayerScore SendAll(IEnumerable<QuizAnswer> answers);
        IEnumerable<QuizAnswer> GetAll();
    }
}
