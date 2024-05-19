using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class PC
    {
        public string manufacturer { get; set; }
        public int numberGigaBytesOfRAM;
        public string processor;
        public string gpu;

        public override string ToString()
        {
            return $"{manufacturer}, {numberGigaBytesOfRAM} GB memory, processor: {processor}, GPU: {gpu}";
        }
    }
}
