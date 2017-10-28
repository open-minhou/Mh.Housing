using Mh.Housing.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mh.Housing.Dto
{
    public class ResponseModel
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public static ResponseModel Error(Exception ex)
        {
            //log error
            return new ResponseModel {
                Code = ConstStruct.InnerServerError,
                Message = ex.Message
            };
        }
    }
    public class ResponseModel<T> : ResponseModel
    {
        public T Data { get; set; }
    }
}
