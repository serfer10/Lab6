using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    interface IParametrs
    {
       string Name
        {
            get;set;
        }

       int Age
        {
            get;set;
        }

        void info();
    }
}
