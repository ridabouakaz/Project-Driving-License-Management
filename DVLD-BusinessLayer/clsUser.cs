using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_BusinessLayer.clsUser;
using static DVLDShared.DVLDShared;

namespace DVLD_BusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public ActiveStatus isActive { set; get; }
        public enMode Mode = enMode.AddNew;
        public int ID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public clsUser()

        {
            this.ID = -1;
            this.PersonID = 1;
            this.UserName = "";
            this.Password = "";
            isActive = ActiveStatus.Yes;
            Mode = enMode.AddNew;

        }
        private clsUser(int ID,
        int PersonID,
        string UserName,
        string Password, ActiveStatus isActive)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.isActive = isActive;
            Mode = enMode.Update;
        }
        private bool _AddNewUser()
        {
            //call DataAccess Layer 
            this.ID = clsUserDataAccess.AddNewUser(
            this.PersonID,
            this.UserName,
            this.Password,
            this.isActive
        );
            return (this.ID != -1);
        }
        private bool _UpdateUser()
        {
            //call DataAccess Layer 
            return clsUserDataAccess.UpdateUser(
                    this.ID,
                    this.PersonID,
            this.UserName,
            this.Password,
            this.isActive
                );

        }

        public static clsUser FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = "", Password = "";
            ActiveStatus IsActive = ActiveStatus.Yes;

            bool IsFound = clsUserDataAccess.GetUserInfoByPersonID
                                (PersonID, ref UserID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUser(UserID, UserID, UserName, Password, IsActive);
            else
                return null;
        }

        public static clsUser Find(int ID)
        {
            int PersonID = 1;
            string UserName = "";
            string Password = "";
            ActiveStatus isActive = 0;

            bool isFound = clsUserDataAccess.GetUserInfoByID(
                ID,
                ref PersonID,
                ref UserName,
                ref Password,
                ref isActive
            );

            if (isFound)
            {
                return new clsUser(
                    ID,
                     PersonID,
                 UserName,
                 Password,
                 isActive
                );
            }
            else
                return null;
        }

        public static clsUser Find(string UserName, string Password)
        {
            int PersonID = 1;
            ActiveStatus isActive = 0;
            int ID = 1;
            bool isFound = clsUserDataAccess.GetUserInfoByUserNameandPassword(
                UserName,
                Password,
                ref PersonID,
                ref ID,
                ref isActive
            );

            if (isFound)
            {
                return new clsUser(
                    ID,
                     PersonID,
                 UserName,
                 Password,
                 isActive
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
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }
            return false;
        }
        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();

        }

        public static bool DeleteUsers(int ID)
        {
            return clsUserDataAccess.DeleteUser(ID);
        }

        public static bool isUsersExist(int ID)
        {
            return clsUserDataAccess.IsUserExist(ID);
        }
        public static bool isUsersExistByPersonID(int ID)
        {
            return clsUserDataAccess.IsUserExistByPersonID(ID);
        }

    }
}
