using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace RefitExample.Service
{
    public static class RefitServiceGenerator
    {
        public static IRefitService GetService()
        {
            return RestService.For<IRefitService>("http://uinames.com/api");
        }

    }
}
