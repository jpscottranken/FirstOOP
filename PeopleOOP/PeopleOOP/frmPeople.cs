using System;
using System.Windows.Forms;

namespace PeopleOOP
{
    public partial class frmPeople : Form
    {
        public frmPeople()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Person jeff = new Person();
            jeff.FirstName = $"{txtFirstName.Text}";
            jeff.LastName = $"{txtLastName.Text}";
            jeff.Department = $"{txtDepartment.Text}";
            jeff.Salary = Decimal.Parse(txtSalary.Text);
            jeff.Married = bool.Parse(txtMaritalStatus.Text);
            jeff.ToString();

            Person mary = new Person("Mary", "Jones", "Web", 99999, false);
            MessageBox.Show(jeff.ToString(), "Jeff's Info");
            mary.ToString();
            MessageBox.Show(mary.ToString(), "Mary's Info");
            //GetEmployeeInfo();
        }

        private void GetEmployeeInfo()
        {

            //MessageBox.Show(Person.outputStr, "PERSONS DATA");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDepartment.Text = "";
            txtSalary.Text = "";
            txtMaritalStatus.Text = "";
            txtFirstName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                        "Do You Really Want To Exit The Program?",
                        "EXIT NOW?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
