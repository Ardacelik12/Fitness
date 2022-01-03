using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public interface IDataResult<T> : IResult
    {
        // interface interface i implemente ettigi icin burda ı result icin deki ozellikler gozukmese de bunda da var
        T Data { get; }

    }
}
