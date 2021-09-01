using DomainLayer.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ResponseModel
    {
        public ResponseModel(ResponseCode responseCode, string responseMessage, object dataset)
        {
            ResponseCode = responseCode;
            ResponseMessage = responseMessage;
            DateSet = dataset;
        }
        public ResponseCode ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public object DateSet { get; set; }
    }
}
