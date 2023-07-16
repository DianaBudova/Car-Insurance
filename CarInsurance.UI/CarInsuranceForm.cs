using CarInsurance.Model;
using System.Text;

namespace CarInsurance.UI;

public partial class CarInsuranceForm : Form
{
    private readonly InsuranceCollection insurances;
    private const string pathInsurances = "allinsurances.txt";
    private DateOnly currentDate;
    private const short toExpiryDateInDays = 2;

    public CarInsuranceForm()
    {
        InitializeComponent();
        this.insurances = new();
        this.currentDate = DateOnly.FromDateTime(DateTime.Now);
    }

    private void CarInsuranceForm_Load(object sender, EventArgs e)
    {
        try
        {
            this.insurances.CollectionChanged += UpdateListViewByCollection;
            this.insurances.ClearAndReadAllFromFile(pathInsurances);
            ShowSoonExpiredInsurances();
            ShowExpiredInsurances();
        }
        catch
        {
            MessageBox.Show("Что-то пошло не так во время считывания страховок из хранилища", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void UpdateListViewByCollection()
    {
        this.listViewInsurances.Items.Clear();
        this.insurances.RewriteAllToFile(pathInsurances);
        foreach (var insurance in insurances)
        {
            ListViewItem item = new(new[]
            {
                insurance.Driver.DriverFirstName,
                insurance.Driver.DriverLastName,
                insurance.Driver.DriverPatronymic,
                insurance.Driver.DriverPhone,
                insurance.Car.CarBrand,
                insurance.Car.CarModel,
                insurance.Car.CarNumber,
                insurance.Description,
                insurance.StartDate.ToShortDateString(),
                insurance.EndDate.ToShortDateString(),
            });
            this.listViewInsurances.Items.Add(item);
        }
    }

    private void buttonAddInsurance_Click(object sender, EventArgs e)
    {
        InsuranceInfoForm form = new();
        try
        {
            if (form.ShowDialog() == DialogResult.OK)
                this.insurances.Add(form.Insurance);
        }
        catch (InvalidOperationException)
        {
            MessageBox.Show("Что-то пошло не так", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ArgumentNullException)
        {
            MessageBox.Show("Элемент для добавления пустой", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonChangeSelectedInsurance_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.listViewInsurances.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали страховку для изменения.", "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (this.listViewInsurances.SelectedItems.Count > 1)
            {
                MessageBox.Show("Вы выбрали более чем 1 страховку для изменения.\nПожалуйста, выберите 1 страховку.", "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var selectedItem = this.listViewInsurances.SelectedItems[0];
            InsuranceInfoForm form = new(insurances[selectedItem.Index]);
            if (form.ShowDialog() == DialogResult.OK)
                this.insurances.Substitute(selectedItem.Index, form.Insurance);
        }
        catch (InvalidOperationException)
        {
            MessageBox.Show("Что-то пошло не так", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ArgumentNullException)
        {
            MessageBox.Show("Элемент для изменения пустой", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show("Индекс вышел за пределы элементов", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonDeleteSelectedInsurance_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.listViewInsurances.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали страховку для удаления.", "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (this.listViewInsurances.SelectedItems.Count > 1)
            {
                MessageBox.Show("Вы выбрали более чем 1 страховку для удаления.\nПожалуйста, выберите 1 страховку.", "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (this.listViewInsurances.SelectedItems.Count == 1)
            {
                this.insurances.RemoveAt(this.listViewInsurances.SelectedItems[0].Index);
                MessageBox.Show("Страховка была успешно удалена.", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (InvalidOperationException)
        {
            MessageBox.Show("Что-то пошло не так", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show("Индекс вышел за пределы элементов", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void timerCheckDate_Tick(object sender, EventArgs e)
    {
        if (this.currentDate.CompareTo(DateOnly.FromDateTime(DateTime.Now)) == 0)
            return;
        else
        {
            ShowSoonExpiredInsurances();
            ShowExpiredInsurances();
        }
    }

    private void ShowSoonExpiredInsurances()
    {
        var expiryInsurances = this.insurances.GetSoonExpiredInsurances(toExpiryDateInDays);
        if (expiryInsurances.Count() <= 0)
            return;
        StringBuilder response = new("Скоро истекает страховка у:\n");
        foreach (var insurance in expiryInsurances)
            response.AppendLine($"{insurance.Driver.DriverFirstName} {insurance.Driver.DriverLastName}");
        MessageBox.Show(response.ToString());
    }

    private void ShowExpiredInsurances()
    {
        var expiryInsurances = this.insurances.GetExpiredInsurances();
        if (expiryInsurances.Count() <= 0)
            return;
        StringBuilder response = new("Страховка истекла у:\n");
        foreach (var insurance in expiryInsurances)
            response.AppendLine($"{insurance.Driver.DriverFirstName} {insurance.Driver.DriverLastName}");
        MessageBox.Show(response.ToString());
    }
}