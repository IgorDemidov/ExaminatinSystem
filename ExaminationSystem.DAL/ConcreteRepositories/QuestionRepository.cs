using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.DAL.AbstractRepositories;
using ExaminationSystem.DAL.Entities;

namespace ExaminationSystem.DAL.ConcreteRepositories
{
    public class QuestionRepository: CommonRepository<Question>
    {
        public List<Question> GetQuestions(int themeId)
        {
            List<Question> questions;
            using (var context = new ExamContext())
            {
                questions = context.Questions.Include(q => q.Answers).Where(q => q.ThemeId == themeId).ToList();
            }
            return questions;
        }


        //not use
        public override Question Get(int id)
        {
            Question question;
            using (var context = new ExamContext())
            {
                question = context.Questions.Include(q => q.Theme).Include(q => q.Answers).FirstOrDefault(q => q.Id == id);
            }
            return question;
        }

        public Question GetNextQuestion(int themeId, int currentId)
        {
            Question result;

            using (var context = new ExamContext())
            {
                result = context.Questions.Include(q=>q.Answers).Where(q => q.ThemeId == themeId).OrderBy(q => q.Id).FirstOrDefault(q => q.Id > currentId);
            }

            return result;
        }
    }
}
