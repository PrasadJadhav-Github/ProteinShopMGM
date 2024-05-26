using System;
using System.Configuration;
using System.Windows.Forms;
using static ProteinShopMGM.Utility.Common;

namespace ProteinShopMGM
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;
        public static LoggedInUser _loggedInUser;

        public MDIParent()
        {
            InitializeComponent();
        }

       

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            this.Text = ConfigurationManager.AppSettings["AppName"].ToString();
            LoginDetailLabel.Text = MDIParent._loggedInUser.Username + " logged in at " + MDIParent._loggedInUser.LoggedInDateTime;
            MenuOptionsPanel.Width = MDIHeaderPanel.Width = ContentPanel.Width = this.Width;
            ContentPanel.Height = this.Height - 87;
        }

        private void MDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ProductCategoryMenuLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductCategoryForm childForm = new ProductCategoryForm
            {
                MdiParent = this
            };
            ContentPanel.Controls.Add(childForm);
            childForm.Show();
            childForm.Activate();
            childForm.WindowState = FormWindowState.Maximized;
            //CloseAllFormsExcept(childForm);
            //childForm.MdiParent = this;
            //childForm.Show();

        }

        private void SupplierMenuLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplierForm childForm = new SupplierForm
            {
                MdiParent = this
            };
            ContentPanel.Controls.Add(childForm);
            childForm.Show(); 
            childForm.Activate();
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void CustomerMenuLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerForm childForm = new CustomerForm
            {
                MdiParent = this
            };
            ContentPanel.Controls.Add(childForm);
            childForm.Show(); 
            childForm.Activate();
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void ProductMenuLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductForm childForm = new ProductForm
            {
                MdiParent = this
            };
            ContentPanel.Controls.Add(childForm);
            childForm.Show(); 
            childForm.Activate();
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void PurchaseMenuLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PurchaseForm childForm = new PurchaseForm
            {
                MdiParent = this
            };
            ContentPanel.Controls.Add(childForm);
            childForm.Show(); 
            childForm.Activate();
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void PurchaseStatusMenuLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            PurchaseStatusForm childForm = new PurchaseStatusForm
            {
                MdiParent = this
            };
            ContentPanel.Controls.Add(childForm);
            childForm.Show(); 
            childForm.Activate();
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void GenerateBillMenuLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            GenerateBillForm childForm = new GenerateBillForm
            {
                MdiParent = this
            };
            ContentPanel.Controls.Add(childForm);
            childForm.Show(); 
            childForm.Activate();
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void StockReportMenuLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            StockReportForm childForm = new StockReportForm
            {
                MdiParent = this
            };
            ContentPanel.Controls.Add(childForm);
            childForm.Show();
            childForm.Activate();
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void SalesReportMenuLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            SalesReportForm childForm = new SalesReportForm
            {
                MdiParent = this
            };
            ContentPanel.Controls.Add(childForm);
            childForm.Show(); 
            childForm.Activate();
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // Show a confirmation message to the user to confirm logout
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user confirms the logout, clear the user's session or credentials and redirect to the login screen
            if (result == DialogResult.Yes)
            {
                // Clear the user's session or credentials
                // For example, you can set a flag or variable to indicate that the user is logged out

                // Show a message to the user to indicate that they have been logged out
                MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect the user to the login screen
                LoginForm loginForm = new LoginForm(); // replace "LoginForm" with the name of your login form
                loginForm.Show();
                this.Hide(); // hide the current form (the one with the logout button)
            }
        }

    }
}



