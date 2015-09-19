using System.Collections.Generic;
using System.Dynamic;
using ExaminationSystem.DAL.Entities;

namespace ExaminationSystem.DAL.AbstractRepositories
{
    public interface IThemeRepository: ICommonRepository<Theme>
    {
        List<Theme> GetList();
        Theme Get(int id);
    }
}
