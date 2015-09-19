using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.BLL.AbstractServices
{
    public interface IThemeService
    {
        int GetCount();
        int GetThemeQuestionsCount(int themeId);
    }
}
