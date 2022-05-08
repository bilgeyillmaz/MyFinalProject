using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public  interface IDataResult<T>:IResult
    {
        //DATA- MESAJ ve İŞLEM SONUCU döndürecek, mesaj ve işlem sonucunu IResult barındırıyor, bu nedenle implemente ediliyor.
        T Data { get; }
    }
}
