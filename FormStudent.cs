using System;
using System.Windows.Forms;

namespace StudentsInfoSystem
{
    public partial class FormStudent : Form
    {
        private readonly FormStudentInfo _parent;
        public string id, FirstName, LastName, BirthDate, Email, Phone, Address, PostalCode;

        public FormStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            lbltext.Text = "Edit data";
            btnSave.Text = "Edit";

            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
            txtDate.Text = BirthDate;
            txtEmail.Text = Email;
            txtPhone.Text = Phone;
            txtAddress.Text = Address;
            txtPostalCode.Text = PostalCode;
        }

        public void SaveInfo()
        {
            lbltext.Text = "Add student";
            btnSave.Text = "Add";
        }

        public void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtEmail.Text = txtPhone.Text = txtAddress.Text = txtPostalCode.Text = String.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation: at least one field should not be too short
            if (txtFirstName.Text.Trim().Length < 3 &&
                txtLastName.Text.Trim().Length < 3 &&
                txtEmail.Text.Trim().Length < 3 &&
                txtPhone.Text.Trim().Length < 3 &&
                txtAddress.Text.Trim().Length < 3 &&
                txtPostalCode.Text.Trim().Length < 3)
            {
                MessageBox.Show("All fields must be filled");
                return;
            }

            if (btnSave.Text == "Add")
            {
                Student std = new Student(
                    txtFirstName.Text.Trim(),
                    txtLastName.Text.Trim(),
                    txtDate.Value,
                    txtEmail.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtAddress.Text.Trim(),
                    txtPostalCode.Text.Trim()
                );
                DbStudent.AddStudent(std);
                Clear();
            }
            else if (btnSave.Text == "Edit")
            {
                Student std = new Student(
                    txtFirstName.Text.Trim(),
                    txtLastName.Text.Trim(),
                    txtDate.Value,
                    txtEmail.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtAddress.Text.Trim(),
                    txtPostalCode.Text.Trim()
                );
                DbStudent.UpdateStudent(std, id);
            }

            _parent.Display();
        }

        // Other event handlers (left empty or unchanged)
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void lblName_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label1_Click_2(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void txtPhone_TextChanged(object sender, EventArgs e) { }
        private void txtDate_ValueChanged(object sender, EventArgs e) { }
        private void lbltext_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void FormStudent_Load(object sender, EventArgs e) { }
        private void txtPostalCode_TextChanged(object sender, EventArgs e) { }
    }

}
