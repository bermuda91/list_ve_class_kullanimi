using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_ve_class_kullanimi
{
    class MyIntList
    {
        /* 2 metod var, List elemanına veri ekliyor. Daha sonra indis numarası ile veri getiriyor. */
        private List<int> mNumbers = new List<int>();

        public void AddNumber(int number)
        {
            mNumbers.Add(number);
        }

        public int GetNumber(int i)
        {
            return mNumbers[i];
        }
    }
}
