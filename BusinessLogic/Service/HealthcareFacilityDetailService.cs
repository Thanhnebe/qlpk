using BusinessLogic.Exception;
using BusinessLogic.Utils;
using DataAccess;
using DataAccess.Repository;

namespace BusinessLogic.Service
{
    public class HealthcareFacilityDetailService : ClinicBaseService<HealthcareFacilityDetail>
    {
        private TreatmentRequestRepository treatmentRequestRepository = new TreatmentRequestRepository();
        private HealthcareFacilityRepository healthcareFacilityRepository = new HealthcareFacilityRepository();

        protected override void ValidateEntity(HealthcareFacilityDetail healthcareFacilityDetail)
        {
            if (healthcareFacilityDetail == null)
            {
                throw new ClinicEntityIllegalStateException("Chi tiết dịch vụ khám chữa bệnh bị rỗng.");
            }

            bool isExistTreamentRequest = treatmentRequestRepository.ExistByIds(new object[] { healthcareFacilityDetail.TreatmentRequestId });
            if (!isExistTreamentRequest)
            {
                throw new ClinicEntityIllegalStateException("Không tìm thấy phiếu khám chữa bệnh.");
            }

            bool isExistHealthcareFacility = healthcareFacilityRepository.ExistByIds(new object[] { healthcareFacilityDetail.HealthcareFacilityId });
            if (!isExistHealthcareFacility)
            {
                throw new ClinicEntityIllegalStateException("Không tìm thấy thông tin dịch vụ .");
            }

            ClinicExceptionUtils.throwIllegalExceptionIfNumberValueLessThan("Số lượng", healthcareFacilityDetail.Quantity, 1);
        }

    }
}
