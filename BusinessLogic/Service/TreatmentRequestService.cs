using BusinessLogic.Exception;
using BusinessLogic.Utils;
using DataAccess;
using DataAccess.Repository;

namespace BusinessLogic.Service
{
    public class TreatmentRequestService : ClinicBaseService<TreatmentRequest>
    {
        private DoctorRepository doctorRepository = new DoctorRepository();
        private PatientRepository patientRepository = new PatientRepository();

        protected override void ValidateEntity(TreatmentRequest treatmentRequest)
        {
            bool isExistPatient = patientRepository.ExistByIds(new object[] { treatmentRequest.PatientId });
            if (!isExistPatient)
            {
                throw new ClinicEntityIllegalStateException("Không tìm thấy bệnh nhân");
            }

            bool isExistDoctor = doctorRepository.ExistByIds(new object[] { treatmentRequest.DoctorId });
            if (!isExistDoctor)
            {
                throw new ClinicEntityIllegalStateException("Không tìm thấy bác sĩ");
            }

            ClinicExceptionUtils.throwIllegalExpcetionIfINull("Ngày đăng ký", treatmentRequest.RegisterDate);
        }
    }
}
