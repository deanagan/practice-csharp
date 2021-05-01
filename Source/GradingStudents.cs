using System;
using System.Collections.Generic;
using System.Linq;

namespace lib
{
    public class GradingStudents
    {
        public GradingStudents()
        {

        }

        public static List<int> GetGrading(List<int> grades)
        {
            var result = grades.Select(grade => {
                if (grade < 38) {
                    return grade;
                }
                var mod = 5 - (grade % 5);

                return mod >= 3 ? grade : grade + mod;
            });


            return result.ToList();
        }
    }
}