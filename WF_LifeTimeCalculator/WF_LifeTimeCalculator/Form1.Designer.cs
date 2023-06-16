namespace WF_LifeTimeCalculator
{
    partial class Form1
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
            buttonCalc = new Button();
            labelDays = new Label();
            labelHours = new Label();
            labelSeconds = new Label();
            labelMinutes = new Label();
            maskedTextBoxInput = new MaskedTextBox();
            labelDateOfBirth = new Label();
            labelTimeAliveText = new Label();
            labelTitleText = new Label();
            labelYears = new Label();
            SuspendLayout();
            // 
            // buttonCalc
            // 
            buttonCalc.Location = new Point(668, 15);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(126, 29);
            buttonCalc.TabIndex = 0;
            buttonCalc.Text = "Calculate";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // labelDays
            // 
            labelDays.AutoSize = true;
            labelDays.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDays.Location = new Point(152, 124);
            labelDays.Name = "labelDays";
            labelDays.Size = new Size(0, 23);
            labelDays.TabIndex = 1;
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelHours.Location = new Point(320, 124);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(0, 23);
            labelHours.TabIndex = 2;
            // 
            // labelSeconds
            // 
            labelSeconds.AutoSize = true;
            labelSeconds.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeconds.Location = new Point(643, 124);
            labelSeconds.Name = "labelSeconds";
            labelSeconds.Size = new Size(0, 23);
            labelSeconds.TabIndex = 4;
            // 
            // labelMinutes
            // 
            labelMinutes.AutoSize = true;
            labelMinutes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelMinutes.Location = new Point(475, 124);
            labelMinutes.Name = "labelMinutes";
            labelMinutes.Size = new Size(0, 23);
            labelMinutes.TabIndex = 3;
            // 
            // maskedTextBoxInput
            // 
            maskedTextBoxInput.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxInput.Location = new Point(296, 14);
            maskedTextBoxInput.Mask = "00/00/0000";
            maskedTextBoxInput.Name = "maskedTextBoxInput";
            maskedTextBoxInput.Size = new Size(346, 30);
            maskedTextBoxInput.TabIndex = 5;
            maskedTextBoxInput.TextAlign = HorizontalAlignment.Right;
            maskedTextBoxInput.ValidatingType = typeof(DateTime);
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(296, 19);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(94, 20);
            labelDateOfBirth.TabIndex = 6;
            labelDateOfBirth.Text = "Date of Birth";
            // 
            // labelTimeAliveText
            // 
            labelTimeAliveText.AutoSize = true;
            labelTimeAliveText.Location = new Point(12, 91);
            labelTimeAliveText.Name = "labelTimeAliveText";
            labelTimeAliveText.Size = new Size(74, 20);
            labelTimeAliveText.TabIndex = 7;
            labelTimeAliveText.Text = "time alive";
            // 
            // labelTitleText
            // 
            labelTitleText.AutoSize = true;
            labelTitleText.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleText.Location = new Point(12, 3);
            labelTitleText.Name = "labelTitleText";
            labelTitleText.Size = new Size(198, 41);
            labelTitleText.TabIndex = 8;
            labelTitleText.Text = "LifeTimeCalc";
            // 
            // labelYears
            // 
            labelYears.AutoSize = true;
            labelYears.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelYears.Location = new Point(152, 88);
            labelYears.Name = "labelYears";
            labelYears.Size = new Size(0, 23);
            labelYears.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 170);
            Controls.Add(labelYears);
            Controls.Add(labelTitleText);
            Controls.Add(labelTimeAliveText);
            Controls.Add(labelDateOfBirth);
            Controls.Add(maskedTextBoxInput);
            Controls.Add(labelSeconds);
            Controls.Add(labelMinutes);
            Controls.Add(labelHours);
            Controls.Add(labelDays);
            Controls.Add(buttonCalc);
            Name = "Form1";
            Text = "LifeTimeCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalc;
        private Label labelDays;
        private Label labelHours;
        private Label labelSeconds;
        private Label labelMinutes;
        private MaskedTextBox maskedTextBoxInput;
        private Label labelDateOfBirth;
        private Label labelTimeAliveText;
        private Label labelTitleText;
        private Label labelYears;
    }
}