namespace Uppgift1;

public class Admin : EducationLeader, IReadInfo
{
public string? AdminInfo { get; set; }

public string GetAdminInfo()
{
    return base.Info() + $"{AdminInfo}";
}

    public new string Read()
    {
        return GetAdminInfo();
    }
 
}