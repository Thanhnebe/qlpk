using BusinessLogic.Utils;
using DataAccess;
using DataAccess.Repository;

namespace BusinessLogic.Service
{
    public class DiseaseService : ClinicBaseService<Disease>
    {
        protected override void ValidateEntity(Disease disease)
        {
            ClinicExceptionUtils.throwIllegalExceptionIfTextLengthLessThan("Tên bệnh", disease.DiseaseName, 2);
        }
    }
}
