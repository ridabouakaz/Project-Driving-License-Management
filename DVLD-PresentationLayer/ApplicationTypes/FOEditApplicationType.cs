using DVLD_BusinessLayer;
using DVLDShared;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            _ID = ID;
            InitializeComponent();
        }

        private void _LoadData()
        {
            _ApplicationTypes = clsManageApplicationTypes.Find(_ID);
            if (_ApplicationTypes == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _ID);
                this.Close();
                return;
            }
            LblValueID.Text = _ApplicationTypes.ID.ToString();
            Title = _ApplicationTypes.ApplicationTypeTitle;
            Fees = _ApplicationTypes.ApplicationFees.ToString("F4");
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

            if (string.IsNullOrEmpty(Fees.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(FeesTextBox, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(FeesTextBox, null);

            }
            ;


            if (!clsValidatoin.IsNumber(Fees))
            {
                e.Cancel = true;
                errorProvider1.SetError(FeesTextBox, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(FeesTextBox, null);
            }
            ;
        }

        private void FOEditApplicationType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
