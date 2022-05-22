using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist.Model

{
    public class Linkedlist<T>
    {
        public Item<T> First { get; private set; }

        public Item<T> Last { get; private set; }

        public int Count { get; private set; }

        public Linkedlist()
        {
            First = null;
            Last = null;
            Count = 0;
        }
        public Linkedlist(T data) 
        {
            SetFirstAndLast(data);
        }
        public void Add(T data)
        {

            if(Last != null)
            {
                var item = new Item<T>(data);
                Last.Next = item;
                Last = item;
                Count++;
            }
            else
            {
                SetFirstAndLast(data);
            }
      
        }
        private void SetFirstAndLast(T data)
        {
            var item = new Item<T>(data);
            First = item;
            Last = item;
            Count = 1;
        }
    }
}
