using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsUserFilter
    {
        public class UserFilterService
        {
            public interface IUserFilter
            {
                DataView ApplyFilter(DataTable data);
            }
            public class UserIdFilter : IUserFilter
            {
                private readonly int _UserId;
                public UserIdFilter(int UserId) => _UserId = UserId;

                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);
                    view.RowFilter = $"Convert(UserID, 'System.String') LIKE '%{_UserId}%'";
                    return view;
                }
            }

            public class NationalNoFilter : IUserFilter
            {
                private readonly string _nationalNo;
                public NationalNoFilter(string nationalNo) => _nationalNo = nationalNo;

                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);
                    view.RowFilter = $"NationalNo LIKE '%{_nationalNo}%'";
                    return view;
                }
            }

            public class FirstNameFilter : IUserFilter
            {
                private readonly string _firstName;
                public FirstNameFilter(string firstName) => _firstName = firstName;

                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);
                    view.RowFilter = $"FirstName LIKE '%{_firstName}%'";
                    return view;
                }
            }

            public class SecondNameFilter : IUserFilter
            {
                private readonly string _secondName;
                public SecondNameFilter(string secondName) => _secondName = secondName;

                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);
                    view.RowFilter = $"SecondName LIKE '%{_secondName}%'";
                    return view;
                }
            }

            public class ThirdNameFilter : IUserFilter
            {
                private readonly string _thirdName;
                public ThirdNameFilter(string thirdName) => _thirdName = thirdName;

                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);
                    view.RowFilter = $"ThirdName LIKE '%{_thirdName}%'";
                    return view;
                }
            }

           

          

          
            public class GenderFilter : IUserFilter
            {
                private readonly string _gender;
                public GenderFilter(string gender) => _gender = gender;

                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);
                    view.RowFilter = $"Gender LIKE '%{_gender}%'";
                    return view;
                }
            }

            

        }
    }
}
