using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1.Tests
{
    [TestClass()]
    public class Homework1Tests
    {
        [TestMethod()]
        public void SumCostTest()
        {

            //arrange
            var target = new HomeWork1();

            var data = new List<HomeWorkProfile>
            {
              new HomeWorkProfile { Id=1, Cost=1,Revenue= 11, SellPrice =21},
              new HomeWorkProfile { Id=2, Cost=2,Revenue= 12, SellPrice =22},
              new HomeWorkProfile { Id=3, Cost=3,Revenue= 13, SellPrice =23},
              new HomeWorkProfile { Id=4, Cost=4,Revenue= 14, SellPrice =24},
              new HomeWorkProfile { Id=5, Cost=5,Revenue= 15, SellPrice =25},
              new HomeWorkProfile { Id=6, Cost=6,Revenue= 16, SellPrice =26},
              new HomeWorkProfile { Id=7, Cost=7,Revenue= 17, SellPrice =27},
              new HomeWorkProfile { Id=8, Cost=8,Revenue= 18, SellPrice =28},
              new HomeWorkProfile { Id=9, Cost=9,Revenue= 19, SellPrice =29},
              new HomeWorkProfile { Id=10, Cost=10,Revenue= 20, SellPrice =30},
              new HomeWorkProfile { Id=11, Cost=11,Revenue= 21, SellPrice =31}
            };

            var expected = new List<int>
            {
               6,15,24,21
            };

            //act
            var actual  =  target.SumCost(3, data);

            //assert
            CollectionAssert.AreEqual(expected, actual);
            
        }
    }
}