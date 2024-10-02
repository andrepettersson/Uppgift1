using System.Reflection.Metadata.Ecma335;

namespace Uppgift1
{
    public class Teacher : PersonalInfo
    {
    public string KnowledgeInfo { get; set; } = "";
    public List<Course> Courses { get; set; } = new List<Course>();
    public DateTime EmploymentDate { get; set; } 
    public string TeacherInfo()
    {
        string courseInfo = "Lägg till en kurs";

         if (Courses.Count > 0)
        {
            courseInfo = ""; 

            foreach (var course in Courses)
            {
            if (courseInfo.Length > 0)
            {
            courseInfo += ", ";
            }
            courseInfo += course.Title;
            }
        }

        return $"{Info()}, Information om kunskap: {KnowledgeInfo}, Blev Anställd: {EmploymentDate.ToShortDateString()}, Kurser: {courseInfo}";
        }
    
    }
}




