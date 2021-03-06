using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class InsertIntervalTest
    {
        [Theory]
        [MemberData("InlineData")]
        public void TestMethod(IList<Interval> intervals, Interval newInterval, IList<Interval> output)
        {
            Assert.Equal(output, Solution057.Insert(intervals, newInterval));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                IList<Interval> intervals = new List<Interval>{
                    new Interval(1, 3),
                    new Interval(6, 9)
                };
                Interval newInterval = new Interval(2, 5);
                IList<Interval> output = new List<Interval>{
                    new Interval(1, 5),
                    new Interval(6, 9)
                };
                driverData.Add(new object[] { intervals, newInterval, output });
                
                return driverData;
            }
        }  
    }
}

