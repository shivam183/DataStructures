﻿using Shivam_Sood_Lab04_Ex03_1;

namespace Shivam_Sood_Lab04_Ex03
{
    public class QueueInheritance : List
    {
        // pass name "queue" to List constructor
        public QueueInheritance() : base("queue") { }

        // place dataValue at end of queue by inserting 
        // dataValue at end of linked list
        public void Enqueue(string dataValue)
        {
            InsertAtBack(dataValue);
        }

        // remove item from front of queue by removing
        // item at front of linked list
        public object Dequeue()
        {
            return RemoveFromFront();
        }
    }
}
