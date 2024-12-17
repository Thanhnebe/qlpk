using BusinessLogic.Utils;
using DataAccess;
using DataAccess.Repository;

namespace BusinessLogic.Service
{
    public class MedicineService : ClinicBaseService<Medicine>
    {
        protected override void ValidateEntity(Medicine medicine)
        {
            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Tên thuốc", medicine.MedicineName, 2);

            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Hướng dẫn sử dụng", medicine.Usage, 5);

            ClinicExceptionUtils.throwIllegalExceptionIfNumberValueLessThan("Đơn giá", medicine.Price, 1);

            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Đơn vị tính phải", medicine.Unit, 1);

        }

    }
}
