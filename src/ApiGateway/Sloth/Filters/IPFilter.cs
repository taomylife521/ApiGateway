﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiGateway.Core.Contexts;
using ApiGateway.Core.Filters;

namespace ApiGateway.Sloth.Filters
{
    public class IPFilter : IFilter
    {
        public FilterType FilterType => FilterType.Pre;
        public int FilterOrder => 15;

        public void Execute()
        {
            string ipAddress = GetClientIPAddress();
        }

        private string GetClientIPAddress()
        {
            var request = RequestContext.Current.Request;
            return request.HttpContext.Connection.RemoteIpAddress.AddressFamily.ToString();
        }
    }
}