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

            //themeRep.AddTheme(new Theme() { Name = "ThemeName1" });
            //themeRep.AddTheme(new Theme() { Name = "ThemeName2" });
            //themeRep.AddTheme(new Theme() { Name = "ThemeName3" });
            //themeRep.AddTheme(new Theme() { Name = "ThemeName4" });

            Theme theme = new Theme()
            {
                Id = 10,
                Name = "Updated 4"
            };
            themeRep.UpdateTheme(theme);
            List<Theme> tList = themeRep.GetThemesList();
            foreach (var t in tList)
            {
                Console.WriteLine("id: {0}", t.Id);
                Console.WriteLine(">   {0}", t.Name);
            }
            Console.ReadKey();
        }
    }
}
