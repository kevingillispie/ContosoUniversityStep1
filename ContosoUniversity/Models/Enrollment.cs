namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }   // Primary Key
        public int CourseID { get; set; }       // Foreign Key
        public int StudentID { get; set; }      // Foreign Key
        public Grade? Grade { get; set; }       // enum. The question mark after the Grade type declaration indicates that the Grade property is nullable.

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}