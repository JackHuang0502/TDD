using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Homework1
    {



        public List<int> Sum(int pSize, string pColumnName, List<HomeWorkProfile> pList)
        {
            List<int> tResultList = new List<int>();

            int tResult = 0;
            int tCount = 0;

            for (int i = 0; i < pList.Count; i++)
            {
                var homeWorkClass = pList[i];
                tResult = tResult + homeWorkClass.GetValue(pColumnName);
                tCount++;

                if (tCount + 1 > pSize)
                {
                    tResultList.Add(tResult);
                    tResult = 0;
                    tCount = 0;
                }
                else if (i == pList.Count - 1)
                {
                    tResultList.Add(tResult);
                }

            }
            return tResultList;
        }


        //    public List<int> SumCost(int pSize, List<HomeWorkProfile> pList)
        //    {
        //        List<int> tResultList = new List<int>();

        //        int tResult = 0;
        //        int tCount = 0;

        //        for (int i = 0; i < pList.Count; i++)
        //        {
        //            var homeWorkClass = pList[i];
        //            tResult = tResult + homeWorkClass.Cost;
        //            tCount++;

        //            if (tCount + 1 > pSize)
        //            {
        //                tResultList.Add(tResult);
        //                tResult = 0;
        //                tCount = 0;
        //            }
        //            else if (i == pList.Count - 1)
        //            {
        //                tResultList.Add(tResult);
        //            }

        //        }

        //        return tResultList;

        //    }


        //    public List<int> SumRevenue(int pSize, List<HomeWorkProfile> pList)
        //    {

        //        List<int> tResultList = new List<int>();

        //        int tResult = 0;
        //        int tCount = 0;

        //        for (int i = 0; i < pList.Count; i++)
        //        {
        //            var homeWorkClass = pList[i];
        //            tResult = tResult + homeWorkClass.Revenue;
        //            tCount++;

        //            if (tCount + 1 > pSize)
        //            {
        //                tResultList.Add(tResult);
        //                tResult = 0;
        //                tCount = 0;
        //            }
        //            else if (i == pList.Count - 1)
        //            {
        //                tResultList.Add(tResult);
        //            }

        //        }
        //        return tResultList;
        //    }
        //}

        public class HomeWorkProfile
        {
            public int Id { get; set; }
            public int Cost { get; set; }
            public int Revenue { get; set; }
            public int SellPrice { get; set; }

            public int GetValue(string pColumnName)
            {
                Type tType = typeof (HomeWorkProfile);
                PropertyInfo tPropInfo = tType.GetProperty(pColumnName);
                return (int) tPropInfo.GetValue(this);
            }
        }

    }
}
