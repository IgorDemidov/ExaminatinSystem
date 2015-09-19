using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Linq.Expressions;
using ExaminationSystem.DAL.AbstractRepositories;
using ExaminationSystem.DAL.Entities;

namespace ExaminationSystem.DAL.ConcreteRepositories
{
    public class ThemeRepository: CommonRepositoryAbstract<Theme>, IThemeRepository
    {
        public List<Theme> GetList()
        {
            List<Theme> tList;
            using (var context = new ExamContext())
            {
                tList = context.Themes.ToList();
            }
            return tList;
        }

        public Theme Get(int id)
        {
            Theme result;
            using (var context = new ExamContext())
            {
                result = context.Themes.Include(t=>t.Questions).FirstOrDefault(t=>t.Id==id);
            }
            return result;
        }
    }
}
