using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession5_Form.Models
{
    public class QuestionModel
    {
        private List<Question> questions;
        public QuestionModel()
        {
            questions = new List<Question>{
                new Question
                {
                    Id = 1,
                    Content = "Q1",
                    Answers = new List<Answer>
                    {
                        new Answer{Id=1,Content="answer1",Correct=false},
                        new Answer{Id=2,Content="answer2",Correct=true},
                        new Answer{Id=3,Content="answer3",Correct=false},
                    }
                },
                     new Question
                {
                    Id = 2,
                    Content = "Q2",
                    Answers = new List<Answer>
                    {
                        new Answer{Id=4,Content="answer4",Correct=false},
                        new Answer{Id=5,Content="answer5",Correct=false},
                        new Answer{Id=6,Content="answer6",Correct=true},
                    }
                },
                          new Question
                {
                    Id = 3,
                    Content = "Q3",
                    Answers = new List<Answer>
                    {
                        new Answer{Id=7,Content="answer7",Correct=false},
                        new Answer{Id=8,Content="answer8",Correct=true},
                        new Answer{Id=9,Content="answer9",Correct=false},
                    }
                },
            };
        }

        public List<Question> FindAll()
        {
            return questions;
        }

        public Question Find(int id)
        {
            return questions.SingleOrDefault(q => q.Id == id);
        }

        public bool CheckCorrect(int questionId, int answerId)
        {
            return Find(questionId).Answers.SingleOrDefault(p => p.Id == answerId).Correct;
        }

    }
}
