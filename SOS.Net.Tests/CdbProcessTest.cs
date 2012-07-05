using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SOS.Net.Core.Cdb;
using System.Diagnostics;
using SOS.Net.Core;

namespace SOS.Net.Tests
{
    [TestFixture]
    public class CdbProcessTest
    {
        private Process RunFakeProcess()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"..\..\..\SOS.Net\bin\Debug\SOS.Net.exe");
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process process = Process.Start(startInfo);
            return process;
        }

        private CdbProcess StartCdb(int pid)
        {
            CdbSettings settings = new CdbSettings();
            settings.CdbPath = @"C:\Program Files\Debugging Tools for Windows (x64)\";            

            return CdbProcess.Attach(settings, pid, null);
        }

        private void RunCdbTest(Action<CdbProcess> test)
        {
            using (var process = this.RunFakeProcess())
            {
                using (var cdb = this.StartCdb(process.Id))
                {
                    // do the test
                    test(cdb);
                }

                process.Kill();
            }
        }

        [Test]
        public void FetchAppDomains()
        {
            RunCdbTest(delegate(CdbProcess cdb)
            {
                var result =
                    from appDomain
                    in cdb.GetAppDomains()
                    select appDomain.Value;

                foreach (var item in result)
                    Console.WriteLine(item.Name);
            });
        }

        [Test]
        public void FetchFields()
        {
            RunCdbTest(delegate(CdbProcess cdb)
            {
                var instances =
                    from appDomain
                    in cdb.GetTypes()
                    select appDomain.GetInstances();
            });
        }
    }
}
