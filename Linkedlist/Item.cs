using System;

namespace Linkedlist.Model
{
    
        public class Item<T>
        {
            private T data;

            public T Data
            {
                get { return data; }
                set
                { 
                    if (value != null)
                    data = value; 
                }
            }

            public Item<T> Next { get; set; }

            public Item(T data) 
            {
            Data = data;
            }
          
        }
    }
