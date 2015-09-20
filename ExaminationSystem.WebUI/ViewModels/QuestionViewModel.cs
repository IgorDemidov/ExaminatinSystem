using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExaminationSystem.WebUI.ViewModels
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<AnswerViewModel> Answers { get; set; }
    }
}