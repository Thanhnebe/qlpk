using BusinessLogic.Utils;
using DataAccess;
using DataAccess.Repository;

namespace BusinessLogic.Service
{
    public class DoctorService : ClinicBaseService<Doctor>
    {
        protected override void ValidateEntity(Doctor doctor)
        {
            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Họ tên", doctor.Name, 3);

            ClinicExceptionUtils.throwIllegalExpcetionIfINull("Năm sinh", doctor.Birthday);

            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Địa chỉ", doctor.Address, 5);

            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Số điện thoại", doctor.Phone, 8);

            ClinicExceptionUtils.throwIllegalExceptionIfIsNotNumber("Số điện thoại", doctor.Phone);

            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Số chứng minh nhân dân", doctor.IdentityNumber, 9);

            ClinicExceptionUtils.throwIllegalExceptionIfIsNotNumber("Số chứng minh nhân dân", doctor.IdentityNumber);

            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Chuyên ngành", doctor.Major, 1);

            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Trình độ", doctor.Degree, 2);
        }

    }
}
