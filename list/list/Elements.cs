using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Elements<T>
    {
        private T data;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        Elements<T> next;

        internal Elements<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
