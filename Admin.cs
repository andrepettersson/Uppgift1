namespace Uppgift1;

public class Admin : EducationLeader
{
public string? AdminInfo { get; set; }

    public string AddAdminInfo()
    {
        return base.Info() + $"{AdminInfo}";
    }
}