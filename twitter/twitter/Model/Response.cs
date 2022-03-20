using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace twitter.Model
{
    public class Response
    {
        public Response(bool status,String Mes , dynamic ResObj)
        {
            this.Status = status;
            this.Message = Mes;
            this.ResponseObj = ResObj;
        }
        public bool Status { get; set; }
        public String Message { get; set; }
        public dynamic ResponseObj { get; set; }
    }
}
