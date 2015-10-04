using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.DAL.Entities;

namespace ExaminationSystem.BLL.Models
{
    public class ThemeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }

        public List<QuestionModel> QuestionModels { get; set; }
    }
}
