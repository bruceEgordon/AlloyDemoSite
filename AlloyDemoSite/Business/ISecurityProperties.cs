using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlloyDemoSite.Business
{
    public interface ISecurityProperties
    {
        bool RequiresHttps { get; }
    }
}
