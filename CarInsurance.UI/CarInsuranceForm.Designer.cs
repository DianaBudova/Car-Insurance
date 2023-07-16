namespace CarInsurance.UI
{
    partial class CarInsuranceForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarInsuranceForm));
            tableLayoutPanelBackground = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            listViewInsurances = new ListView();
            columnHeaderDriverFirstName = new ColumnHeader();
            columnHeaderDriverLastName = new ColumnHeader();
            columnHeaderDriverPatronymic = new ColumnHeader();
            columnHeaderDriverPhoneNumber = new ColumnHeader();
            columnHeaderCarBrand = new ColumnHeader();
            columnHeaderCarModel = new ColumnHeader();
            columnHeaderCarNumber = new ColumnHeader();
            columnHeaderDescription = new ColumnHeader();
            columnHeaderStartDate = new ColumnHeader();
            columnHeaderEndDate = new ColumnHeader();
            buttonAddInsurance = new Button();
            buttonDeleteSelectedInsurance = new Button();
            buttonChangeSelectedInsurance = new Button();
            timerCheckDate = new System.Windows.Forms.Timer(components);
            tableLayoutPanelBackground.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelBackground
            // 
            tableLayoutPanelBackground.ColumnCount = 3;
            tableLayoutPanelBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBackground.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanelBackground.Controls.Add(buttonAddInsurance, 0, 0);
            tableLayoutPanelBackground.Controls.Add(buttonDeleteSelectedInsurance, 1, 2);
            tableLayoutPanelBackground.Controls.Add(buttonChangeSelectedInsurance, 0, 2);
            tableLayoutPanelBackground.Dock = DockStyle.Fill;
            tableLayoutPanelBackground.Location = new Point(0, 0);
            tableLayoutPanelBackground.Name = "tableLayoutPanelBackground";
            tableLayoutPanelBackground.RowCount = 3;
            tableLayoutPanelBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanelBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelBackground.Size = new Size(1314, 626);
            tableLayoutPanelBackground.TabIndex = 0;
            // 
            // groupBox1
            // 
            tableLayoutPanelBackground.SetColumnSpan(groupBox1, 3);
            groupBox1.Controls.Add(listViewInsurances);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(5, 67);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1304, 490);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Все страховки";
            // 
            // listViewInsurances
            // 
            listViewInsurances.Columns.AddRange(new ColumnHeader[] { columnHeaderDriverFirstName, columnHeaderDriverLastName, columnHeaderDriverPatronymic, columnHeaderDriverPhoneNumber, columnHeaderCarBrand, columnHeaderCarModel, columnHeaderCarNumber, columnHeaderDescription, columnHeaderStartDate, columnHeaderEndDate });
            listViewInsurances.Dock = DockStyle.Fill;
            listViewInsurances.FullRowSelect = true;
            listViewInsurances.GridLines = true;
            listViewInsurances.Location = new Point(5, 30);
            listViewInsurances.Margin = new Padding(0);
            listViewInsurances.Name = "listViewInsurances";
            listViewInsurances.Size = new Size(1294, 455);
            listViewInsurances.TabIndex = 0;
            listViewInsurances.UseCompatibleStateImageBehavior = false;
            listViewInsurances.View = View.Details;
            // 
            // columnHeaderDriverFirstName
            // 
            columnHeaderDriverFirstName.Text = "Имя водителя";
            columnHeaderDriverFirstName.Width = 150;
            // 
            // columnHeaderDriverLastName
            // 
            columnHeaderDriverLastName.Text = "Фамилия водителя";
            columnHeaderDriverLastName.Width = 120;
            // 
            // columnHeaderDriverPatronymic
            // 
            columnHeaderDriverPatronymic.Text = "Отчество водителя";
            columnHeaderDriverPatronymic.Width = 120;
            // 
            // columnHeaderDriverPhoneNumber
            // 
            columnHeaderDriverPhoneNumber.Text = "Номер тел. водителя";
            columnHeaderDriverPhoneNumber.Width = 150;
            // 
            // columnHeaderCarBrand
            // 
            columnHeaderCarBrand.Text = "Марка машины";
            columnHeaderCarBrand.Width = 150;
            // 
            // columnHeaderCarModel
            // 
            columnHeaderCarModel.Text = "Модель машины";
            columnHeaderCarModel.Width = 120;
            // 
            // columnHeaderCarNumber
            // 
            columnHeaderCarNumber.Text = "Номер машины";
            columnHeaderCarNumber.Width = 120;
            // 
            // columnHeaderDescription
            // 
            columnHeaderDescription.Text = "Описание";
            columnHeaderDescription.Width = 120;
            // 
            // columnHeaderStartDate
            // 
            columnHeaderStartDate.Text = "Начало страховки";
            columnHeaderStartDate.Width = 120;
            // 
            // columnHeaderEndDate
            // 
            columnHeaderEndDate.Text = "Конец страховки";
            columnHeaderEndDate.Width = 120;
            // 
            // buttonAddInsurance
            // 
            buttonAddInsurance.Dock = DockStyle.Fill;
            buttonAddInsurance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddInsurance.Location = new Point(5, 5);
            buttonAddInsurance.Margin = new Padding(5);
            buttonAddInsurance.Name = "buttonAddInsurance";
            buttonAddInsurance.Size = new Size(428, 52);
            buttonAddInsurance.TabIndex = 1;
            buttonAddInsurance.Text = "Добавить страховку";
            buttonAddInsurance.UseVisualStyleBackColor = true;
            buttonAddInsurance.Click += buttonAddInsurance_Click;
            // 
            // buttonDeleteSelectedInsurance
            // 
            buttonDeleteSelectedInsurance.Dock = DockStyle.Fill;
            buttonDeleteSelectedInsurance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeleteSelectedInsurance.Location = new Point(443, 567);
            buttonDeleteSelectedInsurance.Margin = new Padding(5);
            buttonDeleteSelectedInsurance.Name = "buttonDeleteSelectedInsurance";
            buttonDeleteSelectedInsurance.Size = new Size(428, 54);
            buttonDeleteSelectedInsurance.TabIndex = 2;
            buttonDeleteSelectedInsurance.Text = "Удалить выбранную страховку";
            buttonDeleteSelectedInsurance.UseVisualStyleBackColor = true;
            buttonDeleteSelectedInsurance.Click += buttonDeleteSelectedInsurance_Click;
            // 
            // buttonChangeSelectedInsurance
            // 
            buttonChangeSelectedInsurance.Dock = DockStyle.Fill;
            buttonChangeSelectedInsurance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChangeSelectedInsurance.Location = new Point(5, 567);
            buttonChangeSelectedInsurance.Margin = new Padding(5);
            buttonChangeSelectedInsurance.Name = "buttonChangeSelectedInsurance";
            buttonChangeSelectedInsurance.Size = new Size(428, 54);
            buttonChangeSelectedInsurance.TabIndex = 3;
            buttonChangeSelectedInsurance.Text = "Изменить выбранную страховку";
            buttonChangeSelectedInsurance.UseVisualStyleBackColor = true;
            buttonChangeSelectedInsurance.Click += buttonChangeSelectedInsurance_Click;
            // 
            // timerCheckDate
            // 
            timerCheckDate.Interval = 10000;
            timerCheckDate.Tick += timerCheckDate_Tick;
            // 
            // CarInsuranceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 626);
            Controls.Add(tableLayoutPanelBackground);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CarInsuranceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Страхование машин";
            Load += CarInsuranceForm_Load;
            tableLayoutPanelBackground.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelBackground;
        private GroupBox groupBox1;
        private ListView listViewInsurances;
        private Button buttonAddInsurance;
        private Button buttonDeleteSelectedInsurance;
        private Button buttonChangeSelectedInsurance;
        private ColumnHeader columnHeaderDriverFirstName;
        private ColumnHeader columnHeaderDriverLastName;
        private ColumnHeader columnHeaderDriverPatronymic;
        private ColumnHeader columnHeaderDriverPhoneNumber;
        private ColumnHeader columnHeaderCarBrand;
        private ColumnHeader columnHeaderCarModel;
        private ColumnHeader columnHeaderCarNumber;
        private ColumnHeader columnHeaderDescription;
        private ColumnHeader columnHeaderStartDate;
        private ColumnHeader columnHeaderEndDate;
        private System.Windows.Forms.Timer timerCheckDate;
    }
}