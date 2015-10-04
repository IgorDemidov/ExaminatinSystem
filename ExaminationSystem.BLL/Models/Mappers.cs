using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.BLL.Models;
using ExaminationSystem.DAL.Entities;

namespace ExaminationSystem.BLL.Mappers
{
    public static class Mappers
    {
        public static ThemeModel ToThemeModel(this Theme theme, bool includeQuestions=true)
        {
            ThemeModel model = new ThemeModel
            {
                Id = theme.Id,
                Name = theme.Name,
                QuestionModels = null,
                Time = theme.Time
            };

            if ((theme.Questions != null) && (includeQuestions))
            {
                model.QuestionModels = theme.Questions.Select(q => q.ToQuestionModel(false,false)).ToList();
                foreach (var qm in model.QuestionModels)
                {
                    qm.ThemeModel = model;
                }
            }

            return model;
        }

        public static QuestionModel ToQuestionModel(this Question question, bool includeTheme = true,
            bool includeAnswers = true)
        {
            QuestionModel model = new QuestionModel
            {
                Id = question.Id,
                Text = question.Text,
                ThemeModel = null,
                AnswerModels = null
            };

            if ((question.Theme != null) && (includeTheme))
            {
                model.ThemeModel = question.Theme.ToThemeModel(false);
            }

            if ((question.Answers != null) && (includeAnswers))
            {
                model.AnswerModels = question.Answers.Select(a => a.ToAnswerModel(false)).ToList();
                foreach (var am in model.AnswerModels)
                {
                    am.QuestionModel = model;
                }
            }

            return model;
        }
        public static AnswerModel ToAnswerModel(this Answer answer, bool includeQuestion=true )
        {
            AnswerModel model = new AnswerModel
            {
                Id = answer.Id,
                IsRight = answer.IsRight,
                Text = answer.Text,
                QuestionModel = null
            };

            if ((answer.Question != null) && (includeQuestion))
            {
                model.QuestionModel = answer.Question.ToQuestionModel();
            }

            return model;
        }


    }
}
