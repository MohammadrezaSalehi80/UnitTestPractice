using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculater.TestData
{
    //MemberData
    //this Class should be a static
    public static class DataForTest
    {
        //this Method Must Return a IEnumerable
        public static List<object[]> GetData()
        {
            List<object[]> data = new List<object[]>();

            //{x, y, expect}
            data.Add(new object[] { 5, 3, 8 });
            return data;
        }
    }
}
