using System;
using System.Collections.Generic;

namespace TestApplication
{
    public class FindMaxQualityOfPacket
    {
        public static long maximumQuality(List<int> packets, int channels)
        {
            var packetsCount = packets.Count;
        
            double result = 0;
            if(packetsCount == channels) {
                for(var i = 0;i<packetsCount;i++) {
                    result += packets[i];
                }
                return (long)result;
            }
            packets.Sort();
        
            for(var i = packetsCount - channels+1;i<packetsCount;i++) {
                result += packets[i];
            }
        
            packetsCount -= channels;
            if(packetsCount%2 == 0) {
                result += packets[packetsCount/2];
            }
            else {
                double value = packets[packetsCount/2] + packets[(packetsCount/2) + 1];
                result += value/2;
            }
            return (long)Math.Ceiling(result);
        }
        
        public static long findMaxProducts(List<int> products) {
            var l = products.Count;
            long max = 0;
            for(var i=l-1;i>=0;--i) {
                if(i!=l-1 && products[i] < products[i+1]) continue;
                long localMax = products[i];
                var prev = localMax;
                for(var j=i-1;j>=0;--j) {
                    prev = Math.Min(prev-1, products[j]);
                    localMax+=prev;
                    if(prev==1) break;
                }
                max = Math.Max(localMax,max);
            }
            return max;
        }
    }
    
    
    
}