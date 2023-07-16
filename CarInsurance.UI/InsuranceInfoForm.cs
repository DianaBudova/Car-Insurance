using CarInsurance.Model;
using System.ComponentModel;

namespace CarInsurance.UI;

public partial class InsuranceInfoForm : Form
{
    public Insurance Insurance { get; } = new();

    public InsuranceInfoForm()
    {
        InitializeComponent();
    }

    public InsuranceInfoForm(Insurance? insurance)
    {
        InitializeComponent();
        if (insurance is not null)
            this.Insurance = insurance;
        this.textBoxDriverFirstName.Text = insurance!.Driver.DriverFirstName;
        this.textBoxDriverLastName.Text = insurance!.Driver.DriverLastName;
        this.textBoxDriverPatronymic.Text = insurance!.Driver.DriverPatronymic;
        this.textBoxDriverNumberPhone.Text = insurance!.Driver.DriverPhone;
        this.textBoxCarBrand.Text = insurance!.Car.CarBrand;
        this.textBoxCarModel.Text = insurance!.Car.CarModel;
        this.textBoxCarNumber.Text = insurance!.Car.CarNumber;
        this.richTextBoxDescription.Text = insurance!.Description;
        this.dateTimePickerStartDate.Value = insurance!.StartDate;
        this.dateTimePickerEndDate.Value = insurance!.EndDate;
    }

    private void InsuranceInfoForm_Load(object sender, EventArgs e) =>
        this.dateTimePickerStartDate.Value = this.dateTimePickerEndDate.Value = DateTime.Now;

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.Insurance.IsValid())
                this.DialogResult = DialogResult.OK;
        }
        catch (MissingFieldException ex)
        {
            MessageBox.Show($"Поле \"{ex.Message}\" не было введено, или введен запрещенный символ: -", "",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }
        catch (InvalidDataException ex)
        {
            MessageBox.Show(ex.Message, "",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }
        catch (InvalidEnumArgumentException ex)
        { throw ex; }
    }

    private void textBoxDriverFirstName_TextChanged(object sender, EventArgs e) =>
        this.Insurance.Driver.DriverFirstName = this.textBoxDriverFirstName.Text.Trim();

    private void textBoxDriverLastName_TextChanged(object sender, EventArgs e) =>
        this.Insurance.Driver.DriverLastName = this.textBoxDriverLastName.Text.Trim();

    private void textBoxPatronymic_TextChanged(object sender, EventArgs e) =>
        this.Insurance.Driver.DriverPatronymic = this.textBoxDriverPatronymic.Text.Trim();

    private void textBoxDriverNumberPhone_TextChanged(object sender, EventArgs e) =>
        this.Insurance.Driver.DriverPhone = this.textBoxDriverNumberPhone.Text.Trim();

    private void textBoxCarBrand_TextChanged(object sender, EventArgs e) =>
        this.Insurance.Car.CarBrand = this.textBoxCarBrand.Text.Trim();

    private void textBoxCarModel_TextChanged(object sender, EventArgs e) =>
        this.Insurance.Car.CarModel = this.textBoxCarModel.Text.Trim();

    private void textBoxCarNumber_TextChanged(object sender, EventArgs e) =>
        this.Insurance.Car.CarNumber = this.textBoxCarNumber.Text.Trim();

    private void richTextBoxDescription_TextChanged(object sender, EventArgs e) =>
        this.Insurance.Description = this.richTextBoxDescription.Text.Trim();

    private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e) =>
        this.Insurance.StartDate = this.dateTimePickerStartDate.Value;

    private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e) =>
        this.Insurance.EndDate = this.dateTimePickerEndDate.Value;
}
