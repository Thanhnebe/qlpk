using BusinessLogic.Utils;
using DataAccess;
using DataAccess.Repository;

namespace BusinessLogic.Service
{
    public class PatientService : ClinicBaseService<Patient>
    {
        protected override void ValidateEntity(Patient patient)
        {
            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Họ tên ", patient.Name, 3);
            ClinicExceptionUtils.throwIllegalExpcetionIfINull("Năm sinh", patient.Birthday);
            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Địa chỉ", patient.Address, 5);
            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Số điện thoại", patient.Phone, 8);
            ClinicExceptionUtils.throwIllegalExceptionIfIsNotNumber("Số điện thoại", patient.Phone);
            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Số chứng minh nhân dân", patient.IdentityNumber, 9);
            ClinicExceptionUtils.throwIllegalExceptionIfIsNotNumber("Số chứng minh nhân dân", patient.IdentityNumber);
        }
    }
}
