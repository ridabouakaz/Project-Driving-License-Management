using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLDShared.DVLDShared;

namespace DVLD_BusinessLayer
{
    public class clsManageTestTypes
    {
        public int ID { set; get; }
        public string TestTypeTitle { set; get; }
        public string TestTypeDescription { set; get; }

        public decimal TestTypeFees { set; get; }

        private clsManageTestTypes(int ID,
        string TestTypeTitle, string TestTypeDescription,
        decimal TestFees)
        {
            this.ID = ID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestFees;
        }
        private bool _UpdateTest()
        {
            //call DataAccess Layer 
            return clsTestDataAccess.UpdateTest(
                    this.ID,
                    this.TestTypeTitle,
                    this.TestTypeDescription,
                    this.TestTypeFees

                );

        }

        public static clsManageTestTypes Find(int ID)
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            decimal TestTypeFees = 1;

            bool isFound = clsTestDataAccess.GetTestInfoByID(
                ID,
                ref TestTypeTitle,
                ref TestTypeDescription,

                ref TestTypeFees
            );

            if (isFound)
            {
                return new clsManageTestTypes(
                    ID,
                     TestTypeTitle, TestTypeDescription,
                 TestTypeFees
                );
            }
            else
                return null;
        }
        public bool Save()
        { 
          return _UpdateTest();
        }
        public static DataTable GetAllTestTypes()
        {
            return clsTestDataAccess.GetAllTestTypes();

        }
    }
}
