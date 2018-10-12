using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Inheritance
{
    class Teacher : Man
    {
        private string _objectOfStudy;
        private byte _numberOfClasses;

        public string objectOfStudy
        {
            get
            {
                return _objectOfStudy;
            }
            set
            {
                if(value!="")
                {
                    _objectOfStudy = value;
                }
            }
        }

        public byte numberOfClasses
        {
            get
            {
                return _numberOfClasses;
            }
            set
            {
                if(value>=0)
                {
                    _numberOfClasses = value;
                }
            }
        }
        

    }
}
