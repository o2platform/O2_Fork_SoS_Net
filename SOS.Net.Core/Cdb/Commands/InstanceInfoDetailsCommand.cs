using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace SOS.Net.Core.Cdb.Commands
{
    public class InstanceInfoDetailsCommand : ICdbCommand<CdbQueryable<InstanceInfoDetails>>
    {
        private string instanceAddress;

        private int? index;

        public InstanceInfoDetailsCommand(string instanceAddress)
        {
            this.instanceAddress = instanceAddress;
            this.index = null;
        }

        public InstanceInfoDetailsCommand(string instanceAddress, int index)
        {
            this.instanceAddress = instanceAddress;
            this.index = index;
        }

        public IEnumerable<CdbQueryable<InstanceInfoDetails>> Result(CdbProcess process)
        {
            // TODO refactoring to avoid copy/paste bewteen both functions
            if (this.index == null)
                return this.DumpObject(process);
            else
                return this.DumpArray(process);
        }

        private IEnumerable<CdbQueryable<InstanceInfoDetails>> DumpArray(CdbProcess process)
        {
            InstanceInfoDetails result = new InstanceInfoDetails();
            result.Address = this.instanceAddress;
            result.Index = this.index.Value.ToString();

            var output = process.ExecuteCommand(string.Format("!DumpArray -details {0}", this.instanceAddress));
            StringReader reader = new StringReader(output);

            string line = reader.ReadLine();
            while (line != null)
            {
                while (line != null && !line.StartsWith("Element Methodtable"))
                    line = reader.ReadLine();

                while (line != null && !Regex.IsMatch(line, string.Format("\\[{0}\\].*", this.index)))
                    line = reader.ReadLine();

                while (line != null)
                {
                    var match = Regex.Match(line, ".*Name: (.*)");
                    if (match.Success)
                    {
                        result.Name = match.Groups[1].Value;
                    }

                    match = Regex.Match(line, ".*String: (.*)");
                    if (match.Success)
                    {
                        StringBuilder toString = new StringBuilder();
                        toString.AppendLine(match.Groups[1].Value);

                        // read the other lines to reach the "Fields"
                        match = Regex.Match(line, ".*Fields: (.*)");
                        while (!match.Success && line != null)
                        {
                            line = reader.ReadLine();
                            if (line != null)
                            {
                                match = Regex.Match(line, ".*Fields:(.*)");
                                if (!match.Success)
                                    toString.AppendLine(line);
                            }
                        }
                        result.String = toString.ToString();
                    }
                    line = reader.ReadLine();
                }
            }

            return new CdbQueryable<InstanceInfoDetails>[] { new CdbQueryable<InstanceInfoDetails>(result, process) };
        }

        private IEnumerable<CdbQueryable<InstanceInfoDetails>> DumpObject(CdbProcess process)
        {
            InstanceInfoDetails result = new InstanceInfoDetails();
            result.Address = this.instanceAddress;

            var output = process.ExecuteCommand(string.Format("!DumpObj {0}", this.instanceAddress));
            StringReader reader = new StringReader(output);

            string line = reader.ReadLine();
            while (line != null)
            {
                var match = Regex.Match(line, ".*Name: (.*)");
                if (match.Success)
                {
                    result.Name = match.Groups[1].Value;
                }

                match = Regex.Match(line, ".*String: (.*)");
                if (match.Success)
                {
                    StringBuilder toString = new StringBuilder();
                    toString.AppendLine(match.Groups[1].Value);

                    // read the other lines to reach the "Fields"
                    match = Regex.Match(line, ".*Fields: (.*)");
                    while (!match.Success && line != null)
                    {
                        line = reader.ReadLine();
                        if (line != null)
                        {
                            match = Regex.Match(line, ".*Fields:(.*)");
                            if (!match.Success)
                                toString.AppendLine(line);
                        }
                    }
                    result.String = toString.ToString();
                }
                line = reader.ReadLine();
            }

            output = process.ExecuteCommand(string.Format("!ObjSize {0}", this.instanceAddress));
            var sizeMatch = Regex.Match(output, ".*sizeof\\(.*\\) = *([^ ]*) *\\(.*\\) bytes.*");
            if (sizeMatch.Success)
                result.TrueSize = sizeMatch.Groups[1].Value;

            return new CdbQueryable<InstanceInfoDetails>[]{ new CdbQueryable<InstanceInfoDetails>(result, process)};
        }
    }
}