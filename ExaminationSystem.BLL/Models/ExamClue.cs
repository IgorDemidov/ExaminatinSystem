using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.BLL.Models
{
    public class ExamClue
    {
        private Dictionary<int, Dictionary<int, bool>> clue = new Dictionary<int, Dictionary<int, bool>>();
        
        public ExamClue(int themeId, List<QuestionModel> questions)
        {
            ThemeId = themeId;
            foreach (var q in questions)
            {
                Dictionary<int, bool> tempAnswers = q.AnswerModels.ToDictionary(a => a.Id, a => a.IsRight);
                clue.Add(q.Id, tempAnswers);
            }
        }

        public Dictionary<int, Dictionary<int, bool>> Clue
        {
            get { return clue; }
        }
        public int ThemeId { get; private set; }


    }
}
