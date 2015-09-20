using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.DAL.Entities;

namespace ExaminationSystem.DAL.AbstractRepositories
{
    public interface IQuestionRepository: ICommonRepository<Question>
    {
        Question GetNextQuestion(int themeId, int currentId);
    }
}
