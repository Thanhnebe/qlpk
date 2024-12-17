using BusinessLogic.Exception;
using DataAccess.Repository;
using DataAccess;

namespace BusinessLogic.Service
{
    public class DiseaseDetailService : ClinicBaseService<DiseaseDetail>
    {
        private TreatmentRequestRepository treatmentRequestRepository = new TreatmentRequestRepository();
        private DiseaseRepository diseaseRepository = new DiseaseRepository();

        protected override void ValidateEntity(DiseaseDetail diseaseDetail)
        {
            bool isExistTreamentRequest = treatmentRequestRepository.ExistByIds(new object[] { diseaseDetail.TreatmentRequestId });
            if (!isExistTreamentRequest)
            {
                throw new ClinicEntityIllegalStateException("Không tìm thấy phiếu khám chữa bệnh.");
            }

            bool isExistDisease = diseaseRepository.ExistByIds(new object[] { diseaseDetail.DiseaseId });
            if (!isExistDisease)
            {
                throw new ClinicEntityIllegalStateException("Không tìm thấy thông tin bệnh.");
            }

        }
    }
}
