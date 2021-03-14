using Microsoft.SqlServer.Dts.Runtime;
using System.Collections.Generic;

namespace DirectPackagePathExecution
{
    public class PackageEvents : DefaultEvents
    {
        private List<ErrorMsg> _msg;
        public PackageEvents()
        {
            _msg = new List<ErrorMsg>();
        }

        public List<ErrorMsg> ErrorMessages
        {
            get { return _msg; }
            set { _msg = value; }
        }

        public override bool OnError(DtsObject source, int errorCode, string subComponent, string description, string helpFile, int helpContext, string idofInterfaceWithError)
        {
            ErrorMsg msge = new ErrorMsg
            {
                Component = subComponent,
                Description = description
            };
            _msg.Add(msge);
            return false;
        }
    }
    public class ErrorMsg
    {
        public string Component { get; set; }
        public string Description { get; set; }
    }
}
