using System;
using System.Collections.Generic;

namespace QuizTime.Models
{
    public class QuizAnswerRepository : IQuizAnswerRepository
    {
        private List<QuizAnswer> quizAnswers = new List<QuizAnswer>();
        private PlayerScore Score { get; set; }

        private static readonly Lazy<QuizAnswerRepository> quizAnswerRepository = new Lazy<QuizAnswerRepository>(() => new QuizAnswerRepository());
        public static QuizAnswerRepository Instance { get { return quizAnswerRepository.Value; } }

        private QuizAnswerRepository()
        {
            Add(new QuizAnswer { ChoiceId = 1, QuestionId = 1, PlayerId = 1001, RightChoiceId = 1 });
            Add(new QuizAnswer { ChoiceId = 3, QuestionId = 2, PlayerId = 1001, RightChoiceId = 2 });
        }

        public QuizAnswer Add(QuizAnswer item)
        {
            // TODO: Implement this method
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            quizAnswers.Add(item);
            return item;
        }

        public PlayerScore SendAll(IEnumerable<QuizAnswer> answers)
        {
            Score = new PlayerScore();
            foreach (QuizAnswer answer in answers)
            {
                if (answer.ChoiceId == answer.RightChoiceId)
                {
                    Score.Score += 100;
                    Score.PlayerId = answer.PlayerId;
                }
            }
            //UpdateScores(Score.PlayerId);
            return Score;
        }

        public IEnumerable<QuizAnswer> GetAll()
        {
            // TODO: Implement this method
            return quizAnswers;
        }

        private void UpdateScores(int playerId)
        {
            // TODO: Implement this method
            //Make DB call for playerId and Score.
            throw new NotImplementedException();
        }
    }
}