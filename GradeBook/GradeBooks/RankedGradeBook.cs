using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name) 
		
		{ 
			Type = GradeBookType.Ranked; 
		}

		public override void CalculateStatistics()
		{
			if (Students.Count < 5)
			{
				Console.Write("Ranked grading requires at least 5 students.");
				return;
			}

			base.CalculateStatistics();
		}

		public override void CalculateStudentStatistics(string name)
		{
			if (Students.Count < 5)
			{
				Console.Write("Ranked grading requires at least 5 students.");
				return;
			}

			base.CalculateStudentStatistics(name);
		}
		public override char GetLetterGrade(double averageGrade)
		{
			if (Students.Count < 5) throw new InvalidOperationException("At least 5 students needed to perform ranked grading!");
		}

		}
	}
