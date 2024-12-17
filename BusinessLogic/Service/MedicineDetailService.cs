using BusinessLogic.Exception;
using BusinessLogic.Utils;
using DataAccess;
using DataAccess.Repository;

namespace BusinessLogic.Service
{
    public class MedicineDetailService : ClinicBaseService<MedicineDetail>
    {
        private TreatmentRequestRepository treatmentRequestRepository = new TreatmentRequestRepository();
        private MedicineRepository medicieRepository = new MedicineRepository();

        protected override void ValidateEntity(MedicineDetail medicineDetail)
        {
            bool isExistTreamentRequest = treatmentRequestRepository.ExistByIds(new object[] { medicineDetail.TreatmentRequestId });
            if (!isExistTreamentRequest)
            {
                throw new ClinicEntityIllegalStateException("Không tìm thấy phiếu khám chữa bệnh.");
            }

            bool isExistDisease = medicieRepository.ExistByIds(new object[] { medicineDetail.MedicineId });
            if (!isExistDisease)
            {
                throw new ClinicEntityIllegalStateException("Không tìm thấy thông tin thuốc.");
            }

            ClinicExceptionUtils.throwIllegalExceptionIfNumberValueLessThan("Số lượng", medicineDetail.Quantity, 1);

            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Hướng dẫn sử dụng", medicineDetail.Usage, 5);
        }
    }
}
