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
    public class clsDetainedLicenseFilter
    {
        public class DetainedLicenseFilterService
        {
            public interface IDetainedLicenseFilter
            {
                DataView ApplyFilter(DataTable data);
            }
            public class DetainIdFilter : IDetainedLicenseFilter
            {
                private readonly int _DetainId;
                public DetainIdFilter(int DetainId) => _DetainId = DetainId;

                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);
                    view.RowFilter = $"Convert(DetainId, 'System.String') LIKE '%{_DetainId}%'";
                    return view;
                }
            }

            public class IsReleasedFilter : IDetainedLicenseFilter
            {
                private readonly string _isReleased;
                public IsReleasedFilter(string isReleased) => _isReleased = isReleased;

                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);

                    if (_isReleased != "All")
                    {
                        try
                        {
                            // تحويل النص إلى boolean
                            bool filterValue = _isReleased.ToLower() == "yes";
                            view.RowFilter = $"IsReleased = {filterValue.ToString().ToLower()}";
                        }
                        catch (Exception ex)
                        {
                          
                        }
                    }

                    return view;
                }
            }

            public class NationalNoFilter : IDetainedLicenseFilter
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

            public class FullNameFilter : IDetainedLicenseFilter
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
            public class ReleaseApplicationIdFilter : IDetainedLicenseFilter
            {
                private readonly int _ReleaseApplicationId;
                public ReleaseApplicationIdFilter(int ReleaseApplicationId) => _ReleaseApplicationId = ReleaseApplicationId;


                public DataView ApplyFilter(DataTable data)
                {
                    var view = new DataView(data);
                    view.RowFilter = $"Convert(ReleaseApplicationId, 'System.String') LIKE '%{_ReleaseApplicationId}%'";
                    return view;
                }
            }
        

        }
    }
}
