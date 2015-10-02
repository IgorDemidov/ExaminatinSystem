using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace ExaminationSystem.WebUI.ViewModels
{
    public class ExamSetViewModel
    {
        public ExamSetViewModel(ThemeViewModel theme, List<QuestionViewModel> questions)
        {
           Theme = theme;
           Questions = questions;
        }

        public ThemeViewModel Theme { get; private set; }

        public List<QuestionViewModel> Questions { get; private set; }
    }
}