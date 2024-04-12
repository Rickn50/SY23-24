namespace CALENDER
{
    partial class Form1
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.InformationtextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.DayOptionscomboBox = new System.Windows.Forms.ComboBox();
            this.ImportantcheckBox = new System.Windows.Forms.CheckBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.AddToListbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // InformationtextBox
            // 
            this.InformationtextBox.Location = new System.Drawing.Point(580, 327);
            this.InformationtextBox.Multiline = true;
            this.InformationtextBox.Name = "InformationtextBox";
            this.InformationtextBox.Size = new System.Drawing.Size(208, 111);
            this.InformationtextBox.TabIndex = 1;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(467, 387);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(97, 51);
            this.Savebutton.TabIndex = 2;
            this.Savebutton.Text = "SAVE";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // DayOptionscomboBox
            // 
            this.DayOptionscomboBox.FormattingEnabled = true;
            this.DayOptionscomboBox.Items.AddRange(new object[] {
            "Personal",
            "Work",
            "School",
            "Vacation"});
            this.DayOptionscomboBox.Location = new System.Drawing.Point(18, 237);
            this.DayOptionscomboBox.Name = "DayOptionscomboBox";
            this.DayOptionscomboBox.Size = new System.Drawing.Size(121, 24);
            this.DayOptionscomboBox.TabIndex = 3;
            // 
            // ImportantcheckBox
            // 
            this.ImportantcheckBox.AutoSize = true;
            this.ImportantcheckBox.Location = new System.Drawing.Point(18, 277);
            this.ImportantcheckBox.Name = "ImportantcheckBox";
            this.ImportantcheckBox.Size = new System.Drawing.Size(113, 20);
            this.ImportantcheckBox.TabIndex = 4;
            this.ImportantcheckBox.Text = "Is it Important?";
            this.ImportantcheckBox.UseVisualStyleBackColor = true;
            this.ImportantcheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(467, 327);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(97, 51);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "READ";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // AddToListbutton
            // 
            this.AddToListbutton.Location = new System.Drawing.Point(183, 389);
            this.AddToListbutton.Name = "AddToListbutton";
            this.AddToListbutton.Size = new System.Drawing.Size(97, 51);
            this.AddToListbutton.TabIndex = 7;
            this.AddToListbutton.Text = "ADD TO LIST";
            this.AddToListbutton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(18, 308);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 132);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AddToListbutton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.ImportantcheckBox);
            this.Controls.Add(this.DayOptionscomboBox);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.InformationtextBox);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = " Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox InformationtextBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.ComboBox DayOptionscomboBox;
        private System.Windows.Forms.CheckBox ImportantcheckBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button AddToListbutton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

