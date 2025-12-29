namespace StudentsInfoSystem
{
    public partial class FormStudentInfo : Form
    {
        FormStudent form;
        public FormStudentInfo()
        {
            InitializeComponent();
            form = new FormStudent(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Optional: implement if needed
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Optional: implement if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: implement if needed
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            // Optional: implement if needed
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: implement if needed
        }

        public void Display()
        {
            string query = "SELECT ID, FirstName, LastName, BirthDate, Email, Phone, Address, PostalCode FROM student_info";
            DbStudent.DisplayAndSearch(query, dataGridView);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void FormStudentInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            string query = $@"
                SELECT ID, FirstName, LastName, BirthDate, Email, Phone, Address, PostalCode
                FROM student_info
                WHERE FirstName LIKE '%{searchText}%' 
                   OR LastName LIKE '%{searchText}%' 
                   OR BirthDate LIKE '%{searchText}%' 
                   OR Email LIKE '%{searchText}%' 
                   OR Phone LIKE '%{searchText}%' 
                   OR Address LIKE '%{searchText}%' 
                   OR PostalCode LIKE '%{searchText}%'";
            DbStudent.DisplayAndSearch(query, dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header row clicks

            var row = dataGridView.Rows[e.RowIndex];

            if (e.ColumnIndex == 0) // Edit button column
            {
                form.Clear();
                form.id = row.Cells["ID"].Value.ToString();
                form.FirstName = row.Cells["FirstName"].Value.ToString();
                form.LastName = row.Cells["LastName"].Value.ToString();
                form.BirthDate = row.Cells["BirthDate"].Value.ToString();
                form.Email = row.Cells["Email"].Value.ToString();
                form.Phone = row.Cells["Phone"].Value.ToString();
                form.Address = row.Cells["Address"].Value.ToString();
                form.PostalCode = row.Cells["PostalCode"].Value.ToString();

                form.UpdateInfo();
                form.ShowDialog();
                return;
            }

            if (e.ColumnIndex == 1) // Delete button column
            {
                if (MessageBox.Show("Do you really want to delete the student?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbStudent.DeleteStudent(row.Cells["ID"].Value.ToString());
                    Display();
                }
            }
        }

        private void FormStudentInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
