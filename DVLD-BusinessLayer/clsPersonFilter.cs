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
        public DataView FilterByPersonID(DataTable data, string name)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"FirstName LIKE '%{name}%'";
            return view;
        }
        public DataView FilterByNationalNo(DataTable data, string name)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"FirstName LIKE '%{name}%'";
            return view;
        }
        public DataView FilterByFirstName(DataTable data, string name)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"FirstName LIKE '%{name}%'";
            return view;
        }
        public DataView FilterBySecondName(DataTable data, string name)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"FirstName LIKE '%{name}%'";
            return view;
        }
        public DataView FilterByThirdName(DataTable data, string name)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"FirstName LIKE '%{name}%'";
            return view;
        }
        public DataView FilterByLastName(DataTable data, string name)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"FirstName LIKE '%{name}%'";
            return view;
        }
        public DataView FilterByPhone(DataTable data, string name)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"FirstName LIKE '%{name}%'";
            return view;
        }
        public DataView FilterByEmail(DataTable data, string name)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"FirstName LIKE '%{name}%'";
            return view;
        }
        public DataView FilterByGender(DataTable data, string name)
        {
            DataView view = new DataView(data);
            view.RowFilter = $"FirstName LIKE '%{name}%'";
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
