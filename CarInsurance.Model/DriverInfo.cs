namespace CarInsurance.Model;

public class DriverInfo
{
    public string DriverFirstName { get; set; } = null!;
    public string DriverLastName { get; set; } = null!;
    public string? DriverPatronymic { get; set; }
    public string DriverPhone { get; set; } = null!;
}
