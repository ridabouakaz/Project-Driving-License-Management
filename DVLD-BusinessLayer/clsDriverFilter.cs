using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_BusinessLayer.clsUserFilter.UserFilterService;
using static DVLD_BusinessLayer.PersonFilterService;

namespace DVLD_BusinessLayer
{
    public class clsDriverFilter
    {
        public interface IDriverFilter
        {
            DataView ApplyFilter(DataTable data);
        }
        public class DriverIdFilter : IDriverFilter
        {
            private readonly int _DriverId;
            public DriverIdFilter(int DriverId) => _DriverId = DriverId;

            public DataView ApplyFilter(DataTable data)
            {
                var view = new DataView(data);
                view.RowFilter = $"Convert(UserID, 'System.String') LIKE '%{_DriverId}%'";
                return view;
            }
        }
        public class PersonIdFilter : IDriverFilter
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
        public class NationalNoFilter : IDriverFilter
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
        public class FullNameFilter : IDriverFilter
        {
            private readonly string _FullName;
            public FullNameFilter(string FullName) => _FullName = FullName;

            public DataView ApplyFilter(DataTable data)
            {
                var view = new DataView(data);
                view.RowFilter = $"FullName LIKE '%{_FullName}%'";
                return view;
            }
        }
    }
}
