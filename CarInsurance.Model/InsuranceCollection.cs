using System.Collections;
using System.Text;

namespace CarInsurance.Model;

public class InsuranceCollection : IEnumerable<Insurance>
{
    private readonly List<Insurance> insurances;
    public event Action? CollectionChanged;

    public InsuranceCollection() =>
        this.insurances = new();

    /// <exception cref="ArgumentNullException"></exception>
    public void Add(Insurance? insurance)
    {
        if (insurance is null)
            throw new ArgumentNullException(nameof(insurance));
        this.insurances.Add(insurance);
        CollectionChanged?.Invoke();
    }

    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public void Substitute(int index, Insurance? insurance)
    {
        if (insurance is null)
            throw new ArgumentNullException(nameof(insurance));
        if (index < 0 || index >= insurances.Count)
            throw new ArgumentOutOfRangeException(nameof(index));
        this.insurances[index] = insurance;
        CollectionChanged?.Invoke();
    }

    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public void RemoveAt(int index)
    {
        if (index < 0 || index >= insurances.Count)
            throw new ArgumentOutOfRangeException(nameof(index));
        this.insurances.RemoveAt(index);
        CollectionChanged?.Invoke();
    }

    /// <exception cref="Exception"></exception>
    public void ClearAndReadAllFromFile(string path)
    {
        try
        {
            this.insurances.Clear();
            if (!File.Exists(path))
                return;
            string[] lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                string[] values = line.Split('-');
                string[] startDate = values[8].Split('.');
                string[] endDate = values[9].Split('.');
                Insurance readInsurance = new()
                {
                    Driver = new()
                    {
                        DriverFirstName = values[0],
                        DriverLastName = values[1],
                        DriverPatronymic = values[2],
                        DriverPhone = values[3],
                    },
                    Car = new()
                    {
                        CarBrand = values[4],
                        CarModel = values[5],
                        CarNumber = values[6],
                    },
                    Description = values[7],
                    StartDate = new DateTime(int.Parse(startDate[2]), int.Parse(startDate[1]), int.Parse(startDate[0])),
                    EndDate = new DateTime(int.Parse(endDate[2]), int.Parse(endDate[1]), int.Parse(endDate[0])),
                };
                this.insurances.Add(readInsurance);
            }
            CollectionChanged?.Invoke();
        }
        catch (Exception ex)
        { throw ex; }
    }

    /// <exception cref="Exception"></exception>
    public void RewriteAllToFile(string path)
    {
        try
        {
            StringBuilder text = new();
            foreach (var insurance in this.insurances)
                text.Append($"{insurance}\n");
            File.WriteAllText(path, text.ToString());
            File.WriteAllText("all.txt", text.ToString());
        }
        catch (Exception ex)
        { throw ex; }
    }

    public IEnumerable<Insurance> GetSoonExpiredInsurances(int daysToExpiring)
    {
        List<Insurance> result = new();
        foreach (var insurance in insurances)
        {
            if (insurance.EndDate.AddDays(-daysToExpiring + 1) >= DateTime.Now.Date &&
                insurance.EndDate.AddDays(-daysToExpiring + 2) <= DateTime.Now.Date.AddDays(daysToExpiring))
                result.Add(insurance);
        }
        return result;
    }

    public IEnumerable<Insurance> GetExpiredInsurances() =>
        this.insurances.Where(i => i.EndDate <= DateTime.Now.Date).ToList();

    public Insurance this[int index]
    {
        get { return insurances[index]; }
        set
        {
            try
            { insurances.Insert(index, value); }
            catch (ArgumentOutOfRangeException ex)
            { throw ex; }
        }
    }

    public IEnumerator<Insurance> GetEnumerator() =>
        this.insurances.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() =>
        this.GetEnumerator();
}
