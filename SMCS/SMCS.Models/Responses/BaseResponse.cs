using SMCS.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Models.Responses
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public string Message { get;set;}

        public StatusCode StatusCode {get;set;}

        public T Data {get;set;}
    }
}
