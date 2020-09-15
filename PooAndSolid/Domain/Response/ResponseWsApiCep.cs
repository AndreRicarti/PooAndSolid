using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooAndSolid.Domain.Response
{
    public class ResponseWsApiCep
    {
        public int Status { get; set; }
        public bool Ok { get; set; }
        public string Code { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string StatusText { get; set; }
    }
}
