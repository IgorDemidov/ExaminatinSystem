using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.DAL.ConcreteRepositories;
using ExaminationSystem.DAL.Entities;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThemeRepository themeRep = new ThemeRepository();
            QuestionRepository questRep = new QuestionRepository();

            Question q = new Question()
            {
                Text = "question qqq",
                ThemeId=11,
            };
            questRep.Add(q);

            Console.ReadKey();
        }
    }
}
