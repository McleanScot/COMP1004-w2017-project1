namespace COMP1004_w2017_project1
{
    partial class DaveFurnitureStore
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
            this.EmpNameTextBox = new System.Windows.Forms.TextBox();
            this.TotalHoursTextBox = new System.Windows.Forms.TextBox();
            this.EmpIdTextBox = new System.Windows.Forms.TextBox();
            this.MonSalesTextBox = new System.Windows.Forms.TextBox();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.EmpIdLabel = new System.Windows.Forms.Label();
            this.TotalHoursLabel = new System.Windows.Forms.Label();
            this.MonSalesLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.LanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.SpanishRadioButton = new System.Windows.Forms.RadioButton();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LanguageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpNameTextBox
            // 
            this.EmpNameTextBox.Location = new System.Drawing.Point(230, 195);
            this.EmpNameTextBox.Name = "EmpNameTextBox";
            this.EmpNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.EmpNameTextBox.TabIndex = 0;
            // 
            // TotalHoursTextBox
            // 
            this.TotalHoursTextBox.BackColor = System.Drawing.Color.White;
            this.TotalHoursTextBox.Location = new System.Drawing.Point(230, 267);
            this.TotalHoursTextBox.Name = "TotalHoursTextBox";
            this.TotalHoursTextBox.Size = new System.Drawing.Size(203, 20);
            this.TotalHoursTextBox.TabIndex = 1;
            // 
            // EmpIdTextBox
            // 
            this.EmpIdTextBox.Location = new System.Drawing.Point(230, 230);
            this.EmpIdTextBox.Name = "EmpIdTextBox";
            this.EmpIdTextBox.Size = new System.Drawing.Size(203, 20);
            this.EmpIdTextBox.TabIndex = 2;
            // 
            // MonSalesTextBox
            // 
            this.MonSalesTextBox.Location = new System.Drawing.Point(230, 304);
            this.MonSalesTextBox.Name = "MonSalesTextBox";
            this.MonSalesTextBox.Size = new System.Drawing.Size(203, 20);
            this.MonSalesTextBox.TabIndex = 3;
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.Location = new System.Drawing.Point(54, 195);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(84, 13);
            this.EmpNameLabel.TabIndex = 4;
            this.EmpNameLabel.Text = "Employee Name";
            // 
            // EmpIdLabel
            // 
            this.EmpIdLabel.AutoSize = true;
            this.EmpIdLabel.Location = new System.Drawing.Point(54, 230);
            this.EmpIdLabel.Name = "EmpIdLabel";
            this.EmpIdLabel.Size = new System.Drawing.Size(67, 13);
            this.EmpIdLabel.TabIndex = 5;
            this.EmpIdLabel.Text = "Employee ID";
            // 
            // TotalHoursLabel
            // 
            this.TotalHoursLabel.AutoSize = true;
            this.TotalHoursLabel.Location = new System.Drawing.Point(54, 267);
            this.TotalHoursLabel.Name = "TotalHoursLabel";
            this.TotalHoursLabel.Size = new System.Drawing.Size(103, 13);
            this.TotalHoursLabel.TabIndex = 6;
            this.TotalHoursLabel.Text = "Total Hours Worked";
            // 
            // MonSalesLabel
            // 
            this.MonSalesLabel.AutoSize = true;
            this.MonSalesLabel.Location = new System.Drawing.Point(54, 304);
            this.MonSalesLabel.Name = "MonSalesLabel";
            this.MonSalesLabel.Size = new System.Drawing.Size(100, 13);
            this.MonSalesLabel.TabIndex = 7;
            this.MonSalesLabel.Text = "Total Monthly Sales";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(57, 426);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.Location = new System.Drawing.Point(230, 339);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(203, 20);
            this.SalesBonusTextBox.TabIndex = 12;
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(54, 342);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(66, 13);
            this.SalesBonusLabel.TabIndex = 13;
            this.SalesBonusLabel.Text = "Sales Bonus";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(358, 426);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Next";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(208, 426);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 15;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // LanguageGroupBox
            // 
            this.LanguageGroupBox.Controls.Add(this.SpanishRadioButton);
            this.LanguageGroupBox.Controls.Add(this.FrenchRadioButton);
            this.LanguageGroupBox.Controls.Add(this.EnglishRadioButton);
            this.LanguageGroupBox.Location = new System.Drawing.Point(343, 12);
            this.LanguageGroupBox.Name = "LanguageGroupBox";
            this.LanguageGroupBox.Size = new System.Drawing.Size(129, 107);
            this.LanguageGroupBox.TabIndex = 16;
            this.LanguageGroupBox.TabStop = false;
            this.LanguageGroupBox.Text = "Languages";
            // 
            // SpanishRadioButton
            // 
            this.SpanishRadioButton.AutoSize = true;
            this.SpanishRadioButton.Location = new System.Drawing.Point(7, 68);
            this.SpanishRadioButton.Name = "SpanishRadioButton";
            this.SpanishRadioButton.Size = new System.Drawing.Size(63, 17);
            this.SpanishRadioButton.TabIndex = 2;
            this.SpanishRadioButton.Text = "Spanish";
            this.SpanishRadioButton.UseVisualStyleBackColor = true;
            this.SpanishRadioButton.CheckedChanged += new System.EventHandler(this.spanishRadioButton_CheckedChanged);
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Location = new System.Drawing.Point(7, 44);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(58, 17);
            this.FrenchRadioButton.TabIndex = 1;
            this.FrenchRadioButton.Text = "French";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.CheckedChanged += new System.EventHandler(this.frenchRadioButton_CheckedChanged);
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(7, 20);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(59, 17);
            this.EnglishRadioButton.TabIndex = 0;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.englishRadioButton_CheckedChanged);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::COMP1004_w2017_project1.Properties.Resources.daves;
            this.LogoPictureBox.Location = new System.Drawing.Point(13, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(324, 122);
            this.LogoPictureBox.TabIndex = 17;
            this.LogoPictureBox.TabStop = false;
            // 
            // DaveFurnitureStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.LanguageGroupBox);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.MonSalesLabel);
            this.Controls.Add(this.TotalHoursLabel);
            this.Controls.Add(this.EmpIdLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.MonSalesTextBox);
            this.Controls.Add(this.EmpIdTextBox);
            this.Controls.Add(this.TotalHoursTextBox);
            this.Controls.Add(this.EmpNameTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "DaveFurnitureStore";
            this.Text = "Dave\'s Furniture Store";
            this.LanguageGroupBox.ResumeLayout(false);
            this.LanguageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmpNameTextBox;
        private System.Windows.Forms.TextBox TotalHoursTextBox;
        private System.Windows.Forms.TextBox EmpIdTextBox;
        private System.Windows.Forms.TextBox MonSalesTextBox;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label EmpIdLabel;
        private System.Windows.Forms.Label TotalHoursLabel;
        private System.Windows.Forms.Label MonSalesLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.GroupBox LanguageGroupBox;
        private System.Windows.Forms.RadioButton SpanishRadioButton;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
    }
}

