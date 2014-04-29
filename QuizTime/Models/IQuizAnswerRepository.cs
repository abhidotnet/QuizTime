using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime.Models
{
    public interface IQuizAnswerRepository
    {
        PlayerScore SendAll(IEnumerable<QuizAnswer> answers);
        IEnumerable<QuizAnswer> GetAll();
    }
}
