using System;
using System.Linq;

namespace QuizTime.Models
{

    public class Choice
    {
        public int ChoiceId { get; set; }
        public string Text { get; set; }
        public bool IsRightChoice { get; set; }
    }
}