using GradeBook.Enums;
using System.Linq;
using System;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted) : base(name, GradeBookType.Standard, isWeighted)
        { }
    }

    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, GradeBookType.Ranked, isWeighted)
        { }

        public override char GetLetterGrade(double averageGrade)
        {
            
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked grading requires at least 5 students.");
            }

           
            var studentsWithHigherGrade = Students.Count(s => s.AverageGrade > averageGrade);

           
            var thresholdA = Students.Count * 0.2; 
            var thresholdB = Students.Count * 0.4; 
            var thresholdC = Students.Count * 0.6; 
            var thresholdD = Students.Count * 0.8; 

            
            if (studentsWithHigherGrade < thresholdA)
            {
                return 'A'; 
            }
            else if (studentsWithHigherGrade < thresholdB)
            {
                return 'B';
            }
            else if (studentsWithHigherGrade < thresholdC)
            {
                return 'C';
            }
            else if (studentsWithHigherGrade < thresholdD)
            {
                return 'D';
            }
            else
            {
                return 'F'; 
            }
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }

            base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }

            base.CalculateStudentStatistics(name);
        }
    }
}


