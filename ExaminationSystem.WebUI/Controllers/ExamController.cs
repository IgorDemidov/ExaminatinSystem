using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExaminationSystem.BLL.Models;
using ExaminationSystem.BLL.ConcreteServices;
using ExaminationSystem.BLL.AbstractServices;
using ExaminationSystem.WebUI.ViewModels;
using System.IO;
using System.Globalization;


namespace ExaminationSystem.WebUI.Controllers
{
    public class ExamController : Controller
    {
        //
        // GET: /Exam/

        ThemeService themeService = new ThemeService();
        QuestionService questionService = new QuestionService();


        public ActionResult Index()
        {
            List<ThemeViewModel> models = themeService.GetThemeModelsList().Select(tm => tm.ToViewModel()).ToList();
            return View(models);
        }

        public ActionResult Theme(int id)
        {
            ThemeViewModel model = themeService.Get(id).ToViewModel(themeService.GetQuestionsCount(id));
            return View(model);
        }

        public ActionResult NextQuestion(int themeId, int currentId=0)
        {
            QuestionViewModel model = questionService.GetNextQuestion(themeId,currentId).ToViewModel();

            return PartialView("_Question",model);
        }

    }
}
