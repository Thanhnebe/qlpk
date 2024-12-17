using BusinessLogic.Exception;
using System;
using System.Linq;

namespace BusinessLogic.Utils
{
    public sealed class ClinicExceptionUtils
    {
        public static void throwIllegalExceptionIfTextLengthLessThan(string fieldName, string fieldValue, short minimumLength)
        {
            throwIllegalExpcetionIfINull(fieldName, fieldValue);
            if (fieldValue.Length < minimumLength)
            {
                throw new ClinicEntityIllegalStateException(string.Format("{0} phải lớn hơn {1} ký tự.", fieldName, minimumLength - 1));
            }
        }

        public static void throwIllegalExceptionIfNumberValueLessThan(string fieldName, decimal fieldValue, short minimumValue)
        {
            throwIllegalExpcetionIfINull(fieldName, fieldValue);
            if (fieldValue < minimumValue)
            {
                throw new ClinicEntityIllegalStateException(string.Format("{0} phải lớn hơn {1}.", fieldName, minimumValue));
            }
        }

        public static void throwIllegalExpcetionIfINull(string fieldName, object fieldValue)
        {
            if (fieldValue == null)
            {
                throw new ClinicEntityIllegalStateException(string.Format("{0} chưa được nhập.", fieldName));
            }
        }

        public static void throwIllegalExceptionIfIsNotNumber(string fieldName, string fieldValue) {
            throwIllegalExpcetionIfINull(fieldName, fieldValue);
            bool isAllDigit = fieldValue.All(Char.IsDigit);
            if (!isAllDigit)
            {
                throw new ClinicEntityIllegalStateException(string.Format("{0} bắt buộc là số.", fieldName));
            }
        }
    }
}
