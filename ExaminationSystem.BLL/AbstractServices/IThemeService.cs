using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.BLL.Models;

namespace ExaminationSystem.BLL.AbstractServices
{
    public interface IThemeService
    {
        List<ThemeModel> GetThemeModelsList();
        ThemeModel Get(int id);
        int GetQuestionsCount(int id);
    }
}
