using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class FOEditApplicationType : Form
    {
        int _ID;
        clsManageApplicationTypes _ApplicationTypes;
        public string Title
        {
            get => TBTitle.Text.Trim();
            set => TBTitle.Text = value;
        }
        public TextBox TitleTextBox => TBTitle;
        public string Fees
        {
            get => TBFees.Text.Trim();
            set => TBFees.Text = value;
        }
        public TextBox FeesTextBox => TBFees;
        public FOEditApplicationType(int ID)
        {
            _ID=ID;
            InitializeComponent();
        }
        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ValidateRequiredField(string value, TextBox textBox, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "Please enter a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }
        private void BtnAddSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("❌ Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _ApplicationTypes.ApplicationTypeTitle = Title.Trim();
            if (decimal.TryParse(Fees, out var parsedFees))
            {
                _ApplicationTypes.ApplicationFees = parsedFees;
            }
            else
            {
                MessageBox.Show("Invalid fee format. Please enter a valid number.");
            }
            if (_ApplicationTypes.Save())
            {
                MessageBox.Show("✅ Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("❌ Error: Data was not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void TBTitle_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredField(Title,TitleTextBox,e);
        }

        private void TBFees_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredField(Fees, FeesTextBox, e);
        }
    }
}
