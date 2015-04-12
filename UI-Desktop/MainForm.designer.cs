namespace WindowsFormsApplication2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_Show = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.comboBox_Term = new System.Windows.Forms.ComboBox();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.textBox_Contact = new System.Windows.Forms.TextBox();
            this.textBox_Home = new System.Windows.Forms.TextBox();
            this.textBox_Batch = new System.Windows.Forms.TextBox();
            this.textBox_Roll = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Show
            // 
            this.button_Show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Show.BackgroundImage")));
            this.button_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Show.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_Show.FlatAppearance.BorderSize = 0;
            this.button_Show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show.Location = new System.Drawing.Point(313, 553);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(119, 44);
            this.button_Show.TabIndex = 9;
            this.button_Show.Text = "       SHOW";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click_1);
            // 
            // button_Save
            // 
            this.button_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Save.BackgroundImage")));
            this.button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(76, 553);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(99, 44);
            this.button_Save.TabIndex = 8;
            this.button_Save.Text = "     SAVE";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // comboBox_Term
            // 
            this.comboBox_Term.BackColor = System.Drawing.Color.IndianRed;
            this.comboBox_Term.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Term.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Term.FormattingEnabled = true;
            this.comboBox_Term.Items.AddRange(new object[] {
            "I",
            "II"});
            this.comboBox_Term.Location = new System.Drawing.Point(230, 367);
            this.comboBox_Term.Name = "comboBox_Term";
            this.comboBox_Term.Size = new System.Drawing.Size(268, 28);
            this.comboBox_Term.TabIndex = 4;
            // 
            // comboBox_Year
            // 
            this.comboBox_Year.BackColor = System.Drawing.Color.IndianRed;
            this.comboBox_Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Year.FormattingEnabled = true;
            this.comboBox_Year.Items.AddRange(new object[] {
            "1st YEAR",
            "2nd YEAR",
            "3rd YEAR",
            "4th YEAR"});
            this.comboBox_Year.Location = new System.Drawing.Point(229, 312);
            this.comboBox_Year.Name = "comboBox_Year";
            this.comboBox_Year.Size = new System.Drawing.Size(268, 28);
            this.comboBox_Year.TabIndex = 5;
            // 
            // textBox_Contact
            // 
            this.textBox_Contact.BackColor = System.Drawing.Color.IndianRed;
            this.textBox_Contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Contact.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Contact.Location = new System.Drawing.Point(230, 481);
            this.textBox_Contact.Name = "textBox_Contact";
            this.textBox_Contact.Size = new System.Drawing.Size(268, 22);
            this.textBox_Contact.TabIndex = 7;
            // 
            // textBox_Home
            // 
            this.textBox_Home.BackColor = System.Drawing.Color.IndianRed;
            this.textBox_Home.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Home.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Home.Location = new System.Drawing.Point(231, 427);
            this.textBox_Home.Name = "textBox_Home";
            this.textBox_Home.Size = new System.Drawing.Size(267, 22);
            this.textBox_Home.TabIndex = 6;
            // 
            // textBox_Batch
            // 
            this.textBox_Batch.BackColor = System.Drawing.Color.IndianRed;
            this.textBox_Batch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Batch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Batch.Location = new System.Drawing.Point(230, 261);
            this.textBox_Batch.Name = "textBox_Batch";
            this.textBox_Batch.Size = new System.Drawing.Size(268, 22);
            this.textBox_Batch.TabIndex = 3;
            // 
            // textBox_Roll
            // 
            this.textBox_Roll.BackColor = System.Drawing.Color.IndianRed;
            this.textBox_Roll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Roll.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Roll.Location = new System.Drawing.Point(230, 207);
            this.textBox_Roll.Name = "textBox_Roll";
            this.textBox_Roll.Size = new System.Drawing.Size(268, 22);
            this.textBox_Roll.TabIndex = 1;
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.IndianRed;
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(230, 153);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(268, 22);
            this.textBox_Name.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.comboBox_Year);
            this.panel1.Controls.Add(this.textBox_Contact);
            this.panel1.Controls.Add(this.comboBox_Term);
            this.panel1.Controls.Add(this.textBox_Roll);
            this.panel1.Controls.Add(this.textBox_Batch);
            this.panel1.Controls.Add(this.textBox_Home);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 520);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minion Pro Med", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(189, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "FORM WINDOW";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Show);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_Contact;
        private System.Windows.Forms.TextBox textBox_Home;
        private System.Windows.Forms.TextBox textBox_Batch;
        private System.Windows.Forms.TextBox textBox_Roll;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.ComboBox comboBox_Term;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;

    }
}

