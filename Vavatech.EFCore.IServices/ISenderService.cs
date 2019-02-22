using System;
using System.Collections.Generic;
using System.Text;

namespace Vavatech.EFCore.IServices
{
    public interface ISenderService
    {
        void Send(string message);
    }
}
