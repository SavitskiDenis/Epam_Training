using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Inheritance
{
    class Student : Man
    {
        private byte _yearsOfStudy;
        private byte _numberOfClassesInWeek;

        public void InputYearsOfStudy(byte _yearsOfStudy)
        {
            this._yearsOfStudy = _yearsOfStudy;
        }
        public void YearIncrement()
        {
            _yearsOfStudy++;
        }
        public byte numberOfClassesInWeek
        {
            get
            {
                return _numberOfClassesInWeek;
            }
            set
            {
                if(value>=0)
                {
                    _numberOfClassesInWeek = value;
                }
            }
        }
        public byte GetYearsOfStudy()
        {
            return _yearsOfStudy;
        }

        

    }
}
