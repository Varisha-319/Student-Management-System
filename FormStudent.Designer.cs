namespace StudentsInfoSystem
{
    partial class FormStudent
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
            panel1 = new Panel();
            lbltext = new Label();
            panel2 = new Panel();
            txtDate = new DateTimePicker();
            btnSave = new Button();
            txtPostalCode = new TextBox();
            lblPostalCode = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblBirthDate = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(lbltext);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 167);
            panel1.TabIndex = 0;
            // 
            // lbltext
            // 
            lbltext.AutoSize = true;
            lbltext.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbltext.ForeColor = Color.White;
            lbltext.Location = new Point(46, 53);
            lbltext.Margin = new Padding(4, 0, 4, 0);
            lbltext.Name = "lbltext";
            lbltext.Size = new Size(366, 55);
            lbltext.TabIndex = 0;
            lbltext.Text = "ADD STUDENT";
            lbltext.Click += lbltext_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtDate);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtPostalCode);
            panel2.Controls.Add(lblPostalCode);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(lblAddress);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(lblPhone);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblBirthDate);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(lblLastName);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(lblFirstName);
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(46, 217);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 650);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // txtDate
            // 
            txtDate.Format = DateTimePickerFormat.Short;
            txtDate.Location = new Point(30, 188);
            txtDate.Margin = new Padding(4, 5, 4, 5);
            txtDate.MaxDate = new DateTime(2022, 10, 31, 0, 0, 0, 0);
            txtDate.MinDate = new DateTime(1900, 3, 10, 0, 0, 0, 0);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(141, 31);
            txtDate.TabIndex = 10;
            txtDate.Value = new DateTime(2022, 10, 31, 0, 0, 0, 0);
            txtDate.ValueChanged += txtDate_ValueChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Snow;
            btnSave.Location = new Point(30, 515);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 50);
            btnSave.TabIndex = 8;
            btnSave.Text = "ADD";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = Color.White;
            txtPostalCode.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPostalCode.Location = new Point(284, 433);
            txtPostalCode.Margin = new Padding(4, 5, 4, 5);
            txtPostalCode.MaxLength = 7;
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.PlaceholderText = "900 86";
            txtPostalCode.Size = new Size(200, 28);
            txtPostalCode.TabIndex = 7;
            txtPostalCode.TextChanged += txtPostalCode_TextChanged;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPostalCode.Location = new Point(284, 395);
            lblPostalCode.Margin = new Padding(4, 0, 4, 0);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(140, 20);
            lblPostalCode.TabIndex = 0;
            lblPostalCode.Text = "POSTAL CODE";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = SystemColors.ActiveCaptionText;
            txtAddress.Location = new Point(30, 433);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.MaxLength = 60;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "faisalabad";
            txtAddress.Size = new Size(201, 28);
            txtAddress.TabIndex = 6;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(30, 395);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(98, 20);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "ADDRESS";
            lblAddress.Click += label2_Click_1;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(284, 188);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.MaxLength = 15;
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "+92 333 545 006";
            txtPhone.Size = new Size(200, 28);
            txtPhone.TabIndex = 5;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.Location = new Point(284, 153);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(120, 20);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "TELEPHONE";
            lblPhone.Click += label1_Click_2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(30, 312);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "varisha@gmail.com";
            txtEmail.Size = new Size(250, 28);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(30, 277);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "EMAIL";
            lblEmail.Click += label2_Click;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBirthDate.Location = new Point(30, 150);
            lblBirthDate.Margin = new Padding(4, 0, 4, 0);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(120, 20);
            lblBirthDate.TabIndex = 0;
            lblBirthDate.Text = "BIRTH DATE";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(284, 68);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.MaxLength = 20;
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Khan";
            txtLastName.Size = new Size(200, 28);
            txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(284, 32);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(113, 20);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "LAST NAME";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(30, 68);
            txtFirstName.Margin = new Padding(4, 5, 4, 5);
            txtFirstName.MaxLength = 20;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Varisha";
            txtFirstName.Size = new Size(200, 28);
            txtFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(30, 32);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(119, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FIRST NAME";
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(626, 879);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormStudent";
            Text = "FormStudent";
            Load += FormStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

       

        #endregion

        private Panel panel1;
        private Label lbltext;
        private Panel panel2;
        private DateTimePicker txtDate;
        private Button btnSave;
        private TextBox txtPostalCode;
        private Label lblPostalCode;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblBirthDate;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
    }
}
