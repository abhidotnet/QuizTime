using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizTime.Models
{
    public class QuestionRepository : IQuestionRepository
    {
        private List<Question> questions = new List<Question>();
        private int _nextId = 1;

        private static readonly Lazy<QuestionRepository> questionRepository = new Lazy<QuestionRepository>(() => new QuestionRepository());
        public static QuestionRepository Instance { get { return questionRepository.Value; } }

        private QuestionRepository()
        {

            //This is where I shall connect to the database.
            Add(new Question { Query = "What is the color of the sky?",  Choices = new List<Choice> { new Choice { ChoiceId = 1, IsRightChoice = true, Text = "Green" }, new Choice { ChoiceId = 2, IsRightChoice = false, Text = "Blue" } } });
            Add(new Question { Query = "What is the color of the ocean?",  Choices = new List<Choice> { new Choice { ChoiceId = 1, IsRightChoice = true, Text = "Green" }, new Choice { ChoiceId = 3, IsRightChoice = false, Text = "Blue" } } });
            Add(new Question { Query = "What is the young one of a goat?", Choices = new List<Choice> { new Choice { ChoiceId = 1, IsRightChoice = true, Text = "Kid" }, new Choice { ChoiceId = 2, IsRightChoice = false, Text = "Gosling" } } });
        }

        public IEnumerable<Question> GetAll()
        {
            return questions;
        }

        public Question Get(int id)
        {
            return questions.Find(p => p.QuestionId == id);
        }

        public Question Add(Question item)
        {
            // TODO: Implement this method
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.QuestionId = _nextId++;
            questions.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            questions.RemoveAll(p => p.QuestionId == id);
            
        }

        public bool Update(Question item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = questions.FindIndex(p => p.QuestionId == item.QuestionId);
            if (index == -1)
            {
                return false;
            }
            questions.RemoveAt(index);
            questions.Add(item);
            return true;
  
            
        }
    }
}