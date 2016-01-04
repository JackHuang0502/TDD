using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Tests
{
    [TestClass()]
    public class Homework1Tests
    {
        [TestMethod()]
        public void SumCostTest()
        {
            //arrange
            var target = new Homework1();
            var data = GetHomeWorkProfiles();
            var expected = new List<int>
            {
               6,15,24,21
            };
            //act
            var actual = target.Sum(3,"Cost",data);
            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SumRevenueTest()
        {
            //arrange
            var target = new Homework1();
            var data = GetHomeWorkProfiles();
            var expected = new List<int>
            {
               50,66,60
            };
            //act
            var actual = target.Sum(4, "Revenue", data);
            //assert
            CollectionAssert.AreEqual(expected, actual);
        }


        private List<Homework1.HomeWorkProfile> GetHomeWorkProfiles()
        {
            var data = new List<Homework1.HomeWorkProfile>
            {
                new Homework1.HomeWorkProfile {Id = 1, Cost = 1, Revenue = 11, SellPrice = 21},
                new Homework1.HomeWorkProfile {Id = 2, Cost = 2, Revenue = 12, SellPrice = 22},
                new Homework1.HomeWorkProfile {Id = 3, Cost = 3, Revenue = 13, SellPrice = 23},
                new Homework1.HomeWorkProfile {Id = 4, Cost = 4, Revenue = 14, SellPrice = 24},
                new Homework1.HomeWorkProfile {Id = 5, Cost = 5, Revenue = 15, SellPrice = 25},
                new Homework1.HomeWorkProfile {Id = 6, Cost = 6, Revenue = 16, SellPrice = 26},
                new Homework1.HomeWorkProfile {Id = 7, Cost = 7, Revenue = 17, SellPrice = 27},
                new Homework1.HomeWorkProfile {Id = 8, Cost = 8, Revenue = 18, SellPrice = 28},
                new Homework1.HomeWorkProfile {Id = 9, Cost = 9, Revenue = 19, SellPrice = 29},
                new Homework1.HomeWorkProfile {Id = 10, Cost = 10, Revenue = 20, SellPrice = 30},
                new Homework1.HomeWorkProfile {Id = 11, Cost = 11, Revenue = 21, SellPrice = 31}
            };
            return data;
        }
    }
}