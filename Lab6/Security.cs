using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Security<T>:IPass<T>
    {
        private T id;

        public T Id
        {
            get
            {
                return id;
            }
        }

        public Security(T Id)
        {
            id = Id;
        }

    }
}
