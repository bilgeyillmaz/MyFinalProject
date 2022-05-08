using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{  // yalnızca getter, sadece okunabilir. setter:yazmak için kullanılır.
   public interface IResult
    {
        public bool Success { get;} 
        public string Message { get; }
    }
}
