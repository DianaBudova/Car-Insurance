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
            MessageBox.Show("���-�� ����� �� ��� �� ����� ���������� ��������� �� ���������", "",
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
            MessageBox.Show("���-�� ����� �� ���", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ArgumentNullException)
        {
            MessageBox.Show("������� ��� ���������� ������", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonChangeSelectedInsurance_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.listViewInsurances.SelectedItems.Count == 0)
            {
                MessageBox.Show("�� �� ������� ��������� ��� ���������.", "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (this.listViewInsurances.SelectedItems.Count > 1)
            {
                MessageBox.Show("�� ������� ����� ��� 1 ��������� ��� ���������.\n����������, �������� 1 ���������.", "",
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
            MessageBox.Show("���-�� ����� �� ���", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ArgumentNullException)
        {
            MessageBox.Show("������� ��� ��������� ������", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show("������ ����� �� ������� ���������", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonDeleteSelectedInsurance_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.listViewInsurances.SelectedItems.Count == 0)
            {
                MessageBox.Show("�� �� ������� ��������� ��� ��������.", "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (this.listViewInsurances.SelectedItems.Count > 1)
            {
                MessageBox.Show("�� ������� ����� ��� 1 ��������� ��� ��������.\n����������, �������� 1 ���������.", "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (this.listViewInsurances.SelectedItems.Count == 1)
            {
                this.insurances.RemoveAt(this.listViewInsurances.SelectedItems[0].Index);
                MessageBox.Show("��������� ���� ������� �������.", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (InvalidOperationException)
        {
            MessageBox.Show("���-�� ����� �� ���", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show("������ ����� �� ������� ���������", "",
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
        StringBuilder response = new("����� �������� ��������� �:\n");
        foreach (var insurance in expiryInsurances)
            response.AppendLine($"{insurance.Driver.DriverFirstName} {insurance.Driver.DriverLastName}");
        MessageBox.Show(response.ToString());
    }

    private void ShowExpiredInsurances()
    {
        var expiryInsurances = this.insurances.GetExpiredInsurances();
        if (expiryInsurances.Count() <= 0)
            return;
        StringBuilder response = new("��������� ������� �:\n");
        foreach (var insurance in expiryInsurances)
            response.AppendLine($"{insurance.Driver.DriverFirstName} {insurance.Driver.DriverLastName}");
        MessageBox.Show(response.ToString());
    }
}