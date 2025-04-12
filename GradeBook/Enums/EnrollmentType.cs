namespace GradeBooks.Enums
{
    public enum GradeBookType
    {
        Standard,
        Ranked,
        ESNU,
        OneToFour,
        SixPoint
    }
    public class BaseGradeBook
    {
        
        public GradeBookType Type { get; set; }

        public BaseGradeBook(GradeBookType type)
        {
            Type = type;
        }

    }
}
