using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.BLL.AbstractServices;
using ExaminationSystem.BLL.Mappers;
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

        public List<ThemeModel> GetThemeModelsList()
        {
            return repository.GetList().Select(t => t.ToThemeModel()).ToList();
        }

        public ThemeModel Get(int id)
        {
            return repository.Get(id).ToThemeModel();
        }

        public int GetQuestionsCount(int id)
        {
            return repository.GetQuestionCount(id);
        }
    }
}
