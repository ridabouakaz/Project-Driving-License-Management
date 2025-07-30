using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDShared;
using DVLD_DataAccessLayer;
using static DVLDShared.DVLDShared;
namespace DVLD_BusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string NationalNo { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string ImagePath { set; get; }
        public int CountryID { set; get; }
        public Gender PersonGender { get; set; }
        public clsPerson()

        {
            this.ID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.NationalNo = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.CountryID = -1;
            this.ImagePath = "";
            this.PersonGender = Gender.Male;
            Mode = enMode.AddNew;

        }
        private clsPerson(int ID,
    string FirstName,
    string SecondName,
    string ThirdName,
    string LastName,
    string NationalNo,
    string Email,
    string Phone,
    string Address,
    DateTime DateOfBirth,
    int CountryID,
    string ImagePath,
    Gender personGender)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;
            this.PersonGender = personGender;
            Mode = enMode.Update;
        }
        private bool _AddNewPerson()
        {
            //call DataAccess Layer 
            this.ID = clsPersonDataAccess.AddNewPerson(
        this.FirstName,
        this.SecondName,
        this.ThirdName,
        this.LastName,
        this.NationalNo,
        this.Email,
        this.Phone,
        this.Address,
        this.DateOfBirth,
        this.CountryID,
        this.ImagePath,
        this.PersonGender 
    );
            return (this.ID != -1);
        }
        private bool _UpdatePerson()
        {
            //call DataAccess Layer 
            return clsPersonDataAccess.UpdatePerson(
                    this.ID,
                    this.FirstName,
                    this.SecondName,
                    this.ThirdName,
                    this.LastName,
                    this.NationalNo,
                    this.Email,
                    this.Phone,
                    this.Address,
                    this.DateOfBirth,
                    this.CountryID,
                    this.ImagePath,
                    this.PersonGender // Enum → int
                );

        }
        public static clsPerson Find(int ID)
        {
            string firstName = "", secondName = "", thirdName = "", lastName = "";
            string nationalNo = "", email = "", phone = "", address = "", imagePath = "";
            DateTime dateOfBirth = DateTime.Now;
            int countryID = -1;
            Gender Gender = 0;

            bool isFound = clsPersonDataAccess.GetPersonInfoByID(
                ID,
                ref firstName,
                ref secondName,
                ref thirdName,
                ref lastName,
                ref nationalNo,
                ref email,
                ref phone,
                ref address,
                ref dateOfBirth,
                ref countryID,
                ref imagePath,
                ref Gender
            );

            if (isFound)
            {
                return new clsPerson(
                    ID,
                    firstName,
                    secondName,
                    thirdName,
                    lastName,
                    nationalNo,
                    email,
                    phone,
                    address,
                    dateOfBirth,
                    countryID,
                    imagePath,
                    Gender 
                );
            }
            else
                return null;
        }
        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }
            return false;
        }
        public static DataTable GetAllPeople()
        {
            return clsPersonDataAccess.GetAllPeople();

        }

        public static bool DeletePeople(int ID)
        {
            return clsPersonDataAccess.DeletePerson(ID);
        }

        public static bool isPeopleExist(int ID)
        {
            return clsPersonDataAccess.IsPersonExist(ID);
        }
        public static bool isNationalNumberExist(string NationalNo)
        {
            return clsPersonDataAccess.IsNationalNoExist(NationalNo);
        }
    }
}
