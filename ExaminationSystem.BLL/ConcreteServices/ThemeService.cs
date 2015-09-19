using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.BLL.AbstractServices;
using ExaminationSystem.BLL.Models;
using ExaminationSystem.DAL.AbstractRepositories;
using ExaminationSystem.DAL.ConcreteRepositories;

namespace ExaminationSystem.BLL.ConcreteServices
{
    public class ThemeService: IThemeService
    {
        private IThemeRepository repository;

        //Remove after Dependency Injection
        public ThemeService()
        {
            repository = new ThemeRepository();
        }

        public ThemeService(IThemeRepository repository)
        {
            this.repository = repository;
        }
        
        public int GetCount()
        {
            return repository.GetList().Count;
        }

        public int GetThemeQuestionsCount(int themeId)
        {
            return repository.Get(themeId).Questions.Count;
        }

        public List<ThemeModel> GetThemesModelsList()
        {
            return null;
        }

        
    }
}
