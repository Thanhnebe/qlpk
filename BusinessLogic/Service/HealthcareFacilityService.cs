using BusinessLogic.Utils;
using DataAccess;
using DataAccess.Repository;

namespace BusinessLogic.Service
{
    public class HealthcareFacilityService : ClinicBaseService<HealthcareFacility>
    {
        protected override void ValidateEntity(HealthcareFacility healthcareFacility)
        {
            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Tên dịch vụ", healthcareFacility.Name, 2);
            ClinicExceptionUtils.throwIllegalExceptionIfNumberValueLessThan("Đơn giá", healthcareFacility.Price, 1);
        }
    }
}
