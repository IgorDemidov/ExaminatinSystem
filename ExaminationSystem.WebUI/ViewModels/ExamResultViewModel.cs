using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExaminationSystem.BLL.Models;
using Microsoft.Ajax.Utilities;

namespace ExaminationSystem.WebUI.ViewModels
{
    public class ExamResultViewModel
    {
        public string ThemeName { get; set; }
        public Dictionary<int, bool> CorrectnessDictionary { get; set; }
        public string LetterGrade { get; set; }
        public double PercentGrade { get; set; }
    }
}