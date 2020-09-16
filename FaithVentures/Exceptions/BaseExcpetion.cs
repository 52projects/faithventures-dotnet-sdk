using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaithVentures.Models;

namespace FaithVentures.Exceptions {
    public class BaseException : ApplicationException {
        public BaseException() { }

        public BaseException(string message) : base(message) { }

        public BaseException(string message, Exception inner) : base(message, inner) { }

        public string RequestUrl { get; set; }

        public System.Net.HttpStatusCode StatusCode { get; set; }

        public string StatusDescription { get; set; }
    }

    public class ApiAccessException : BaseException {
        public ApiAccessException() { }

        public ApiAccessException(string message) : base(message) { }

        public ApiAccessException(string message, Exception inner) : base(message, inner) { }
    }
}
