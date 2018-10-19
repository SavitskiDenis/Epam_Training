using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class ListException :Exception
    {


        public ListException(string _message)
            : base(_message)
        {

        }  

    }
}
