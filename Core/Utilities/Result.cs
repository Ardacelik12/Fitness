using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class Result : IResult
    {
        // getir read only dir read only liler const da set edilebilir

        public Result(bool success, string message) : this(success)
        {
            Message = message;

        }


        public Result(bool success)
        {
            Success = success;

        }


        public bool Success { get; }

        public string Message { get; }
    }
}
