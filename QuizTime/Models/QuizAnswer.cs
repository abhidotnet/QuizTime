using System;
using System.Linq;

namespace QuizTime.Models
{
    public class QuizAnswer
    {
        public int ChoiceId { get; set; }
        public int QuestionId { get; set; }
        public int PlayerId { get; set; }
        public int RightChoiceId { get; set; }
    }
}