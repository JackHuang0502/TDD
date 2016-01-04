using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class Homework1
    {
        public List<int> SumCost(int pSize, IEnumerable<HomeWorkProfile> pList)
        {
            List<int> tResultList = new List<int>();

            int tResult = 0;
            int tCount = 0;

            foreach (var homeWorkClass in pList)
            {
                tResult = tResult + homeWorkClass.Cost;
                tCount ++;
                if (tCount + 1 > pSize)
                {
                    tResultList.Add(tResult);
                    tResult = 0;
                    tCount = 0;
                }
            }

            return tResultList;
           
        }

        public List<int> SumRevenue(int pSize, IEnumerable<HomeWorkProfile> pList )
        {
            List<int> tResultList = new List<int>();

            int tResult = 0;
            int tCount = 0;

            foreach (var homeWorkClass in pList)
            {
                tResult = tResult + homeWorkClass.Revenue;
                tCount++;
                if (tCount + 1 > pSize)
                {
                    tResultList.Add(tResult);
                    tResult = 0;
                    tCount = 0;
                }
            }

            return tResultList;
        }

    }

    public class HomeWorkProfile
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }


    }


}
