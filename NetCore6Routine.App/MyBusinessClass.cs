using Microsoft.Extensions.Options;
using NetCore6Routine.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NetCore6Routine.App
{
    public class MyBusinessClass
    {
        public Parameters? Parameters { get; set; }

        public MyBusinessClass(IOptions<AppSettings> options)
        {
            if (options.Value.Enviroment == "DEV")
                Parameters = options.Value.DevParameters;
            else if (options.Value.Enviroment == "HML")
                Parameters = options.Value.HmlParameters;
            else if (options.Value.Enviroment == "PRD")
                Parameters = options.Value.ProdParameters;
        }

        public void Run() 
        {
            var parameters = Parameters;
        }
    }
}
