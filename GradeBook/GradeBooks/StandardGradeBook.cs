using GradeBook.Enums;
using System.Linq;
using System;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted) : base(name, GradeBookType.Standard, isWeighted)
        {
            Type = GradeBookType.Standard;
        }
    }

    
}


