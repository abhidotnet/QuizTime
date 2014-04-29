using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizTime.Models
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetAll();
        Question Get(int id);
        Question Add(Question item);
        void Remove(int id);
        bool Update(Question item);
    }
}
