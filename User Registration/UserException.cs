using System;
using System.Collections.Generic;
using System.Text;
//UserDefined Exception
namespace UserRegistration
{
    public class UserException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL_ID,
            INVALID_MOBILE_NUMBER
        }
        private readonly ExceptionType type;
        public UserException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
