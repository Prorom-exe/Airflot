using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airflot
{
    class Sorted
    {
        public static List<Flights> SortPrice(List<Flights> fly )
        {
            
            for(int i = 1; i < fly.Count; i++)
            {
                Flights tmp = fly[i];
                int j;
                for( j = i - 1;j>=0 && fly[j].Price > tmp.Price; j--)
                {
                    fly[j + 1] = fly[j];
                }
                fly[j + 1] = tmp;
              
            }
            return SortTwo(fly);
        }
       
        private static List<Flights> SortTwo(List<Flights> fly)
        {
            List<int> obl = new List<int>();
            for (int i = 0; i < fly.Count-1; i++)
            {
                
               if(fly[i].Price== fly[i+1].Price)
                {
                    obl.Add(i);
                }
                else
                {
                    if(obl.Count != 0 && fly[i].Price == fly[obl.Last()].Price)
                    {
                        obl.Add(i);
                    }
                    if (obl.Count != 0)
                    {
                        SortDeparture(fly, obl);
                        obl.Clear();
                    }
                    
                }
                
              
            }
            return fly;
        }

        private static List<Flights> SortDeparture(List<Flights> fly, List<int> obl)
        {


            for (int i = obl.First()+1; i <= obl.Last(); i++)
            {
                Flights tmp = fly[i];
                int j;
                for (j = i - 1; j >= obl.First() && fly[j].Departure.CompareTo(tmp.Departure)>0; j--)
                {
                    fly[j + 1] = fly[j];
                }
                fly[j + 1] = tmp;

            }
            return fly;
        }





    }
}
