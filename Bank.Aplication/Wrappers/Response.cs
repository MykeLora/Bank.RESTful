using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Aplication.Wrappers
{
    public class Response<T>
    {
        public Response()
        {
        }

        public Response( T data, string message = null)
        {
            Succeed = true;
            Message = message;
            Data = data;
        }

        public Response(string message)
        {
            Succeed = false;
            Message = message;
        }

        public bool Succeed {  get; set; }
        public string Message {  get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }
    }
}
