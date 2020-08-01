using System;
using System.Collections.Generic;
using System.Text;

namespace TDDBC2020
{
    /// <summary>
    /// 整数閉区間を示すクラス
    /// </summary>
    public class Range
    {
        private int lowerEndpoint; // lower endpoint
        private int upperEndpoint; // upper endpoint

        public Range(int lowerEndpoint, int upperEndpoint)
        {
            this.lowerEndpoint = lowerEndpoint;
            this.upperEndpoint = upperEndpoint;
        }

        public override string ToString()
        {
            return String.Format($"[{lowerEndpoint},{upperEndpoint}]");
        }
    }
}
