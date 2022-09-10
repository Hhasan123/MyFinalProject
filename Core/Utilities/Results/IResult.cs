using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
        //Temel void operasyonları için başlangıç
    {
        bool Success { get; }
        string Message { get; }
    }
}
