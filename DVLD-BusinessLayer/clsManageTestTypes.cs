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
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };
        public clsManageTestTypes.enTestType ID { set; get; }
        public string TestTypeTitle { set; get; }
        public string TestTypeDescription { set; get; }
        public decimal TestTypeFees { set; get; }

        private clsManageTestTypes(clsManageTestTypes.enTestType ID,
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
                    (int)this.ID,
                    this.TestTypeTitle,
                    this.TestTypeDescription,
                    this.TestTypeFees

                );

        }
        public static clsManageTestTypes Find(clsManageTestTypes.enTestType TestTypeID)
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            decimal TestTypeFees = 1;

            bool isFound = clsTestDataAccess.GetTestInfoByID(
                (int)TestTypeID,
                ref TestTypeTitle,
                ref TestTypeDescription,

                ref TestTypeFees
            );

            if (isFound)
            {
                return new clsManageTestTypes(
                    TestTypeID,
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

        public static decimal GetFeesById(int id)
        {
            return clsTestDataAccess.GetFeesById(id);
        }
    }
}