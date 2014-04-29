using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizTime.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Query { get; set; }
        public string InputBy { get; set; }
        public DateTime InputDate { get; set; }
        public List<Choice> Choices {get; set;}
    }

}