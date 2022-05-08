using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message):base(data, true, message)
        {

        }
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        public SuccessDataResult(string message) : base(default, true, message) //çalıştığın T nin default u int vs., data döndürmek istemediğin zaman.
        {

        }
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
