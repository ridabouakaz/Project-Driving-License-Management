using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_BusinessLayer.PersonFilterService;

namespace DVLD_BusinessLayer
{
    public class LocalDrivingApplicationFilter
    {
        public class LocalDrivingApplicationFilterService
        {
            public interface ILocalDrivingApplicationFilter
            {
                DataView ApplyFilter(DataTable data);
            }
            public class LDLAppIDFilter : ILocalDrivingApplicationFilter
            {
                private readonly int _LDLAppID;
                public LDLAppIDFilter(int LDLAppID) => _LDLAppID = LDLAppID;

                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);
                    view.RowFilter = $"Convert(LocalDrivingLicenseApplicationID, 'System.String') LIKE '%{_LDLAppID}%'";
                    return view;
                }
            }
            public class NationalNoLDLFilter : ILocalDrivingApplicationFilter
            {
                private readonly string _nationalNo;
                public NationalNoLDLFilter(string nationalNo) => _nationalNo = nationalNo;

                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);
                    view.RowFilter = $"NationalNo LIKE '%{_nationalNo}%'";
                    return view;
                }
            }

            public class FullNameFilter : ILocalDrivingApplicationFilter
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
            public class ActiveStatusFilter : ILocalDrivingApplicationFilter
            {
                private readonly string _ActiveStatus;
                public ActiveStatusFilter(string ActiveStatus) => _ActiveStatus = ActiveStatus;

                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);
                        view.RowFilter = $"Status LIKE '%{_ActiveStatus}%'";
                    return view;
                }
            }

        }
    }
}
