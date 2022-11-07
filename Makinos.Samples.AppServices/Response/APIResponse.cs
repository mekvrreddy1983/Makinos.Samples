using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Makinos.Samples.AppServices.Response
{
    public class APIResponse<T>
    {
        private T _data;
        private bool _success;
        private HttpStatusCode _statuscode;
        private List<string> _errors;

        public APIResponse(T data, bool success, HttpStatusCode statuscode, List<string> errors)
        {
            _data = data;
            _success = success;
            _statuscode = statuscode;
            _errors = errors;
        }

        public T Data
        {
            get { return _data; }
        }

        public bool Sucess
        {
            get { return _success; }
        }

        public HttpStatusCode StatusCode
        {
            get { return _statuscode; }
        }
        public List<string> Errors
        {
            get { return _errors; }
        }
    }
}
