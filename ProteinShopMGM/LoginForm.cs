using ProteinShopMGM.DAL;
using ProteinShopMGM.DAL.Models;
using ProteinShopMGM.Utility;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ProteinShopMGM
{
    public partial class LoginForm : Form
    {
        private readonly IUserDAL _userDAL = new UserDAL();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Initializes the form components.
            InitForm();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // First validate the input.
            if (!ValidateForm(out string errorMessage))
            {
                MessageBox.Show(errorMessage, Common.STRINGS.VALIDATION_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = _userDAL.GetByUsername(UsernameTextBox.Text);
            if (user == null || !user.Password.Equals(PasswordTextBox.Text))
            {
                MessageBox.Show("Invalid username or password.", Common.STRINGS.AUTH_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set logged in user details.
            MDIParent._loggedInUser = new Common.LoggedInUser()
            {
                UserId = user.Id,
                Username = user.Username,
                LoggedInDateTime = DateTime.Now
            };

            // Redirect to main/dashboard screen.
            new MDIParent().Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitForm()
        {
            HeaderLabel.Text = ConfigurationManager.AppSettings["AppName"].ToString();
            Common.Utility.ResetControls(DataEntryPanel);
            UsernameTextBox.Focus();
        }

        private bool ValidateForm(out string errorMessage)
        {
            bool returnValue = true;
            errorMessage = string.Empty;

            if (!Common.Validation.IsNotEmpty(UsernameTextBox))
            {
                errorMessage = "Username cannot be blank.";
                returnValue = false;
            }

            if (!Common.Validation.IsNotEmpty(PasswordTextBox))
            {
                errorMessage = errorMessage + Environment.NewLine + "Password cannot be blank.";
                returnValue = false;
            }

            return returnValue;
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*'; // or any other masking character of your choice
            }
        }
    }
}
