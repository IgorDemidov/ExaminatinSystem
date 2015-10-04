using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExaminationSystem.BLL.Models;


namespace ExaminationSystem.WebUI.ViewModels
{
    public static class UIMappers
    {
        public static ThemeViewModel ToViewModel(this ThemeModel model)
        {
            ThemeViewModel viewModel = new ThemeViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Time = model.Time
            };

            return viewModel;
        }

        public static QuestionViewModel ToViewModel(this QuestionModel model)
        {
            QuestionViewModel viewModel = new QuestionViewModel
            {
                Id = model.Id,
                Text = model.Text,
                Answers = model.AnswerModels.Select(a=>a.ToViewModel()).ToList()
            };
            return viewModel;
        }

        public static AnswerViewModel ToViewModel(this AnswerModel model)
        {
            AnswerViewModel viewModel = new AnswerViewModel
            {
                Id = model.Id,
                Text = model.Text
            };
            return viewModel;
        }

        public static ExamResultViewModel ToViewModel(this ExamResultModel model, string themeName)
        {
            ExamResultViewModel viewModel = new ExamResultViewModel
            {
                ThemeName = themeName,
                CorrectnessDictionary = model.QuestionsCorrectnessDictionary,
                LetterGrade = model.LetterGrade,
                PercentGrade = model.PercentGrade
            };
            return viewModel;
        }
    }
}