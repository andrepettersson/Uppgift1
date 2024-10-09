using Uppgift1;

public class Course : IReadInfo
    {
    public string CourseNumber { get; set; } = "";
    public string Title { get; set; } = "";
    public string LengthOfCourse { get; set; } = "";
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ClassRoomOrDistance { get; set; } = "";

    public string Read()
    {
        return $"Kursnummer: {CourseNumber}, Titel: {Title}, Längd: {LengthOfCourse}, Startdatum: {StartDate.ToShortDateString()}, Slutdatum: {EndDate.ToShortDateString()}, Typ: {ClassRoomOrDistance}";
    }
    }