using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.BLL.Models
{
    internal static class GradingScale
    {
        public static string Grade(double percentGrade, bool symbolic = true)
        {
            if (percentGrade < 60)
                return "F";
            return Letter(percentGrade, symbolic, "D", "C", "B", "A");
        }

        private static string Letter(double percentGrade, bool symbolic = true, params string[] letters)
        {
            string result = null;
            for (int i = 0, j = 70, b1 = 63, b2 = 67; i < letters.Length; i++, j += 10, b1 += 10, b2 += 10)
            {
                if (percentGrade < j)
                {
                    result = Symbolization(symbolic, percentGrade, letters[i], 93, 97);
                    break;
                }
            }
            return result;
        }

        private static string Symbolization(bool symbolic, double pgrade, string letter, int bound1, int bound2)
        {
            if (symbolic)
            {
                if (pgrade < bound1)
                    return letter + "-";
                if (pgrade >= bound2)
                    return letter + "+";
            }
            return letter;
        }
    }
}
