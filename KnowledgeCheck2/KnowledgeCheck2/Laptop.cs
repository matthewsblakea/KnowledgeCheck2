using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class Laptop : PC
    {
        public float screenSizeInches;
        public bool isTwoInOne;

        public override string ToString()
        {
            return $"{manufacturer}, {numberGigaBytesOfRAM} GB memory, processor: {processor}, GPU: {gpu}, {screenSizeInches} inch screen, 2-in-1: {isTwoInOne}";
        }

    }
}
