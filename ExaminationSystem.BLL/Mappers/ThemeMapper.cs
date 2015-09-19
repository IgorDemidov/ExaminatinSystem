using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.BLL.Models;
using ExaminationSystem.DAL.Entities;

namespace ExaminationSystem.BLL.Mappers
{
    public static class ThemeMapper
    {
        public static ThemeModel ToModel(this Theme theme, bool includeQuestions=true)
        {
            ThemeModel model = new ThemeModel
            {
                Id = theme.Id,
                Name = theme.Name,
                Questions = null
            };

            if ((theme.Questions != null) && (includeQuestions))
            {
                
            }

            return model;
        }
    }
}
