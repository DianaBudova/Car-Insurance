namespace CarInsurance.Model;

public class Insurance
{
    public DriverInfo Driver { get; set; } = new();
    public CarInfo Car { get; set; } = new();
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    /// <exception cref="MissingFieldException"></exception>
    public bool IsEmpty()
    {
        if (string.IsNullOrEmpty(this.Driver.DriverFirstName) || this.Driver.DriverFirstName.Contains('-'))
            throw new MissingFieldException("Имя водителя");
        if (string.IsNullOrEmpty(this.Driver.DriverLastName) || this.Driver.DriverLastName.Contains('-'))
            throw new MissingFieldException("Фамилия водителя");
        if (string.IsNullOrEmpty(this.Driver.DriverPatronymic) || this.Driver.DriverPatronymic.Contains('-'))
            throw new MissingFieldException("Отчество водителя");
        if (string.IsNullOrEmpty(this.Driver.DriverPhone) || this.Driver.DriverPhone.Contains('-'))
            throw new MissingFieldException("Номер телефона водителя");
        if (string.IsNullOrEmpty(this.Car.CarBrand) || this.Car.CarBrand.Contains('-'))
            throw new MissingFieldException("Марка машины");
        if (string.IsNullOrEmpty(this.Car.CarModel) || this.Car.CarModel.Contains('-'))
            throw new MissingFieldException("Модель машины");
        if (string.IsNullOrEmpty(this.Car.CarNumber) || this.Car.CarNumber.Contains('-'))
            throw new MissingFieldException("Номер машины");
        if (DateTime.MinValue == this.StartDate)
            throw new MissingFieldException("Начало страховки");
        if (DateTime.MinValue == this.EndDate)
            throw new MissingFieldException("Конец страховки");
        return false;
    }

    public bool IsValid()
    {
        if (this.IsEmpty())
            return false;
        if (this.StartDate > this.EndDate.AddDays(1))
            throw new InvalidDataException("Дата начала страховки не должна быть больше чем конец страховки.");
        return true;
    }

    public override string ToString()
    {
        return $"{this.Driver.DriverFirstName}-" +
            $"{this.Driver.DriverLastName}-" +
            $"{this.Driver.DriverPatronymic}-" +
            $"{this.Driver.DriverPhone}-" +
            $"{this.Car.CarBrand}-" +
            $"{this.Car.CarModel}-" +
            $"{this.Car.CarNumber}-" +
            $"{this.Description}-" +
            $"{this.StartDate.ToShortDateString()}-" +
            $"{this.EndDate.ToShortDateString()}";
    }
}