using System;

namespace Learning.CSharp
{
    public class MagicServiceException : Exception
    {
        public int Code { get; }

        public MagicServiceException(string message, int code) : base(message)
        {
            Code = code;
        }
    }
}
