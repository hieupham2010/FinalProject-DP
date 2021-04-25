using ManageCoffe.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataTransferObject
{
    public class NullAccount : INull
    {
        public bool IsNull()
        {
            return true;
        }
    }
}
