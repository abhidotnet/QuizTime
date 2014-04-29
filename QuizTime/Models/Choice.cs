using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizTime.Models
{

    public class Choice
    {
        public int ChoiceId { get; set; }
        public string Text { get; set; }
        public bool IsRightChoice { get; set; }
    }
}