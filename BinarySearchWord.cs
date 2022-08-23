using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class BinarySearchWord
    {
        public void CreateSorted(int[] a, int n)
        { 
            List<int> b = new List<int>();

            for (int j = 0; j < n; j++)
            {
                if (b.Count == 0)
                    b.Add(a[j]);
                else
                {
                    int start = 0, end = b.Count - 1;
                    int pos = 0;

                    while (start <= end)
                    {
                        int mid = start + (end - start) / 2;
                        if (b[mid] == a[j])
                        {
                            b.Insert((Math.Max(0, mid + 1)), a[j]);
                            break;
                        }
                        else if (b[mid] > a[j])
                            pos = end = mid - 1;
                        else
                            pos = start = mid + 1;
                        if (start > end)
                        {
                            pos = start;
                            b.Insert(Math.Max(0, pos), a[j]);
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
                Console.Write(b[i] + " ");
        }
       
    }
}
