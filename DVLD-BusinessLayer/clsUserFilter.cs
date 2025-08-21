using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_BusinessLayer.PersonFilterService;
using static DVLDShared.DVLDShared;

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

            public class UserNameFilter : IUserFilter
            {
                private readonly string _UserName;
                public UserNameFilter(string UserName) => _UserName = UserName;

                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);
                    view.RowFilter = $"UserName LIKE '%{_UserName}%'";
                    return view;
                }
            }

            public class IdPersonFilter : IUserFilter
            {
                private readonly int _personId;
                public IdPersonFilter(int personId) => _personId = personId;

                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);
                    view.RowFilter = $"Convert(PersonID, 'System.String') LIKE '%{_personId}%'";
                    return view;
                }
            }

            public class FullNameFilter : IUserFilter
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
            public class ActiveStatusFilter : IUserFilter
            {
                private readonly string _ActiveStatus;
                public ActiveStatusFilter(string ActiveStatus) => _ActiveStatus = ActiveStatus;

                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);
                    if (_ActiveStatus != "All")
                    {
                        view.RowFilter = $"IsActive LIKE '%{_ActiveStatus}%'";
                    }
                    return view;
                }
            }

        }
    }
}
