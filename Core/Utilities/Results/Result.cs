using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)//this(success) success parametresine ihtiyaç duyan bir Constructor ı da beraberinde çalıştırır. Bu sayede kod(success bilgisi) tekrarlanmak zorunda kalmaz.
        {
            Message = message;
            //Normalde Message nesnesi yalnızca okunabilen bir metoddur ve set edilemezdir. Aşağıdaki
            //tanımlanan Message nesnesi Constructor bloğu dışında hiçbir yerde set edilemez. Bu da
            //Message nesnesinin diğer kişiler tarafından istenilmeyecek şekilde set edilmesi ile suistimalinin
            //önüne geçer.
            //Kısacası Readonly nesneleri Constructor içerisinde set edilebilir.
        }
        public Result(bool success)
        {
            //İşlem sonucunda metin döndürülmesi istenmemesi durumu için overload edilebilecek
            //bir constructor yapısı kurulabilir.
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
