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
using ExaminationSystem.WebUI.Filters;


namespace ExaminationSystem.WebUI.Controllers
{
    [Authorize]
    public class ExamController : Controller
    {
        //
        // GET: /Exam/

        private ThemeService themeService = new ThemeService();
        private QuestionService questionService = new QuestionService();
        private CheckService checkService = new CheckService(); 
        private StatsService statsSevice = new StatsService();

        public ActionResult Index()
        {
            List<ThemeViewModel> models = themeService.GetThemeModelsList().Select(tm => tm.ToViewModel()).ToList();
            return View(models);
        }

        public ActionResult ThemesList()
        {
            ViewBag.Title = "Themes";
            List<ThemeViewModel> themesList = themeService.GetThemeModelsList().Select(t => t.ToViewModel()).ToList();
            return PartialView("_ThemesList",themesList);
        }

        public ActionResult ThemeExamInfo(int themeId)
        {
            ThemeViewModel model = themeService.Get(themeId).ToViewModel();
            ViewBag.Count = themeService.GetQuestionsCount(themeId);
            
            return PartialView("_ThemeExamInfo",model);
        }

        public ActionResult ThemeExam(int themeId)
        {
            ThemeViewModel theme = themeService.Get(themeId).ToViewModel();
            List<QuestionModel> questionModels = questionService.GetQuestions(themeId).ToList();
            Session["clue"] = checkService.GenerateClue(themeId, questionModels);

            List<QuestionViewModel> questionViewModels = questionModels.Select(q => q.ToViewModel()).ToList();

            ExamSetViewModel examSet = new ExamSetViewModel(theme, questionViewModels);
            return PartialView("_ThemeExam", examSet);
        }

        [HttpPost]
        public ActionResult ThemeExamResult(string themeName, int[] selectedAnswers)
        {
            ExamClue clue= (ExamClue)Session["clue"];
            Session["clue"] = null;
            ExamResultModel examResult = checkService.Check(clue, selectedAnswers);
            statsSevice.SaveResult(examResult);

            return PartialView("_ThemeExamResult", examResult.ToViewModel(themeName));
        }




    }
}
