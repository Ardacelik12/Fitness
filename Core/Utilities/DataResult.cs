using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class DataResult<T> : Result, IDataResult<T>

    {
        // data result result ın cocugu oldugu icin result da ı result ın seylerini imp ettigi icin bu etmek zorunda degil.
        public DataResult(T data, bool success, string message) : base(success, message)
        {

            Data = data;
        }



        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }

}
