using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.DAL.Entities;

namespace ExaminationSystem.BLL.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ThemeId { get; set; }

        public ThemeModel ThemeModel { get; set; }
        public List<AnswerModel> AnswerModels { get; set; }
    }
}
