namespace CarInsurance.UI
{
    partial class InsuranceInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanelBackground = new TableLayoutPanel();
            buttonAdd = new Button();
            buttonCancel = new Button();
            tabControlInsuranceInfo = new TabControl();
            tabPageDriver = new TabPage();
            tableLayoutPanelDriverInfo = new TableLayoutPanel();
            textBoxDriverNumberPhone = new TextBox();
            labelDriverNumberPhone = new Label();
            textBoxDriverPatronymic = new TextBox();
            labelPatronymic = new Label();
            textBoxDriverLastName = new TextBox();
            labelLastName = new Label();
            labelFirstName = new Label();
            textBoxDriverFirstName = new TextBox();
            tabPageCar = new TabPage();
            tableLayoutPanelCarInfo = new TableLayoutPanel();
            textBoxCarNumber = new TextBox();
            textBoxCarModel = new TextBox();
            labelCarBrand = new Label();
            labelCarModel = new Label();
            labelCarNumber = new Label();
            textBoxCarBrand = new TextBox();
            tabPageOther = new TabPage();
            tableLayoutPanelOther = new TableLayoutPanel();
            dateTimePickerEndDate = new DateTimePicker();
            labelDescription = new Label();
            labelStartDate = new Label();
            label1 = new Label();
            dateTimePickerStartDate = new DateTimePicker();
            richTextBoxDescription = new RichTextBox();
            tableLayoutPanelBackground.SuspendLayout();
            tabControlInsuranceInfo.SuspendLayout();
            tabPageDriver.SuspendLayout();
            tableLayoutPanelDriverInfo.SuspendLayout();
            tabPageCar.SuspendLayout();
            tableLayoutPanelCarInfo.SuspendLayout();
            tabPageOther.SuspendLayout();
            tableLayoutPanelOther.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelBackground
            // 
            tableLayoutPanelBackground.ColumnCount = 2;
            tableLayoutPanelBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelBackground.Controls.Add(buttonAdd, 0, 1);
            tableLayoutPanelBackground.Controls.Add(buttonCancel, 1, 1);
            tableLayoutPanelBackground.Controls.Add(tabControlInsuranceInfo, 0, 0);
            tableLayoutPanelBackground.Dock = DockStyle.Fill;
            tableLayoutPanelBackground.Location = new Point(0, 0);
            tableLayoutPanelBackground.Name = "tableLayoutPanelBackground";
            tableLayoutPanelBackground.RowCount = 2;
            tableLayoutPanelBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 88F));
            tableLayoutPanelBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanelBackground.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBackground.Size = new Size(472, 483);
            tableLayoutPanelBackground.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(5, 430);
            buttonAdd.Margin = new Padding(5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(226, 48);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Dock = DockStyle.Fill;
            buttonCancel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(241, 430);
            buttonCancel.Margin = new Padding(5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(226, 48);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // tabControlInsuranceInfo
            // 
            tableLayoutPanelBackground.SetColumnSpan(tabControlInsuranceInfo, 2);
            tabControlInsuranceInfo.Controls.Add(tabPageDriver);
            tabControlInsuranceInfo.Controls.Add(tabPageCar);
            tabControlInsuranceInfo.Controls.Add(tabPageOther);
            tabControlInsuranceInfo.Dock = DockStyle.Fill;
            tabControlInsuranceInfo.Location = new Point(3, 3);
            tabControlInsuranceInfo.Name = "tabControlInsuranceInfo";
            tabControlInsuranceInfo.SelectedIndex = 0;
            tabControlInsuranceInfo.Size = new Size(466, 419);
            tabControlInsuranceInfo.TabIndex = 3;
            // 
            // tabPageDriver
            // 
            tabPageDriver.Controls.Add(tableLayoutPanelDriverInfo);
            tabPageDriver.Location = new Point(4, 29);
            tabPageDriver.Name = "tabPageDriver";
            tabPageDriver.Padding = new Padding(3);
            tabPageDriver.Size = new Size(458, 386);
            tabPageDriver.TabIndex = 0;
            tabPageDriver.Text = "Водитель";
            tabPageDriver.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelDriverInfo
            // 
            tableLayoutPanelDriverInfo.ColumnCount = 2;
            tableLayoutPanelDriverInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelDriverInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelDriverInfo.Controls.Add(textBoxDriverNumberPhone, 1, 3);
            tableLayoutPanelDriverInfo.Controls.Add(labelDriverNumberPhone, 0, 3);
            tableLayoutPanelDriverInfo.Controls.Add(textBoxDriverPatronymic, 1, 2);
            tableLayoutPanelDriverInfo.Controls.Add(labelPatronymic, 0, 2);
            tableLayoutPanelDriverInfo.Controls.Add(textBoxDriverLastName, 1, 1);
            tableLayoutPanelDriverInfo.Controls.Add(labelLastName, 0, 1);
            tableLayoutPanelDriverInfo.Controls.Add(labelFirstName, 0, 0);
            tableLayoutPanelDriverInfo.Controls.Add(textBoxDriverFirstName, 1, 0);
            tableLayoutPanelDriverInfo.Dock = DockStyle.Fill;
            tableLayoutPanelDriverInfo.Location = new Point(3, 3);
            tableLayoutPanelDriverInfo.Name = "tableLayoutPanelDriverInfo";
            tableLayoutPanelDriverInfo.RowCount = 4;
            tableLayoutPanelDriverInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelDriverInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelDriverInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelDriverInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelDriverInfo.Size = new Size(452, 380);
            tableLayoutPanelDriverInfo.TabIndex = 2;
            // 
            // textBoxDriverNumberPhone
            // 
            textBoxDriverNumberPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxDriverNumberPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDriverNumberPhone.Location = new Point(138, 317);
            textBoxDriverNumberPhone.Name = "textBoxDriverNumberPhone";
            textBoxDriverNumberPhone.Size = new Size(311, 30);
            textBoxDriverNumberPhone.TabIndex = 7;
            textBoxDriverNumberPhone.TextChanged += textBoxDriverNumberPhone_TextChanged;
            // 
            // labelDriverNumberPhone
            // 
            labelDriverNumberPhone.AutoSize = true;
            labelDriverNumberPhone.Dock = DockStyle.Fill;
            labelDriverNumberPhone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelDriverNumberPhone.Location = new Point(3, 285);
            labelDriverNumberPhone.Name = "labelDriverNumberPhone";
            labelDriverNumberPhone.Size = new Size(129, 95);
            labelDriverNumberPhone.TabIndex = 6;
            labelDriverNumberPhone.Text = "Номер тел. водителя:";
            labelDriverNumberPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxDriverPatronymic
            // 
            textBoxDriverPatronymic.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxDriverPatronymic.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDriverPatronymic.Location = new Point(138, 222);
            textBoxDriverPatronymic.Name = "textBoxDriverPatronymic";
            textBoxDriverPatronymic.Size = new Size(311, 30);
            textBoxDriverPatronymic.TabIndex = 5;
            textBoxDriverPatronymic.TextChanged += textBoxPatronymic_TextChanged;
            // 
            // labelPatronymic
            // 
            labelPatronymic.AutoSize = true;
            labelPatronymic.Dock = DockStyle.Fill;
            labelPatronymic.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelPatronymic.Location = new Point(3, 190);
            labelPatronymic.Name = "labelPatronymic";
            labelPatronymic.Size = new Size(129, 95);
            labelPatronymic.TabIndex = 4;
            labelPatronymic.Text = "Отчество водителя:";
            labelPatronymic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxDriverLastName
            // 
            textBoxDriverLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxDriverLastName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDriverLastName.Location = new Point(138, 127);
            textBoxDriverLastName.Name = "textBoxDriverLastName";
            textBoxDriverLastName.Size = new Size(311, 30);
            textBoxDriverLastName.TabIndex = 3;
            textBoxDriverLastName.TextChanged += textBoxDriverLastName_TextChanged;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Dock = DockStyle.Fill;
            labelLastName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastName.Location = new Point(3, 95);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(129, 95);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Фамилия водителя:";
            labelLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Dock = DockStyle.Fill;
            labelFirstName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstName.Location = new Point(3, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(129, 95);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "Имя водителя:";
            labelFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxDriverFirstName
            // 
            textBoxDriverFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxDriverFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDriverFirstName.Location = new Point(138, 32);
            textBoxDriverFirstName.Name = "textBoxDriverFirstName";
            textBoxDriverFirstName.Size = new Size(311, 30);
            textBoxDriverFirstName.TabIndex = 1;
            textBoxDriverFirstName.TextChanged += textBoxDriverFirstName_TextChanged;
            // 
            // tabPageCar
            // 
            tabPageCar.Controls.Add(tableLayoutPanelCarInfo);
            tabPageCar.Location = new Point(4, 29);
            tabPageCar.Name = "tabPageCar";
            tabPageCar.Padding = new Padding(3);
            tabPageCar.Size = new Size(458, 386);
            tabPageCar.TabIndex = 1;
            tabPageCar.Text = "Машина";
            tabPageCar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCarInfo
            // 
            tableLayoutPanelCarInfo.ColumnCount = 2;
            tableLayoutPanelCarInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelCarInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanelCarInfo.Controls.Add(textBoxCarNumber, 1, 2);
            tableLayoutPanelCarInfo.Controls.Add(textBoxCarModel, 1, 1);
            tableLayoutPanelCarInfo.Controls.Add(labelCarBrand, 0, 0);
            tableLayoutPanelCarInfo.Controls.Add(labelCarModel, 0, 1);
            tableLayoutPanelCarInfo.Controls.Add(labelCarNumber, 0, 2);
            tableLayoutPanelCarInfo.Controls.Add(textBoxCarBrand, 1, 0);
            tableLayoutPanelCarInfo.Dock = DockStyle.Fill;
            tableLayoutPanelCarInfo.Location = new Point(3, 3);
            tableLayoutPanelCarInfo.Name = "tableLayoutPanelCarInfo";
            tableLayoutPanelCarInfo.RowCount = 3;
            tableLayoutPanelCarInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCarInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanelCarInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelCarInfo.Size = new Size(452, 380);
            tableLayoutPanelCarInfo.TabIndex = 0;
            // 
            // textBoxCarNumber
            // 
            textBoxCarNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCarNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCarNumber.Location = new Point(161, 301);
            textBoxCarNumber.Name = "textBoxCarNumber";
            textBoxCarNumber.Size = new Size(288, 30);
            textBoxCarNumber.TabIndex = 5;
            textBoxCarNumber.TextChanged += textBoxCarNumber_TextChanged;
            // 
            // textBoxCarModel
            // 
            textBoxCarModel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCarModel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCarModel.Location = new Point(161, 174);
            textBoxCarModel.Name = "textBoxCarModel";
            textBoxCarModel.Size = new Size(288, 30);
            textBoxCarModel.TabIndex = 4;
            textBoxCarModel.TextChanged += textBoxCarModel_TextChanged;
            // 
            // labelCarBrand
            // 
            labelCarBrand.AutoSize = true;
            labelCarBrand.Dock = DockStyle.Fill;
            labelCarBrand.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCarBrand.Location = new Point(3, 0);
            labelCarBrand.Name = "labelCarBrand";
            labelCarBrand.Size = new Size(152, 126);
            labelCarBrand.TabIndex = 0;
            labelCarBrand.Text = "Марка машины:";
            labelCarBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCarModel
            // 
            labelCarModel.AutoSize = true;
            labelCarModel.Dock = DockStyle.Fill;
            labelCarModel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCarModel.Location = new Point(3, 126);
            labelCarModel.Name = "labelCarModel";
            labelCarModel.Size = new Size(152, 126);
            labelCarModel.TabIndex = 1;
            labelCarModel.Text = "Модель машины:";
            labelCarModel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCarNumber
            // 
            labelCarNumber.AutoSize = true;
            labelCarNumber.Dock = DockStyle.Fill;
            labelCarNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCarNumber.Location = new Point(3, 252);
            labelCarNumber.Name = "labelCarNumber";
            labelCarNumber.Size = new Size(152, 128);
            labelCarNumber.TabIndex = 2;
            labelCarNumber.Text = "Номер машины:";
            labelCarNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxCarBrand
            // 
            textBoxCarBrand.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCarBrand.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCarBrand.Location = new Point(161, 48);
            textBoxCarBrand.Name = "textBoxCarBrand";
            textBoxCarBrand.Size = new Size(288, 30);
            textBoxCarBrand.TabIndex = 3;
            textBoxCarBrand.TextChanged += textBoxCarBrand_TextChanged;
            // 
            // tabPageOther
            // 
            tabPageOther.Controls.Add(tableLayoutPanelOther);
            tabPageOther.Location = new Point(4, 29);
            tabPageOther.Name = "tabPageOther";
            tabPageOther.Size = new Size(458, 386);
            tabPageOther.TabIndex = 2;
            tabPageOther.Text = "Остальное";
            tabPageOther.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelOther
            // 
            tableLayoutPanelOther.ColumnCount = 2;
            tableLayoutPanelOther.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelOther.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanelOther.Controls.Add(dateTimePickerEndDate, 1, 2);
            tableLayoutPanelOther.Controls.Add(labelDescription, 0, 0);
            tableLayoutPanelOther.Controls.Add(labelStartDate, 0, 1);
            tableLayoutPanelOther.Controls.Add(label1, 0, 2);
            tableLayoutPanelOther.Controls.Add(dateTimePickerStartDate, 1, 1);
            tableLayoutPanelOther.Controls.Add(richTextBoxDescription, 1, 0);
            tableLayoutPanelOther.Dock = DockStyle.Fill;
            tableLayoutPanelOther.Location = new Point(0, 0);
            tableLayoutPanelOther.Name = "tableLayoutPanelOther";
            tableLayoutPanelOther.RowCount = 3;
            tableLayoutPanelOther.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelOther.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelOther.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelOther.Size = new Size(458, 386);
            tableLayoutPanelOther.TabIndex = 0;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerEndDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEndDate.Location = new Point(163, 306);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(292, 30);
            dateTimePickerEndDate.TabIndex = 5;
            dateTimePickerEndDate.ValueChanged += dateTimePickerEndDate_ValueChanged;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Dock = DockStyle.Fill;
            labelDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescription.Location = new Point(3, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(154, 128);
            labelDescription.TabIndex = 0;
            labelDescription.Text = "Описание:";
            labelDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Dock = DockStyle.Fill;
            labelStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelStartDate.Location = new Point(3, 128);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(154, 128);
            labelStartDate.TabIndex = 2;
            labelStartDate.Text = "Начало страховки:";
            labelStartDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 256);
            label1.Name = "label1";
            label1.Size = new Size(154, 130);
            label1.TabIndex = 3;
            label1.Text = "Конец страховки:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStartDate.Location = new Point(163, 177);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(292, 30);
            dateTimePickerStartDate.TabIndex = 4;
            dateTimePickerStartDate.ValueChanged += dateTimePickerStartDate_ValueChanged;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Dock = DockStyle.Fill;
            richTextBoxDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxDescription.Location = new Point(165, 10);
            richTextBoxDescription.Margin = new Padding(5, 10, 5, 10);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(288, 108);
            richTextBoxDescription.TabIndex = 6;
            richTextBoxDescription.Text = "";
            richTextBoxDescription.TextChanged += richTextBoxDescription_TextChanged;
            // 
            // InsuranceInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(472, 483);
            Controls.Add(tableLayoutPanelBackground);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "InsuranceInfoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление страховки";
            Load += InsuranceInfoForm_Load;
            tableLayoutPanelBackground.ResumeLayout(false);
            tabControlInsuranceInfo.ResumeLayout(false);
            tabPageDriver.ResumeLayout(false);
            tableLayoutPanelDriverInfo.ResumeLayout(false);
            tableLayoutPanelDriverInfo.PerformLayout();
            tabPageCar.ResumeLayout(false);
            tableLayoutPanelCarInfo.ResumeLayout(false);
            tableLayoutPanelCarInfo.PerformLayout();
            tabPageOther.ResumeLayout(false);
            tableLayoutPanelOther.ResumeLayout(false);
            tableLayoutPanelOther.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelBackground;
        private Button buttonAdd;
        private Button buttonCancel;
        private TabControl tabControlInsuranceInfo;
        private TabPage tabPageDriver;
        private TableLayoutPanel tableLayoutPanelDriverInfo;
        private TextBox textBoxDriverNumberPhone;
        private Label labelDriverNumberPhone;
        private TextBox textBoxDriverPatronymic;
        private Label labelPatronymic;
        private TextBox textBoxDriverLastName;
        private Label labelLastName;
        private Label labelFirstName;
        private TextBox textBoxDriverFirstName;
        private TabPage tabPageCar;
        private TabPage tabPageOther;
        private TableLayoutPanel tableLayoutPanelCarInfo;
        private Label labelCarBrand;
        private Label labelCarModel;
        private Label labelCarNumber;
        private TextBox textBoxCarBrand;
        private TextBox textBoxCarNumber;
        private TextBox textBoxCarModel;
        private TableLayoutPanel tableLayoutPanelOther;
        private Label labelDescription;
        private Label labelStartDate;
        private Label label1;
        private DateTimePicker dateTimePickerStartDate;
        private DateTimePicker dateTimePickerEndDate;
        private RichTextBox richTextBoxDescription;
    }
}