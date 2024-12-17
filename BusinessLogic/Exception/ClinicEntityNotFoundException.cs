using System;

namespace BusinessLogic.Exception
{
    internal class ClinicEntityNotFoundException : SystemException
    {
        public ClinicEntityNotFoundException()
        {
        }

        public ClinicEntityNotFoundException(string message) : base(message)
        {
        }
    }
}
