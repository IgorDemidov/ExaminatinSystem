using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.BLL.AbstractServices;
using ExaminationSystem.BLL.Models;
using ExaminationSystem.BLL.Mappers;
using ExaminationSystem.DAL.AbstractRepositories;
using ExaminationSystem.DAL.ConcreteRepositories;


namespace ExaminationSystem.BLL.ConcreteServices
{
    public class QuestionService : IQuestionService
    {
        private QuestionRepository repository = new QuestionRepository();


        public List<QuestionModel> GetQuestions(int themeId)
        {
            return repository.GetQuestions(themeId).Select(q => q.ToQuestionModel()).ToList();
        }

        
    }
}
