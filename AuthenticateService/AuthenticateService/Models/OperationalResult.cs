using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticateService.Models
{
    public class OperationalResult
    {
        public bool IsSuccess { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
}
