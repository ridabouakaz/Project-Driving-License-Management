using DVLD_BusinessLayer;
using DVLD_PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_BusinessLayer.clsApplications;
using static DVLDShared.DVLDShared;

namespace DVLD_PresentationLayer
{
    public partial class CtrDetailsApplication : UserControl
    {
        private clsApplications _Application;

        public CtrDetailsApplication()
        {
            InitializeComponent();
        }
        public clsApplications ApplicationData
        {
            get => _Application;
            set
            {
                _Application = value;
                FillUIFromApplication();
            }
        }
        private void FillUIFromApplication()
        {
            if (_Application == null)
            {
                ApplicationID = "[????????]";
                Status = "[????????]";
                Fees = "[????????]";
                Type = "[????????]";
                Applicant = "[????????]";
                Date = "[????????]";
                StatusDate = "[????????]";
                CreatedBy = "[????????]";
                return;
            }
            ApplicationID = _Application.ID.ToString();
            TypeStatus = _Application.ApplicationStatus;
            Fees = _Application.PaidFees.ToString();
            Type = clsManageApplicationTypes.GetTitleById(_Application.ApplicationTypeID);
            Applicant = _Application.Phone;
           Date = _Application.Address;
            StatusDate = _Application.DateOfBirth.ToString("dd/MM/yyyy");
            CreatedBy = (clsCountry.Find(_Application.CountryID).CountryName);
        }
        public enApplicationStatus TypeStatus
        {
            set
            {
                if (value == enApplicationStatus.New)
                    LblValueStatus.Text = "New";
                if (value == enApplicationStatus.Cancelled)
                    LblValueStatus.Text = "Cancelled";
                else
                    LblValueStatus.Text = "Completed";
            }
        }
        public string ApplicationID
        {
            set => LblValueApplicationID.Text = value;
        }
        public string Status
        {
            set => LblValueStatus.Text = value;
        }
        public string Fees
        {
            set => LblValueFees.Text = value;
        }
        public string Type
        {
            set => LblValueType.Text = value;
        }
     
        public string Applicant
        {
            set => LblvalueApplicant.Text = value;
        }
  
        public string Date
        {
            set => LblvalueDate.Text = value;
        }
        public string StatusDate
        {
            set => LblvalueStatusDate.Text = value;
        }
        public string CreatedBy
        {
            set => LblvalueCreatedBy.Text = value;
        }
      
  
  
          private void LLEditApplicationInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
    
        }
    }
}
