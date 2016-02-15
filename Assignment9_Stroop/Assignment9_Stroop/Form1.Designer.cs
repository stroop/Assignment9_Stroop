namespace Assignment9_Stroop
{
    partial class RentalForm
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.carLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.compactRBtn = new System.Windows.Forms.RadioButton();
            this.standardRBtn = new System.Windows.Forms.RadioButton();
            this.luxuryRBtn = new System.Windows.Forms.RadioButton();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.submitBtn = new System.Windows.Forms.Button();
            this.daysLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(99, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(210, 25);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Car Rental Selection";
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carLabel.Location = new System.Drawing.Point(24, 57);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(135, 17);
            this.carLabel.TabIndex = 1;
            this.carLabel.Text = "Choose A Vehicle";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(232, 57);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(161, 17);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Select A Return Date";
            // 
            // compactRBtn
            // 
            this.compactRBtn.AutoSize = true;
            this.compactRBtn.Location = new System.Drawing.Point(26, 110);
            this.compactRBtn.Name = "compactRBtn";
            this.compactRBtn.Size = new System.Drawing.Size(131, 17);
            this.compactRBtn.TabIndex = 3;
            this.compactRBtn.TabStop = true;
            this.compactRBtn.Text = "Compact:  $19.95/day";
            this.compactRBtn.UseVisualStyleBackColor = true;
            // 
            // standardRBtn
            // 
            this.standardRBtn.AutoSize = true;
            this.standardRBtn.Location = new System.Drawing.Point(26, 154);
            this.standardRBtn.Name = "standardRBtn";
            this.standardRBtn.Size = new System.Drawing.Size(132, 17);
            this.standardRBtn.TabIndex = 4;
            this.standardRBtn.TabStop = true;
            this.standardRBtn.Text = "Standard:  $24.95/day";
            this.standardRBtn.UseVisualStyleBackColor = true;
            // 
            // luxuryRBtn
            // 
            this.luxuryRBtn.AutoSize = true;
            this.luxuryRBtn.Location = new System.Drawing.Point(26, 199);
            this.luxuryRBtn.Name = "luxuryRBtn";
            this.luxuryRBtn.Size = new System.Drawing.Size(132, 17);
            this.luxuryRBtn.TabIndex = 5;
            this.luxuryRBtn.TabStop = true;
            this.luxuryRBtn.Text = "Luxury:      $39.00/day";
            this.luxuryRBtn.UseVisualStyleBackColor = true;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(201, 83);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(2000, 2, 14, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 6;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.LightCyan;
            this.submitBtn.Location = new System.Drawing.Point(27, 344);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(131, 23);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Selection Complete";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.Location = new System.Drawing.Point(231, 270);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(117, 20);
            this.daysLabel.TabIndex = 8;
            this.daysLabel.Text = "Rental Days: ";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(23, 270);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(104, 20);
            this.totalPriceLabel.TabIndex = 9;
            this.totalPriceLabel.Text = "Total Price: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Location = new System.Drawing.Point(235, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(455, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.luxuryRBtn);
            this.Controls.Add(this.standardRBtn);
            this.Controls.Add(this.compactRBtn);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.carLabel);
            this.Controls.Add(this.mainLabel);
            this.Name = "RentalForm";
            this.Text = "Car Rental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.RadioButton compactRBtn;
        private System.Windows.Forms.RadioButton standardRBtn;
        private System.Windows.Forms.RadioButton luxuryRBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button button1;
    }
}

