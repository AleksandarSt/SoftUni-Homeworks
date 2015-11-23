using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterNumbers
{
    class CustomUserException : Exception
    {
        public CustomUserException()
            : base() { }

        public CustomUserException(string message)
            : base(message) { }

        public CustomUserException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public CustomUserException(string message, Exception innerException)
            : base(message, innerException) { }

        public CustomUserException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }
    }
}
