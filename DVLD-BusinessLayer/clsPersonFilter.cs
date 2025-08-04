using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLDShared.DVLDShared;

namespace DVLD_BusinessLayer
{
    public class PersonFilterService
    {
        public interface IPersonFilter
        {
            DataView ApplyFilter(DataTable data);
        }
        public class PersonIdFilter : IPersonFilter
        {
            private readonly int _personId;
            public PersonIdFilter(int personId) => _personId = personId;

            public DataView ApplyFilter(DataTable data)
            {
                var view = new DataView(data);
                view.RowFilter = $"Convert(PersonID, 'System.String') LIKE '%{_personId}%'";
                return view;
            }
        }

        public class NationalNoFilter : IPersonFilter
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

        public class FirstNameFilter : IPersonFilter
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

        public class SecondNameFilter : IPersonFilter
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

        public class ThirdNameFilter : IPersonFilter
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

        public class LastNameFilter : IPersonFilter
        {
            private readonly string _lastName;
            public LastNameFilter(string lastName) => _lastName = lastName;

            public DataView ApplyFilter(DataTable data)
            {
                var view = new DataView(data);
                view.RowFilter = $"LastName LIKE '%{_lastName}%'";
                return view;
            }
        }

        public class PhoneFilter : IPersonFilter
        {
            private readonly string _phone;
            public PhoneFilter(string phone) => _phone = phone;

            public DataView ApplyFilter(DataTable data)
            {
                var view = new DataView(data);
                view.RowFilter = $"Phone LIKE '%{_phone}%'";
                return view;
            }
        }

        public class EmailFilter : IPersonFilter
        {
            private readonly string _email;
            public EmailFilter(string email) => _email = email;

            public DataView ApplyFilter(DataTable data)
            {
                var view = new DataView(data);
                view.RowFilter = $"Email LIKE '%{_email}%'";
                return view;
            }
        }

        public class GenderFilter : IPersonFilter
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

        public class CountryFilter : IPersonFilter
        {
            private readonly string _nationality;
            public CountryFilter(string nationality) => _nationality = nationality;

            public DataView ApplyFilter(DataTable data)
            {
                var view = new DataView(data);
                view.RowFilter = $"Nationality LIKE '%{_nationality}%'";
                return view;
            }
        }





    }
}
