using System;

namespace BusinessLogic.Exception
{
    internal class ClinicEntityIllegalStateException : SystemException
    {
        public ClinicEntityIllegalStateException()
        {
        }

        public ClinicEntityIllegalStateException(string message) : base(message)
        {
        }
    }
}
