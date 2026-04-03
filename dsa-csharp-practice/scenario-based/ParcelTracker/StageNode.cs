using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.ParcelTracker
{
    internal class StageNode
    {
        public string StageName;
        public StageNode Next;
        public StageNode(string stageName)
        {
            StageName = stageName;
            Next = null;
        }
    }
}
