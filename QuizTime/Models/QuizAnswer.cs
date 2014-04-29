using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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