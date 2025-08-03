using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class PersonFilterService
    {
        public interface IPersonFilter
        {
            DataView ApplyFilter(DataTable data);
        }
        public DataView FilterByPersonID(DataTable data, int PersonID)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"PersonID LIKE '%{PersonID}%'";
            return view;
        }
        public DataView FilterByNationalNo(DataTable data, string NationalNo)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"FirstName LIKE '%{NationalNo}%'";
            return view;
        }
        public DataView FilterByFirstName(DataTable data, string FirstName)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"FirstName LIKE '%{FirstName}%'";
            return view;
        }
        public DataView FilterBySecondName(DataTable data, string SecondName)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"SecondName LIKE '%{SecondName}%'";
            return view;
        }
        public DataView FilterByThirdName(DataTable data, string ThirdName)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"ThirdName LIKE '%{ThirdName}%'";
            return view;
        }
        public DataView FilterByLastName(DataTable data, string LastName)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"LastName LIKE '%{LastName}%'";
            return view;
        }
        public DataView FilterByPhone(DataTable data, string Phone)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"Phone LIKE '%{Phone}%'";
            return view;
        }
        public DataView FilterByEmail(DataTable data, string Email)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"Email LIKE '%{Email}%'";
            return view;
        }
        public DataView FilterByGender(DataTable data, string Gender)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"Gender LIKE '%{Gender}%'";
            return view;
        }
        public DataView FilterByCountry(DataTable data, int countryId)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"CountryID = {countryId}";
            return view;
        }




    }
}
