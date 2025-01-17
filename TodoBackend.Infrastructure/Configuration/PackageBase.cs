using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoBackend.Infrastructure.Configuration
{
    internal class PackageBase
    {
        string? connStr;
        IConfiguration configuration;

        public PackageBase(IConfiguration configuration)
        {
            this.configuration = configuration;
            connStr = this.configuration.GetConnectionString("OracleConnStr");
        }
        protected string ConnStr
        {
            get { return connStr; }
        }
    }
}
