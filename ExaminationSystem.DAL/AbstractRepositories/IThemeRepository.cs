using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using ExaminationSystem.DAL.Entities;

namespace ExaminationSystem.DAL.AbstractRepositories
{
    public interface IThemeRepository: ICommonRepository<Theme>
    {
        List<Theme> GetList();
        int GetQuestionCount(int id);

    }
}
