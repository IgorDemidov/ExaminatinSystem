using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.BLL.Models;

namespace ExaminationSystem.BLL.ConcreteServices
{
    public class CheckService
    {
        public ExamClue GenerateClue(int themeid, List<QuestionModel> questions)
        {
            return new ExamClue(themeid, questions);
        }

        public ExamResultModel Check(ExamClue clue, int[] selectedAnswerIds)
        {
            Dictionary<int, bool> correctnessDictionary = new Dictionary<int, bool>();
            if (selectedAnswerIds==null)
            {
                selectedAnswerIds = new int[0];
            }

            foreach (int questionId in clue.Clue.Keys)
            {
                bool isCorrectQuestion = clue.Clue[questionId].Keys
                    .All(answerId => clue.Clue[questionId][answerId] == selectedAnswerIds.Contains(answerId));
                correctnessDictionary.Add(questionId,isCorrectQuestion);
            }

            return new ExamResultModel(clue.ThemeId,correctnessDictionary);
        }
    }
}
