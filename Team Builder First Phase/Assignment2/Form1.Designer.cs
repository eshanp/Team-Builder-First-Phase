namespace Assignment2
{
    partial class Assignment2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignment2));
            this.HeadLabel = new System.Windows.Forms.Label();
            this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.DiscountRiderTextBox = new System.Windows.Forms.TextBox();
            this.StudentRiderTextBox = new System.Windows.Forms.TextBox();
            this.FullFareTextBox = new System.Windows.Forms.TextBox();
            this.DiscountRiderLabel = new System.Windows.Forms.Label();
            this.StudentRidersLabel = new System.Windows.Forms.Label();
            this.FullFareLabel = new System.Windows.Forms.Label();
            this.UnderlineLabel = new System.Windows.Forms.Label();
            this.DriversNameTextBox = new System.Windows.Forms.TextBox();
            this.DriversNameLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CalculateGroupBox = new System.Windows.Forms.GroupBox();
            this.AvgReceiptsDisplay = new System.Windows.Forms.Label();
            this.AvgReceiptsLabel = new System.Windows.Forms.Label();
            this.TotalReceiptsDisplay = new System.Windows.Forms.Label();
            this.TotalReceiptsLabel = new System.Windows.Forms.Label();
            this.TotalPassengerDisplayLabel = new System.Windows.Forms.Label();
            this.TotalPassengerLabel = new System.Windows.Forms.Label();
            this.CalculateNameDisplay = new System.Windows.Forms.Label();
            this.CalculateNameLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.SummaryAvgReceiptDisplay = new System.Windows.Forms.Label();
            this.SummaryAvgReceiptLabel = new System.Windows.Forms.Label();
            this.SummaryTotalReceiptDisplay = new System.Windows.Forms.Label();
            this.SummaryTotalReceieptLabel = new System.Windows.Forms.Label();
            this.SummaryTotalPassengerDisplay = new System.Windows.Forms.Label();
            this.SummaryTotalPassengerLabel = new System.Windows.Forms.Label();
            this.TotalDriverLabel = new System.Windows.Forms.Label();
            this.TotalDriverDisplayLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DetailsGroupBox.SuspendLayout();
            this.CalculateGroupBox.SuspendLayout();
            this.SummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadLabel
            // 
            this.HeadLabel.AutoSize = true;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.Location = new System.Drawing.Point(214, 21);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(363, 40);
            this.HeadLabel.TabIndex = 0;
            this.HeadLabel.Text = "Daily Tours Summary";
            // 
            // DetailsGroupBox
            // 
            this.DetailsGroupBox.Controls.Add(this.DiscountRiderTextBox);
            this.DetailsGroupBox.Controls.Add(this.StudentRiderTextBox);
            this.DetailsGroupBox.Controls.Add(this.FullFareTextBox);
            this.DetailsGroupBox.Controls.Add(this.DiscountRiderLabel);
            this.DetailsGroupBox.Controls.Add(this.StudentRidersLabel);
            this.DetailsGroupBox.Controls.Add(this.FullFareLabel);
            this.DetailsGroupBox.Controls.Add(this.UnderlineLabel);
            this.DetailsGroupBox.Controls.Add(this.DriversNameTextBox);
            this.DetailsGroupBox.Controls.Add(this.DriversNameLabel);
            this.DetailsGroupBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DetailsGroupBox.Location = new System.Drawing.Point(141, 76);
            this.DetailsGroupBox.Name = "DetailsGroupBox";
            this.DetailsGroupBox.Size = new System.Drawing.Size(514, 300);
            this.DetailsGroupBox.TabIndex = 1;
            this.DetailsGroupBox.TabStop = false;
            // 
            // DiscountRiderTextBox
            // 
            this.DiscountRiderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountRiderTextBox.Location = new System.Drawing.Point(299, 224);
            this.DiscountRiderTextBox.Name = "DiscountRiderTextBox";
            this.DiscountRiderTextBox.Size = new System.Drawing.Size(82, 26);
            this.DiscountRiderTextBox.TabIndex = 7;
            this.DiscountRiderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentRiderTextBox
            // 
            this.StudentRiderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRiderTextBox.Location = new System.Drawing.Point(299, 168);
            this.StudentRiderTextBox.Name = "StudentRiderTextBox";
            this.StudentRiderTextBox.Size = new System.Drawing.Size(82, 26);
            this.StudentRiderTextBox.TabIndex = 6;
            this.StudentRiderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FullFareTextBox
            // 
            this.FullFareTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullFareTextBox.Location = new System.Drawing.Point(299, 111);
            this.FullFareTextBox.Name = "FullFareTextBox";
            this.FullFareTextBox.Size = new System.Drawing.Size(82, 26);
            this.FullFareTextBox.TabIndex = 5;
            this.FullFareTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DiscountRiderLabel
            // 
            this.DiscountRiderLabel.AutoSize = true;
            this.DiscountRiderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountRiderLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DiscountRiderLabel.Location = new System.Drawing.Point(100, 223);
            this.DiscountRiderLabel.Name = "DiscountRiderLabel";
            this.DiscountRiderLabel.Size = new System.Drawing.Size(163, 25);
            this.DiscountRiderLabel.TabIndex = 2;
            this.DiscountRiderLabel.Text = "Discount Riders";
            // 
            // StudentRidersLabel
            // 
            this.StudentRidersLabel.AutoSize = true;
            this.StudentRidersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRidersLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StudentRidersLabel.Location = new System.Drawing.Point(100, 167);
            this.StudentRidersLabel.Name = "StudentRidersLabel";
            this.StudentRidersLabel.Size = new System.Drawing.Size(154, 25);
            this.StudentRidersLabel.TabIndex = 4;
            this.StudentRidersLabel.Text = "Student Riders";
            // 
            // FullFareLabel
            // 
            this.FullFareLabel.AutoSize = true;
            this.FullFareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullFareLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FullFareLabel.Location = new System.Drawing.Point(100, 112);
            this.FullFareLabel.Name = "FullFareLabel";
            this.FullFareLabel.Size = new System.Drawing.Size(164, 25);
            this.FullFareLabel.TabIndex = 3;
            this.FullFareLabel.Text = "Full Fare Riders";
            // 
            // UnderlineLabel
            // 
            this.UnderlineLabel.BackColor = System.Drawing.SystemColors.GrayText;
            this.UnderlineLabel.Location = new System.Drawing.Point(25, 78);
            this.UnderlineLabel.Name = "UnderlineLabel";
            this.UnderlineLabel.Size = new System.Drawing.Size(409, 3);
            this.UnderlineLabel.TabIndex = 2;
            // 
            // DriversNameTextBox
            // 
            this.DriversNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriversNameTextBox.Location = new System.Drawing.Point(196, 36);
            this.DriversNameTextBox.Name = "DriversNameTextBox";
            this.DriversNameTextBox.PasswordChar = '*';
            this.DriversNameTextBox.Size = new System.Drawing.Size(215, 26);
            this.DriversNameTextBox.TabIndex = 1;
            this.DriversNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DriversNameTextBox.UseSystemPasswordChar = true;
            // 
            // DriversNameLabel
            // 
            this.DriversNameLabel.AutoSize = true;
            this.DriversNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriversNameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.DriversNameLabel.Location = new System.Drawing.Point(30, 42);
            this.DriversNameLabel.Name = "DriversNameLabel";
            this.DriversNameLabel.Size = new System.Drawing.Size(142, 25);
            this.DriversNameLabel.TabIndex = 0;
            this.DriversNameLabel.Text = "Drivers Name";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.SystemColors.Info;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(141, 406);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(124, 65);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "C&alculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.Info;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(271, 406);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(124, 65);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.SystemColors.Info;
            this.SummaryButton.Enabled = false;
            this.SummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryButton.ForeColor = System.Drawing.Color.Black;
            this.SummaryButton.Location = new System.Drawing.Point(401, 406);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(124, 65);
            this.SummaryButton.TabIndex = 4;
            this.SummaryButton.Text = "&Summary";
            this.toolTip1.SetToolTip(this.SummaryButton, "Press for company summary data");
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.Info;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(531, 406);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(124, 65);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CalculateGroupBox
            // 
            this.CalculateGroupBox.Controls.Add(this.AvgReceiptsDisplay);
            this.CalculateGroupBox.Controls.Add(this.AvgReceiptsLabel);
            this.CalculateGroupBox.Controls.Add(this.TotalReceiptsDisplay);
            this.CalculateGroupBox.Controls.Add(this.TotalReceiptsLabel);
            this.CalculateGroupBox.Controls.Add(this.TotalPassengerDisplayLabel);
            this.CalculateGroupBox.Controls.Add(this.TotalPassengerLabel);
            this.CalculateGroupBox.Controls.Add(this.CalculateNameDisplay);
            this.CalculateGroupBox.Controls.Add(this.CalculateNameLabel);
            this.CalculateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateGroupBox.Location = new System.Drawing.Point(141, 509);
            this.CalculateGroupBox.Name = "CalculateGroupBox";
            this.CalculateGroupBox.Size = new System.Drawing.Size(514, 333);
            this.CalculateGroupBox.TabIndex = 6;
            this.CalculateGroupBox.TabStop = false;
            this.CalculateGroupBox.Text = "Driver Summary Data";
            this.CalculateGroupBox.Visible = false;
            // 
            // AvgReceiptsDisplay
            // 
            this.AvgReceiptsDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AvgReceiptsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvgReceiptsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgReceiptsDisplay.Location = new System.Drawing.Point(280, 207);
            this.AvgReceiptsDisplay.Name = "AvgReceiptsDisplay";
            this.AvgReceiptsDisplay.Size = new System.Drawing.Size(104, 20);
            this.AvgReceiptsDisplay.TabIndex = 8;
            this.AvgReceiptsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvgReceiptsLabel
            // 
            this.AvgReceiptsLabel.AutoSize = true;
            this.AvgReceiptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgReceiptsLabel.Location = new System.Drawing.Point(40, 207);
            this.AvgReceiptsLabel.Name = "AvgReceiptsLabel";
            this.AvgReceiptsLabel.Size = new System.Drawing.Size(229, 22);
            this.AvgReceiptsLabel.TabIndex = 7;
            this.AvgReceiptsLabel.Text = "Avg Passenger Receipts";
            // 
            // TotalReceiptsDisplay
            // 
            this.TotalReceiptsDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalReceiptsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalReceiptsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalReceiptsDisplay.Location = new System.Drawing.Point(280, 155);
            this.TotalReceiptsDisplay.Name = "TotalReceiptsDisplay";
            this.TotalReceiptsDisplay.Size = new System.Drawing.Size(104, 20);
            this.TotalReceiptsDisplay.TabIndex = 6;
            this.TotalReceiptsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalReceiptsLabel
            // 
            this.TotalReceiptsLabel.AutoSize = true;
            this.TotalReceiptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalReceiptsLabel.Location = new System.Drawing.Point(40, 155);
            this.TotalReceiptsLabel.Name = "TotalReceiptsLabel";
            this.TotalReceiptsLabel.Size = new System.Drawing.Size(140, 22);
            this.TotalReceiptsLabel.TabIndex = 5;
            this.TotalReceiptsLabel.Text = "Total Receipts";
            // 
            // TotalPassengerDisplayLabel
            // 
            this.TotalPassengerDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalPassengerDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPassengerDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPassengerDisplayLabel.Location = new System.Drawing.Point(280, 108);
            this.TotalPassengerDisplayLabel.Name = "TotalPassengerDisplayLabel";
            this.TotalPassengerDisplayLabel.Size = new System.Drawing.Size(104, 20);
            this.TotalPassengerDisplayLabel.TabIndex = 4;
            this.TotalPassengerDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPassengerLabel
            // 
            this.TotalPassengerLabel.AutoSize = true;
            this.TotalPassengerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPassengerLabel.Location = new System.Drawing.Point(40, 109);
            this.TotalPassengerLabel.Name = "TotalPassengerLabel";
            this.TotalPassengerLabel.Size = new System.Drawing.Size(167, 22);
            this.TotalPassengerLabel.TabIndex = 3;
            this.TotalPassengerLabel.Text = "Total Passengers";
            // 
            // CalculateNameDisplay
            // 
            this.CalculateNameDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalculateNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalculateNameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateNameDisplay.Location = new System.Drawing.Point(280, 60);
            this.CalculateNameDisplay.Name = "CalculateNameDisplay";
            this.CalculateNameDisplay.Size = new System.Drawing.Size(104, 20);
            this.CalculateNameDisplay.TabIndex = 1;
            this.CalculateNameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateNameLabel
            // 
            this.CalculateNameLabel.AutoSize = true;
            this.CalculateNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateNameLabel.Location = new System.Drawing.Point(40, 60);
            this.CalculateNameLabel.Name = "CalculateNameLabel";
            this.CalculateNameLabel.Size = new System.Drawing.Size(121, 22);
            this.CalculateNameLabel.TabIndex = 0;
            this.CalculateNameLabel.Text = "Driver Name";
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.Controls.Add(this.SummaryAvgReceiptDisplay);
            this.SummaryGroupBox.Controls.Add(this.SummaryAvgReceiptLabel);
            this.SummaryGroupBox.Controls.Add(this.SummaryTotalReceiptDisplay);
            this.SummaryGroupBox.Controls.Add(this.SummaryTotalReceieptLabel);
            this.SummaryGroupBox.Controls.Add(this.SummaryTotalPassengerDisplay);
            this.SummaryGroupBox.Controls.Add(this.SummaryTotalPassengerLabel);
            this.SummaryGroupBox.Controls.Add(this.TotalDriverLabel);
            this.SummaryGroupBox.Controls.Add(this.TotalDriverDisplayLabel);
            this.SummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryGroupBox.Location = new System.Drawing.Point(141, 509);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Size = new System.Drawing.Size(514, 333);
            this.SummaryGroupBox.TabIndex = 7;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Company Summary Data";
            this.SummaryGroupBox.Visible = false;
            // 
            // SummaryAvgReceiptDisplay
            // 
            this.SummaryAvgReceiptDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SummaryAvgReceiptDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryAvgReceiptDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryAvgReceiptDisplay.Location = new System.Drawing.Point(280, 208);
            this.SummaryAvgReceiptDisplay.Name = "SummaryAvgReceiptDisplay";
            this.SummaryAvgReceiptDisplay.Size = new System.Drawing.Size(99, 20);
            this.SummaryAvgReceiptDisplay.TabIndex = 15;
            this.SummaryAvgReceiptDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SummaryAvgReceiptLabel
            // 
            this.SummaryAvgReceiptLabel.AutoSize = true;
            this.SummaryAvgReceiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryAvgReceiptLabel.Location = new System.Drawing.Point(34, 208);
            this.SummaryAvgReceiptLabel.Name = "SummaryAvgReceiptLabel";
            this.SummaryAvgReceiptLabel.Size = new System.Drawing.Size(219, 22);
            this.SummaryAvgReceiptLabel.TabIndex = 14;
            this.SummaryAvgReceiptLabel.Text = "Avg Passenger Receipt";
            // 
            // SummaryTotalReceiptDisplay
            // 
            this.SummaryTotalReceiptDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SummaryTotalReceiptDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryTotalReceiptDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTotalReceiptDisplay.Location = new System.Drawing.Point(280, 161);
            this.SummaryTotalReceiptDisplay.Name = "SummaryTotalReceiptDisplay";
            this.SummaryTotalReceiptDisplay.Size = new System.Drawing.Size(100, 23);
            this.SummaryTotalReceiptDisplay.TabIndex = 13;
            this.SummaryTotalReceiptDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SummaryTotalReceieptLabel
            // 
            this.SummaryTotalReceieptLabel.AutoSize = true;
            this.SummaryTotalReceieptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTotalReceieptLabel.Location = new System.Drawing.Point(34, 162);
            this.SummaryTotalReceieptLabel.Name = "SummaryTotalReceieptLabel";
            this.SummaryTotalReceieptLabel.Size = new System.Drawing.Size(130, 22);
            this.SummaryTotalReceieptLabel.TabIndex = 12;
            this.SummaryTotalReceieptLabel.Text = "Total Receipt";
            // 
            // SummaryTotalPassengerDisplay
            // 
            this.SummaryTotalPassengerDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SummaryTotalPassengerDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryTotalPassengerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTotalPassengerDisplay.Location = new System.Drawing.Point(280, 108);
            this.SummaryTotalPassengerDisplay.Name = "SummaryTotalPassengerDisplay";
            this.SummaryTotalPassengerDisplay.Size = new System.Drawing.Size(101, 20);
            this.SummaryTotalPassengerDisplay.TabIndex = 11;
            this.SummaryTotalPassengerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SummaryTotalPassengerLabel
            // 
            this.SummaryTotalPassengerLabel.AutoSize = true;
            this.SummaryTotalPassengerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTotalPassengerLabel.Location = new System.Drawing.Point(33, 109);
            this.SummaryTotalPassengerLabel.Name = "SummaryTotalPassengerLabel";
            this.SummaryTotalPassengerLabel.Size = new System.Drawing.Size(157, 22);
            this.SummaryTotalPassengerLabel.TabIndex = 10;
            this.SummaryTotalPassengerLabel.Text = "Total Passenger";
            // 
            // TotalDriverLabel
            // 
            this.TotalDriverLabel.AutoSize = true;
            this.TotalDriverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDriverLabel.Location = new System.Drawing.Point(33, 64);
            this.TotalDriverLabel.Name = "TotalDriverLabel";
            this.TotalDriverLabel.Size = new System.Drawing.Size(126, 22);
            this.TotalDriverLabel.TabIndex = 8;
            this.TotalDriverLabel.Text = "Total Drivers";
            // 
            // TotalDriverDisplayLabel
            // 
            this.TotalDriverDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalDriverDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalDriverDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDriverDisplayLabel.Location = new System.Drawing.Point(280, 59);
            this.TotalDriverDisplayLabel.Name = "TotalDriverDisplayLabel";
            this.TotalDriverDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalDriverDisplayLabel.TabIndex = 9;
            this.TotalDriverDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Assignment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 943);
            this.Controls.Add(this.SummaryGroupBox);
            this.Controls.Add(this.CalculateGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.DetailsGroupBox);
            this.Controls.Add(this.HeadLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Assignment2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mild Atlantic Bus Tours";
            this.DetailsGroupBox.ResumeLayout(false);
            this.DetailsGroupBox.PerformLayout();
            this.CalculateGroupBox.ResumeLayout(false);
            this.CalculateGroupBox.PerformLayout();
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.GroupBox DetailsGroupBox;
        private System.Windows.Forms.TextBox DiscountRiderTextBox;
        private System.Windows.Forms.TextBox StudentRiderTextBox;
        private System.Windows.Forms.TextBox FullFareTextBox;
        private System.Windows.Forms.Label DiscountRiderLabel;
        private System.Windows.Forms.Label StudentRidersLabel;
        private System.Windows.Forms.Label FullFareLabel;
        private System.Windows.Forms.Label UnderlineLabel;
        private System.Windows.Forms.TextBox DriversNameTextBox;
        private System.Windows.Forms.Label DriversNameLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox CalculateGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label AvgReceiptsLabel;
        private System.Windows.Forms.Label TotalReceiptsDisplay;
        private System.Windows.Forms.Label TotalReceiptsLabel;
        private System.Windows.Forms.Label TotalPassengerDisplayLabel;
        private System.Windows.Forms.Label TotalPassengerLabel;
        private System.Windows.Forms.Label CalculateNameDisplay;
        private System.Windows.Forms.Label CalculateNameLabel;
        private System.Windows.Forms.Label AvgReceiptsDisplay;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.Label TotalDriverLabel;
        private System.Windows.Forms.Label TotalDriverDisplayLabel;
        private System.Windows.Forms.Label SummaryTotalPassengerDisplay;
        private System.Windows.Forms.Label SummaryTotalPassengerLabel;
        private System.Windows.Forms.Label SummaryTotalReceiptDisplay;
        private System.Windows.Forms.Label SummaryTotalReceieptLabel;
        private System.Windows.Forms.Label SummaryAvgReceiptDisplay;
        private System.Windows.Forms.Label SummaryAvgReceiptLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

