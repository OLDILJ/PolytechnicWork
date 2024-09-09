using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    public class courseAssessmentMark
    {
        private Course course;
        private List<int> assessmentMarks;

        public Course Course { get => course; set => course = value; }
        public List<int> AssessmentMarks { get => assessmentMarks; set => assessmentMarks = value; }


        public static void CourseAssessmentMark(Course Course, List<int> AssessmentMarks)
        {

        }
        public static List<int> GetAllMarks(List<int> AssessmentMarks)
        {
            List<int> AllMarks = new List<int>(AssessmentMarks);
            Console.WriteLine(AllMarks.Count);

            return AllMarks;
        }
        public static List<string> GetAllGrades(List<int> AssessmentMarks)
        {
            
            List<string> GradesList = new List<string>(AssessmentMarks.Count);
            for (int i = 0; i > AssessmentMarks.Count; i++)
            {
                int CurMark = AssessmentMarks[i];
                switch (CurMark)
                {
                    case int x when (x>90):
                        GradesList[i] = "A+";
                        break;
                    case int x when (x > 84 && x < 90):
                        GradesList[i] = "A";
                        break;
                    case int x when (x > 79 && x < 85):
                        GradesList[i] = "A-";
                        break;
                    case int x when (x > 74 && x < 80):
                        GradesList[i] = "B+";
                        break;
                    case int x when (x > 69 && x < 75):
                        GradesList[i] = "B";
                        break;
                    case int x when (x > 64 && x < 70):
                        GradesList[i] = "B-";
                        break;
                    case int x when (x > 59 && x < 65):
                        GradesList[i] = "C+";
                        break;
                    case int x when (x > 54 && x < 60):
                        GradesList[i] = "C";
                        break;
                    case int x when (x > 49 && x < 55):
                        GradesList[i] = "C-";
                        break;
                    case int x when (x > 39 && x < 50):
                        GradesList[i] = "D";
                        break;
                    case int x when (x < 39):
                        GradesList[i] = "E";
                        break;
                    default:
                        break;
                }
            }
            foreach (var item in GradesList)
            {
                Console.WriteLine(item);
            }
            return GradesList;
        }
        public static List<int> GetHighestMarks(List<int> AssessmentMarks)
        {
            int Max = AssessmentMarks.Max();
            List<int> HighestMarks = new List<int>();
            foreach (var item in AssessmentMarks)
            {
                if (item == Max)
                {
                    HighestMarks.Add(item);
                }
            }
            
            return HighestMarks;

        }
        public static List<int> GetLowestMarks(List<int> AssessmentMarks)
        {
            int Low = AssessmentMarks.Min();
            List<int> LowestMarks = new List<int>();
            foreach (var item in AssessmentMarks)
            {
                if (item == Low)
                {
                    LowestMarks.Add(item);
                }
            }

            return LowestMarks;
        }
        public static List<int> GetFailMarks(List<int> AssessmentMarks)
        {
            int Threshold = 40;
            List<int> FailMarks = new List<int>();
            foreach (var item in AssessmentMarks)
            {
                if (item < Threshold)
                {
                    FailMarks.Add(item);
                }
            }
            
            return FailMarks;
        }
        public static Double GetAverageMark(List<int> AssessmentMarks)
        {
            AssessmentMarks.Average();
            double AverageMark = 0;
            return AverageMark;
        }
        public static string GetAverageGrade()
        {
            double AverageMark = 0;
            string AverageGrade = "";
            return AverageGrade;
        }
    }
}
