using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message): this (success) //iki parametre gönderen biri için 9.satır çalışacak, ama this yani Result classındaki success i de çalıştır.
                                                                    //Bu ctor Base olarak success ctorını da içeriyor.
        {
            Message = message;
            //Success = success; //biz tip dönüşümlerini ctor aracılığı ile yapacağız bu nedenle aşağıda setter tanımlamadık.
        }
        public Result(bool success)//mesaj yazmak istemiyorsak bu metodu kullanırız,OVERLOADING
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; } //getter readonlydir READONLY CONSTRUCTOR ile Set edilebilir.
    }
}
