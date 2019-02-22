using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Vavatech.EFCore.IServices;

namespace Vavatech.EFCore.FakeServices
{
    public class SmsSenderService : ISenderService
    {
        public void Send(string message)
        {
            Trace.WriteLine($"SMS {message}");
        }
    }
}
