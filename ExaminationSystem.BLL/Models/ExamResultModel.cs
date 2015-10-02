using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExaminationSystem.BLL.Models
{
    public class ExamResultModel
    {
        private readonly double percentGrade;
        private readonly string letterGrade;

        public ExamResultModel(int themeId, Dictionary<int, bool> questionsCorrectnessDictionary)
        {
            ThemeId = themeId;
            QuestionsCorrectnessDictionary = questionsCorrectnessDictionary;
            percentGrade = CalcPercentGrade(questionsCorrectnessDictionary);
            letterGrade = GradingScale.Grade(percentGrade);
        }

        public int ThemeId { get; private set; }
        public Dictionary<int, bool> QuestionsCorrectnessDictionary { get; private set; }

        public double PercentGrade
        {
            get { return percentGrade; }
        }

        public string LetterGrade
        {
            get { return letterGrade; }
        }

        private double CalcPercentGrade(Dictionary<int, bool> dict)
        {
            int trueCount = dict.Values.Count(v => v == true);
            int count = dict.Values.Count();
            return trueCount*100/count;
        }
    }
}
