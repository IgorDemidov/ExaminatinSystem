using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.BLL.Models;

namespace ExaminationSystem.BLL.AbstractServices
{
    public interface IQuestionService
    {
        QuestionModel GetNextQuestion(int themeId, int currentId);
    }
}
